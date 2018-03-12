using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Globalization;

namespace WhipsShipRecolorTool
{
    public partial class MainForm : Form
    {
        //make new string called offsetText to switch to instead of doing conversions
        const string myVersionString = "0.0.1.6";
        const string buildDateString = "3/11/18";
        const string githubVersionUrl = "https://github.com/Whiplash141/WhipsShipRecolorTool/releases/latest";

        string formTitle = $"Whip's Ship Recolor Tool (Version {myVersionString} - {buildDateString})";

        string filepath = "";
        string originalText = "";
        string text = "";
        string maskToReplace = "";
        string offsetText = "";
        string notOffsetText = "";

        const string fileExtension = ".sbc";
        const string fileExtensionBackup = "_backup.sbc";
        //const string maskPattern = "<ColorMaskHSV( *?)x=\"-?[0-9]*.?[0-9]*?\"( *?)y=\"-?[0-9]*.?[0-9]*?\"( *?)z=\"-?[0-9]*.?[0-9]*?\"( *?)/>";
        const string maskPattern = "<ColorMaskHSV( *?)x=\"-?[0-9]*?.?[0-9]*?[Ee]?[+-]?[0-9]*?\"( *?)y=\"-?[0-9]*?.?[0-9]*?[Ee]?[+-]?[0-9]*?\"( *?)z=\"-?[0-9]*?.?[0-9]*?[Ee]?[+-]?[0-9]*?\"( *?)/>";

        Color replacementColor = Color.Black;

        Dictionary<string, ColorVector> uniqueColors = new Dictionary<string, ColorVector>();

        ColorVector hsvVectorToReplace = new ColorVector(0,0,0);

        public MainForm()
        {
            InitializeComponent();

            //Set file filter
            openFileDialog1.Filter = "Blueprint Files (*.sbc) | *.sbc";

            //Set initial file directory
            var appDataLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            if (!string.IsNullOrWhiteSpace(appDataLocation))
            {
                var desiredDirectory = appDataLocation + @"\SpaceEngineers\Blueprints\local";
                if (Directory.Exists(desiredDirectory))
                    openFileDialog1.InitialDirectory = desiredDirectory;
            }

            textBoxOutput.Cursor = Cursors.IBeam;

            //Set form name
            this.Text = formTitle;

            //Check for any new updates
            StartUpdateBackgroundWorker();
        }

        #region Update Checking
        void StartUpdateBackgroundWorker()
        {
            if (!backgroundWorkerUpdate.IsBusy)
            {
                backgroundWorkerUpdate.RunWorkerAsync();
            }
        }

        private void backgroundWorkerUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForUpdates();
        }

