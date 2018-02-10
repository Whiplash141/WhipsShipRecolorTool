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

namespace WhipsShipRecolorTool
{
    public partial class MainForm : Form
    {
        string filepath = "";
        const string fileExtension = ".sbc";
        const string fileName = "bp";
        const string fileNameBackup = "bp_backup";
        const string maskPattern = "<ColorMaskHSV( *?)x=\"-?[0-9]*.?[0-9]*?\"( *?)y=\"-?[0-9]*.?[0-9]*?\"( *?)z=\"-?[0-9]*.?[0-9]*?\"( *?)/>";
        Color replacementColor = Color.Black;

        Dictionary<string, ColorVector> uniqueColors = new Dictionary<string, ColorVector>();

        string originalText = "";
        string text = "";

        string maskToReplace = "";
        ColorVector hsvVectorToReplace = new ColorVector(0,0,0);

        public MainForm()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Blueprint Files (*.sbc) | *.sbc";
        }

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
                return $"<ColorMaskHSV x=\"{X}\" y=\"{Y}\" z=\"{Z}\" />";
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
                int red = (int)Math.Round(X);
                int green = (int)Math.Round(Y);
                int blue = (int)Math.Round(Z);
                return Color.FromArgb(red, green, blue);
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

            private static float ClampRGB(float num)
            {
                return num > 255f ? 255f : (num < 0f ? 0f : num);
            }

            private static float Clamp(float num, float min, float max)
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
                    return new ColorVector(0, 0, 0);

                mask = mask.Replace(" ", ""); //remove spaces

                var maskSplit = mask.Split('"');

                if (maskSplit.Length < 6)
                    return new ColorVector(0, 0, 0);

                float h = 0, s = 0, v = 0;
                if (!float.TryParse(maskSplit[1], out h) || !float.TryParse(maskSplit[3], out s) || !float.TryParse(maskSplit[5], out v))
                    return new ColorVector(0, 0, 0);

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
            //Load file
            originalText = File.ReadAllText(filepath);
            textBoxOutput.Text = "File loaded successfully!";

            text = originalText;

            groupBoxHSV.Enabled = true;
            buttonReplace.Enabled = true;
            buttonPickColor.Enabled = true;
            buttonAddColor.Enabled = true;
            buttonSave.Enabled = true;
            pictureBoxColorPreview.Enabled = true;

            GetUniqueColors(text, maskPattern);
            WriteColorsToListBox();
        }

        void GetUniqueColors(string text, string maskPattern)
        {
            var matches = Regex.Matches(text, maskPattern);
            int count = 0;
            uniqueColors.Clear();
            foreach (var match in matches)
            {
                count++;
                var matchString = match.ToString();
                uniqueColors[matchString] = ColorVector.HSVFromMaskString(matchString);
            }

            textBoxOutput.Text += ($"\r\n-----------------------------------------");
            textBoxOutput.Text += ($"\r\nRegex matches: {count}");
            textBoxOutput.Text += ($"\r\nUnique regex matches: {uniqueColors.Count}");
        }

        List<string> displayStrings = new List<string>();

        void WriteColorsToListBox()
        {
            displayStrings.Clear();

            foreach (var kvp in uniqueColors)
            {

                string thisOutput = "";
                if (checkBoxShowRGB.Checked)
                    thisOutput = $"RGB: {kvp.Value.HSVToRGB().Round()}";
                else
                    thisOutput = $"HSV: {kvp.Value.Round()}";

                displayStrings.Add(thisOutput);
            }

            listBoxColors.DataSource = null;
            listBoxColors.DataSource = displayStrings;
        }

        void ReplaceColor()
        {
            listBoxColors.ClearSelected();

            var rgb = ColorVector.FromColor(replacementColor);
            textBoxOutput.Text += $"\r\nRGB {rgb}";
            var hsv = rgb.RGBToHSV().Round();
            textBoxOutput.Text += $"\r\nHSV {hsv}";
            var hsvMask = hsv.HSVToColorMask().ToMaskString();
            textBoxOutput.Text += $"\r\nmask {hsvMask}";

            text = text.Replace(maskToReplace, hsvMask);

            GetUniqueColors(text, maskPattern);
            WriteColorsToListBox();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            filepath = openFileDialog1.FileName;
            textBoxFilePath.Text = filepath;

            LoadBlueprint();
        }

        void ShowColorPicker()
        {
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
            textBoxOutput.Text += $"\r\nExisting {newCustomColors.Count}";

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
            pictureBoxColorPreview.BackColor = colorToReplace;

            numericUpDownHue.Value = (decimal)hsvVectorToReplace.X;
            numericUpDownSaturation.Value = (decimal)hsvVectorToReplace.Y;
            numericUpDownValue.Value = (decimal)hsvVectorToReplace.Z;
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text))
                return;

            ReplaceColor();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Backup file
            File.WriteAllText(filepath.Replace(fileName, fileNameBackup), originalText);
            textBoxOutput.Text += "\r\nBackup created";

            //Write new file
            File.WriteAllText(filepath, text);
            textBoxOutput.Text += "\r\nChanges saved";

            //Delete sbcPB file
            var precompiledSbcPath = filepath + "PB";
            if (File.Exists(precompiledSbcPath))
            {
                File.Delete(precompiledSbcPath);
                textBoxOutput.Text += "\r\nbp.sbcPB deleted";
            }
        }

        private void buttonUpdateHSV_Click(object sender, EventArgs e)
        {
            UpdateColorPreviewsHSV();
        }

        void UpdateColorPreviewsHSV()
        {
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
            textBoxOutput.Text += $"\r\nExisting {customColors.Length}";

            textBoxOutput.Text += $"\r\nTest {newCustomColors[0]}";

            newCustomColors.RemoveAll(x => x == 16777215);
            textBoxOutput.Text += $"\r\nExisting {newCustomColors.Count}";

            foreach (var color in newCustomColors)
            {
                if (!customColorList.Contains(color))
                    customColorList.Add(color);
            }

            var colorToAdd = pictureBoxColorPreview.BackColor;
            int colorInt = colorToAdd.B << 16 | colorToAdd.G << 8 | colorToAdd.R;

            if (!customColorList.Contains(colorInt))
                customColorList.Add(colorInt);

            textBoxOutput.Text += $"\r\nRGB {colorToAdd.R}, {colorToAdd.G}, {colorToAdd.B}";
            textBoxOutput.Text += $"\r\nARGB {colorToAdd.ToArgb()}";
            textBoxOutput.Text += $"\r\nInt {colorInt}";

            customColors = customColorList.ToArray();
            colorDialog1.CustomColors = customColors;
            textBoxOutput.Text += "\r\nColor added to picker";
        }
    }
}