        private void backgroundWorkerUpdate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (closeForm)
                this.Close();
        }

        bool closeForm = false;

        void CheckForUpdates()
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(githubVersionUrl);
            webRequest.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
            webRequest.AllowAutoRedirect = true;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;


            var webResponse = (HttpWebResponse)webRequest.GetResponse();

            var latestVersionUrl = webResponse.ResponseUri.ToString();
            var urlSplit = latestVersionUrl.Split('/');
            if (urlSplit.Length < 1)
                return;

            var latestVersionString = urlSplit[urlSplit.Length - 1];
            latestVersionString = latestVersionString.ToUpperInvariant().Replace("V", "");

            Version latestVersion = new Version();
            if (!Version.TryParse(latestVersionString, out latestVersion))
                return;

            Version myVersion = new Version();
            if (!Version.TryParse(myVersionString, out myVersion))
                return;

            if (latestVersion > myVersion)
            {
                var confirmResult = MessageBox.Show($"Old version detected. Update to newest version?\nYour version: {myVersionString}\nLatest release: {latestVersionString}",
                    "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (confirmResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(githubVersionUrl);
                    closeForm = true;
                    //this.Close();
                }
            }
        }
        #endregion

        public struct ColorVector
        {
            public float X { get; private set; }
            public float Y { get; private set; }
            public float Z { get; private set; }

            public ColorVector(float x, float y, float z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            #region Operators
            public static ColorVector operator +(float num, ColorVector color)
            {
                return new ColorVector(color.X + num, color.Y + num, color.Z + num);
            }

            public static ColorVector operator +(ColorVector color, float num)
            {
                return new ColorVector(color.X + num, color.Y + num, color.Z + num);
            }

            public static ColorVector operator *(float num, ColorVector color)
            {
                return new ColorVector(color.X * num, color.Y * num, color.Z * num);
            }

            public static ColorVector operator *(ColorVector color, float num)
            {
                return new ColorVector(color.X * num, color.Y * num, color.Z * num);
            }
            #endregion

            public string ToMaskString()
            {
                var format = new NumberFormatInfo();
                format.NumberDecimalSeparator = ".";

                return $"<ColorMaskHSV x=\"{X.ToString(format)}\" y=\"{Y.ToString(format)}\" z=\"{Z.ToString(format)}\" />";
            }

            public string HSVToString()
            {
                return $"H: {X:N0}, S: {Y:N0}, V: {Z:N0}";
            }

            public static ColorVector FromColor(Color color)
            {
                return new ColorVector(color.R, color.G, color.B);
            }

            public ColorVector HSVToColorMask()
            {
                float hueProportion = X / 360f;
                float saturationProportion = Y * .01f; // this.m_saturationSlider.value;
                float valueProportion = Z * .01f; //this.m_valueSlider.value;

                float adjustedSaturationProportion = saturationProportion - 0.8f;
                float adjustedValueProportion = valueProportion - 0.55f + 0.1f;

                return new ColorVector(hueProportion, adjustedSaturationProportion, adjustedValueProportion);
            }

            public ColorVector ColorMaskToHSV()
            {
                float saturationProportion = Y + 0.8f;
                float valueProportion = Z + 0.55f - 0.1f;

                float hue = X * 360f;
                float saturation = saturationProportion * 100f;
                float value = valueProportion * 100f;

                return new ColorVector(Clamp(hue, 0f, 360f), Clamp(saturation, 0f, 100f), Clamp(value, 0f, 100f));
            }

            //https://en.wikipedia.org/wiki/HSL_and_HSV#From_HSV
            public ColorVector HSVToRGB()
            {
                float saturationProportion = Y * .01f;
                float valueProportion = Z * .01f;

                float chroma = valueProportion * saturationProportion;
                float hPrime = X / 60f;
                float x = chroma * (1 - Math.Abs(hPrime % 2 - 1));

                ColorVector rgb = new ColorVector(0, 0, 0);

                if (hPrime <= 1)
                {
                    rgb.X = chroma;
                    rgb.Y = x;
                }
                else if (hPrime <= 2)
                {
                    rgb.X = x;
                    rgb.Y = chroma;
                }
                else if (hPrime <= 3)
                {
                    rgb.Y = chroma;
                    rgb.Z = x;
                }
                else if (hPrime <= 4)
                {
                    rgb.Y = x;
                    rgb.Z = chroma;
                }
                else if (hPrime <= 5)
                {
                    rgb.X = x;
                    rgb.Z = chroma;
                }
                else if (hPrime <= 6)
                {
                    rgb.X = chroma;
                    rgb.Z = x;
                }

                float m = valueProportion - chroma;

                rgb += m;
                rgb *= 255;

                return rgb;
            }

            //https://www.rapidtables.com/convert/color/rgb-to-hsv.html
            public ColorVector RGBToHSV()
            {
                float div = 1f / 255f;
                float r = X * div;
                float g = Y * div;
                float b = Z * div;
                float cmax = Max(new float[] { r, g, b });
                float cmin = Min(new float[] { r, g, b });
                float delta = cmax - cmin;

                float h = 0, s = 0, v = 0;
                
                //Hue
                if (delta == 0f)
                {
                    h = 0;
                }
                else if (cmax == r)
                {
                    h = 60 * (((g - b) / delta) % 6f);
                }
                else if (cmax == g)
                {
                    h = 60 * ((b - r) / delta + 2);
                }
                else if (cmax == b)
                {
                    h = 60 * ((r - g) / delta + 4);
                }

                if (h < 0)
                    h = 360f + h;

                //Saturation
                if (cmax != 0)
                    s = delta / cmax;

                //Value
                v = cmax;

                return new ColorVector(h, s * 100f, v * 100f);
            }

            public Color RGBToColor()
            {
                int red = (int)Clamp((float)Math.Round(X), 0, 255);
                int green = (int)Clamp((float)Math.Round(Y), 0, 255);
                int blue = (int)Clamp((float)Math.Round(Z), 0, 255);
                return Color.FromArgb(255, red, green, blue);
            }

            private static float Max(float[] nums)
            {
                var max = 0f;
                foreach(var num in nums)
                {
                    if (num > max)
                        max = num;
                }
                return max;
            }

            private static float Min(float[] nums)
            {
                var min = 1000f;
                foreach (var num in nums)
                {
                    if (num < min)
                        min = num;
                }
                return min;
            }

            public ColorVector Round()
            {
                return new ColorVector((float)Math.Round(X), (float)Math.Round(Y), (float)Math.Round(Z));
            }

            public ColorVector ClampRGB()
            {
                var r = Clamp(X, 0f, 255f);
                var g = Clamp(Y, 0f, 255f);
                var b = Clamp(Z, 0f, 255f);
                return new ColorVector(r, g, b);
            }

            public static float Clamp(float num, float min, float max)
            {
                return num > max ? max : (num < min ? min : num);
            }

            public ColorVector ClampHSV()
            {
                var h = Clamp(X, 0f, 360f);
                var s = Clamp(Y, 0f, 100f);
                var v = Clamp(Z, 0f, 100f);
                return new ColorVector(h, s, v);
            }

            public static ColorVector HSVFromMaskString(string mask)
            {
                if (!Regex.IsMatch(mask, maskPattern))
                {
                    //Console.WriteLine("Regex did not match");
                    return new ColorVector(0, 0, 0);
                }

                mask = mask.Replace(" ", ""); //remove spaces

                var maskSplit = mask.Split('"');

                if (maskSplit.Length < 6)
                    return new ColorVector(0, 0, 0);

                float h = 0, s = 0, v = 0;

                var format = new NumberFormatInfo();
                format.NumberDecimalSeparator = ".";

                if (!float.TryParse(maskSplit[1], (NumberStyles.Number | NumberStyles.AllowExponent), format, out h) || !float.TryParse(maskSplit[3], (NumberStyles.Number | NumberStyles.AllowExponent), format, out s) || !float.TryParse(maskSplit[5], (NumberStyles.Number | NumberStyles.AllowExponent), format, out v))
                {
                    /*
                    Console.WriteLine("Color failed to parse");
                    Console.WriteLine(float.TryParse(maskSplit[1], NumberStyles.Number, format, out h));
                    Console.WriteLine(float.TryParse(maskSplit[3], NumberStyles.Number, format, out s));
                    Console.WriteLine(float.TryParse(maskSplit[5], NumberStyles.Number, format, out v));
                    */
                    return new ColorVector(0, 0, 0);
                }

                ColorVector hsvMask = new ColorVector(h, s, v);

                return hsvMask.ColorMaskToHSV();

                //<ColorMaskHSV x="0" y="-0.8" z="7.450581E-09" />
                //      0          1  2    3   4     5          6
            }

            public override string ToString()
            {
                return $"<{X}, {Y}, {Z}>";
            }
        }

        void LoadBlueprint()
        {
            textBoxOutput.AppendText("\n\r-----------------------------------------\r\n");
            textBoxOutput.AppendText("Loading file...\r\n");
            textBoxOutput.AppendText($"path: {filepath}\r\n");
            //Load file
            originalText = File.ReadAllText(filepath);
            textBoxOutput.AppendText("File loaded successfully!");

            text = originalText;

            groupBoxHSV.Enabled = true;
            buttonReplace.Enabled = true;
            buttonPickColor.Enabled = true;
            buttonAddColor.Enabled = true;
            buttonSave.Enabled = true;
            pictureBoxColorPreview.Enabled = true;

            text = RoundColors(text, maskPattern);
            GetUniqueColors(text, maskPattern);
            WriteColorsToListBox();
            CreateColorOffsets();
        }

        HashSet<string> uniqueStrings = new HashSet<string>();
        string RoundColors(string text, string maskPattern)
        {
            var matches = Regex.Matches(text, maskPattern);

            uniqueStrings.Clear();
            foreach (var match in matches)
            {
                var matchString = match.ToString();
                uniqueStrings.Add(matchString);
            }

            foreach (var matchString in uniqueStrings)
            {
                var color = ColorVector.HSVFromMaskString(matchString).ClampHSV().Round();
                var roundedColorString = color.HSVToColorMask().ToMaskString();
                text = text.Replace(matchString, roundedColorString);
            }
            return text;
        }

        void GetUniqueColors(string text, string maskPattern)
        {
            var matches = Regex.Matches(text, maskPattern);
            int count = 0;
            uniqueColors.Clear();

            textBoxOutput.AppendText("\r\n-----------------------------------------\r\n");
            textBoxOutput.AppendText("Getting unique colors\r\n");

            foreach (var match in matches)
            {
                count++;
                var matchString = match.ToString();
                var color = ColorVector.HSVFromMaskString(matchString);
                uniqueColors[matchString] = color;
            }

            foreach (var kvp in uniqueColors)
            {
                textBoxOutput.AppendText($"mask: {kvp.Key}\r\n");
                textBoxOutput.AppendText($"hsv: {ColorVector.HSVFromMaskString(kvp.Key)}\r\n");
            }

            textBoxOutput.AppendText(($"Regex matches: {count}\r\n"));
            textBoxOutput.AppendText($"Unique regex matches: {uniqueColors.Count}\r\n");
        }

        List<string> displayStrings = new List<string>();

        void WriteColorsToListBox()
        {
            textBoxOutput.AppendText("\n\r-----------------------------------------\r\n");
            textBoxOutput.AppendText("Writing colors to list box\r\n");

            displayStrings.Clear();

            foreach (var kvp in uniqueColors)
            {
                string thisOutput = "";
                if (checkBoxShowRGB.Checked)
                    thisOutput = $"RGB: {kvp.Value.HSVToRGB().Round().ClampRGB()}";
                else
                    thisOutput = $"HSV: {kvp.Value.Round().ClampHSV()}";

                displayStrings.Add(thisOutput);
            }

            listBoxColors.DataSource = null;
            listBoxColors.DataSource = displayStrings;
        }

        void ReplaceColor()
        {
            listBoxColors.ClearSelected();
            textBoxOutput.AppendText("\n\r-----------------------------------------\r\n");
            textBoxOutput.AppendText($"Replacing color\r\n");
            var rgb = ColorVector.FromColor(replacementColor);
            textBoxOutput.AppendText($"RGB: {rgb}\r\n");
            var hsv = rgb.RGBToHSV().Round();
            textBoxOutput.AppendText($"HSV: {hsv}\r\n");
            var hsvMask = hsv.ClampHSV().HSVToColorMask().ToMaskString(); //clamps before converting to the mask
            textBoxOutput.AppendText($"mask: {hsvMask}\r\n");

            text = text.Replace(maskToReplace, hsvMask);

            GetUniqueColors(text, maskPattern);
            WriteColorsToListBox();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            textBoxOutput.AppendText("\n\r-----------------------------------------\r\n");
            textBoxOutput.AppendText("Browse for file\r\n");
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            filepath = openFileDialog1.FileName;
            textBoxFilePath.Text = filepath;
            checkBoxVisualUpdate.Checked = false;
            checkBoxVisualUpdate.Enabled = true;
            checkBoxShowRGB.Enabled = true;

            LoadBlueprint();
        }

        void ShowColorPicker()
        {
            textBoxOutput.AppendText("\n\r-----------------------------------------\r\n");
            textBoxOutput.AppendText("Color picker opened\r\n");

            var customColors = customColorList.ToArray();
            colorDialog1.CustomColors = customColors;

            var result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBoxColorPreview.BackColor = colorDialog1.Color;
                replacementColor = colorDialog1.Color;

                var rgb = ColorVector.FromColor(colorDialog1.Color);
                var hsv = rgb.RGBToHSV().ClampHSV();
                numericUpDownHue.Value = (decimal)hsv.X;
                numericUpDownSaturation.Value = (decimal)hsv.Y;
                numericUpDownValue.Value = (decimal)hsv.Z;
            }

            customColors = colorDialog1.CustomColors;
            var newCustomColors = new List<int>(customColors);
            newCustomColors.RemoveAll(x => x == 16777215);
            textBoxOutput.AppendText($"Custom colors: {newCustomColors.Count}\r\n");

            customColorList = newCustomColors;
        }

        private void buttonPickColor_Click(object sender, EventArgs e)
        {
            ShowColorPicker();
        }

        private void listBoxColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = listBoxColors.SelectedIndex;
            if (index == -1)
                return;

            maskToReplace = uniqueColors.Keys.ElementAt(index);
            hsvVectorToReplace = uniqueColors[maskToReplace];

            var colorToReplace = hsvVectorToReplace.HSVToRGB().RGBToColor();
            replacementColor = colorToReplace; //default to the same to avoid issues

            textBoxOutput.AppendText("\n\r-----------------------------------------\r\n");
            textBoxOutput.AppendText($"Color index changed: {index}\r\n");

            textBoxOutput.AppendText($"hsv {hsvVectorToReplace}\r\nrgb {hsvVectorToReplace.HSVToRGB()}\r\n");

            pictureBoxColorPreview.BackColor = colorToReplace;

            textBoxOutput.AppendText($"color {colorToReplace}\r\n");

            var clampedHsvVectorToReplace = hsvVectorToReplace.ClampHSV();
            numericUpDownHue.Value = (decimal)clampedHsvVectorToReplace.X;
            numericUpDownSaturation.Value = (decimal)clampedHsvVectorToReplace.Y;
            numericUpDownValue.Value = (decimal)clampedHsvVectorToReplace.Z;

            textBoxOutput.AppendText($"back color {pictureBoxColorPreview.BackColor}\r\n");
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text))
                return;

            ReplaceColor();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            textBoxOutput.AppendText("\n\r-----------------------------------------\r\n");
            textBoxOutput.AppendText("Saving file...\r\n");
            //Backup file
            File.WriteAllText(filepath.Replace(fileExtension, fileExtensionBackup), originalText);
            textBoxOutput.AppendText("Backup created\r\n");

            //Write new file
            File.WriteAllText(filepath, text);
            textBoxOutput.AppendText("Changes saved\r\n");

            //Delete sbcPB file
            var precompiledSbcPath = filepath + "PB";
            if (File.Exists(precompiledSbcPath))
            {
                File.Delete(precompiledSbcPath);
                textBoxOutput.AppendText("bp.sbcPB deleted\r\n");
            }
        }

        private void buttonUpdateHSV_Click(object sender, EventArgs e)
        {
            UpdateColorPreviewsHSV();
        }

        void UpdateColorPreviewsHSV()
        {
            textBoxOutput.AppendText("\n\r-----------------------------------------\r\n");
            textBoxOutput.AppendText("Updating HSV\r\n");

            var hue = (float)numericUpDownHue.Value;
            var saturation = (float)numericUpDownSaturation.Value;
            var value = (float)numericUpDownValue.Value;
            var hsv = new ColorVector(hue, saturation, value);
            var rgb = hsv.HSVToRGB();
            var color = rgb.RGBToColor();

            pictureBoxColorPreview.BackColor = color;
            replacementColor = color;
        }

        private void numericUpDownHue_ValueChanged(object sender, EventArgs e)
        {
            UpdateColorPreviewsHSV();
        }

        private void numericUpDownSaturation_ValueChanged(object sender, EventArgs e)
        {
            UpdateColorPreviewsHSV();
        }

        private void numericUpDownValue_ValueChanged(object sender, EventArgs e)
        {
            UpdateColorPreviewsHSV();
        }

        private void checkBoxShowRGB_CheckedChanged(object sender, EventArgs e)
        {
            textBoxOutput.AppendText("\n\r-----------------------------------------\r\n");
            textBoxOutput.AppendText("RGB checkbox changed\r\n");
            WriteColorsToListBox();
        }

        private void pictureBoxColorPreview_Click(object sender, EventArgs e)
        {
            ShowColorPicker();
        }

        List<int> customColorList = new List<int>();

        private void buttonAddColor_Click(object sender, EventArgs e)
        {
            var customColors = colorDialog1.CustomColors;
            var newCustomColors = new List<int>(customColors);
            textBoxOutput.AppendText($"Custom colors: {customColors.Length}\r\n");

            newCustomColors.RemoveAll(x => x == 16777215);
            textBoxOutput.AppendText($"New custom colors: {newCustomColors.Count}\r\n");

            foreach (var color in newCustomColors)
            {
                if (!customColorList.Contains(color))
                    customColorList.Add(color);
            }

            var colorToAdd = pictureBoxColorPreview.BackColor;
            int colorInt = colorToAdd.B << 16 | colorToAdd.G << 8 | colorToAdd.R;

            if (!customColorList.Contains(colorInt))
                customColorList.Add(colorInt);

            textBoxOutput.AppendText("Color added to picker\r\n");
            textBoxOutput.AppendText($"RGB {colorToAdd.R}, {colorToAdd.G}, {colorToAdd.B}\r\n");
            textBoxOutput.AppendText($"ARGB {colorToAdd.ToArgb()}\r\n");
            textBoxOutput.AppendText($"Int {colorInt}\r\n");

            customColors = customColorList.ToArray();
            colorDialog1.CustomColors = customColors;
        }

        private void checkBoxVisualUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVisualUpdate.Checked)
            {
                OffsetColorsUp();
            }
            else
            {
                OffsetColorsDown();
            }
            WriteColorsToListBox();
            UpdateColorPreviewsHSV();
        }

        ColorVector OffsetColorDisplay(ColorVector color)
        {
           return new ColorVector(color.X, color.Y, color.Z + 45f);
        }

        void CreateColorOffsets()
        {
            textBoxOutput.AppendText("\r\n-----------------------------------------\r\n");
            textBoxOutput.AppendText("Creating color offset\r\n");
            List<KeyValuePair<string, ColorVector>> kvpList = uniqueColors.ToList();
            offsetText = text;
            foreach (var kvp in kvpList)
            {
                var color = kvp.Value;
                color = new ColorVector(color.X, color.Y, color.Z + 25f);
                offsetText = offsetText.Replace(kvp.Key, color.ClampHSV().Round().HSVToColorMask().ToMaskString());
                textBoxOutput.AppendText($"Old: {kvp.Key}\r\nNew: { color.ClampHSV().HSVToColorMask().ToMaskString()}\r\n");
            }
        }

        void OffsetColorsUp()
        {
            textBoxOutput.AppendText("\n\r-----------------------------------------\r\n");
            textBoxOutput.AppendText("\n\rCOLORS OFFSET UP\n\r");

            notOffsetText = text;
            text = offsetText;

            GetUniqueColors(text, maskPattern);
            WriteColorsToListBox();
        }

        void OffsetColorsDown()
        {
            textBoxOutput.AppendText("\n\r-----------------------------------------\r\n");
            textBoxOutput.AppendText("\n\rCOLORS OFFSET DOWN\n\r");

            offsetText = text;
            text = notOffsetText;

            GetUniqueColors(text, maskPattern);
            WriteColorsToListBox();
        }
    }
}
