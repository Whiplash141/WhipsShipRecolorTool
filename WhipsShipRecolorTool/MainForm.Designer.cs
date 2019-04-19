using System;

namespace WhipsShipRecolorTool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.listBoxColors = new System.Windows.Forms.ListBox();
            this.pictureBoxOldColorPreview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPickColor = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdateHSV = new System.Windows.Forms.Button();
            this.numericUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSaturation = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHue = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxHSV = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxShowRGB = new System.Windows.Forms.CheckBox();
            this.buttonAddColor = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxVisualUpdate = new System.Windows.Forms.CheckBox();
            this.backgroundWorkerUpdate = new System.ComponentModel.BackgroundWorker();
            this.pictureBoxNewColorPreview = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxMisc = new System.Windows.Forms.GroupBox();
            this.checkBoxRepair = new System.Windows.Forms.CheckBox();
            this.checkBoxBuild = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOldColorPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHue)).BeginInit();
            this.groupBoxHSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewColorPreview)).BeginInit();
            this.groupBoxMisc.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.BackColor = System.Drawing.Color.Black;
            this.textBoxFilePath.ForeColor = System.Drawing.Color.White;
            this.textBoxFilePath.Location = new System.Drawing.Point(22, 33);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(345, 20);
            this.textBoxFilePath.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.ForeColor = System.Drawing.Color.White;
            this.buttonBrowse.Location = new System.Drawing.Point(380, 28);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(56, 28);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.toolTip1.SetToolTip(this.buttonBrowse, "Browse for blueprint file");
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // listBoxColors
            // 
            this.listBoxColors.BackColor = System.Drawing.Color.Black;
            this.listBoxColors.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxColors.ForeColor = System.Drawing.Color.White;
            this.listBoxColors.FormattingEnabled = true;
            this.listBoxColors.ItemHeight = 15;
            this.listBoxColors.Location = new System.Drawing.Point(4, 17);
            this.listBoxColors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxColors.Name = "listBoxColors";
            this.listBoxColors.ScrollAlwaysVisible = true;
            this.listBoxColors.Size = new System.Drawing.Size(170, 124);
            this.listBoxColors.TabIndex = 3;
            this.listBoxColors.SelectedIndexChanged += new System.EventHandler(this.listBoxColors_SelectedIndexChanged);
            // 
            // pictureBoxOldColorPreview
            // 
            this.pictureBoxOldColorPreview.BackColor = System.Drawing.Color.Black;
            this.pictureBoxOldColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOldColorPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxOldColorPreview.Enabled = false;
            this.pictureBoxOldColorPreview.Location = new System.Drawing.Point(215, 87);
            this.pictureBoxOldColorPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxOldColorPreview.Name = "pictureBoxOldColorPreview";
            this.pictureBoxOldColorPreview.Size = new System.Drawing.Size(80, 85);
            this.pictureBoxOldColorPreview.TabIndex = 4;
            this.pictureBoxOldColorPreview.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(213, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Old Color";
            // 
            // buttonPickColor
            // 
            this.buttonPickColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonPickColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPickColor.Enabled = false;
            this.buttonPickColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPickColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPickColor.ForeColor = System.Drawing.Color.White;
            this.buttonPickColor.Location = new System.Drawing.Point(215, 193);
            this.buttonPickColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPickColor.Name = "buttonPickColor";
            this.buttonPickColor.Size = new System.Drawing.Size(76, 42);
            this.buttonPickColor.TabIndex = 8;
            this.buttonPickColor.Text = "RGB Color Picker";
            this.toolTip1.SetToolTip(this.buttonPickColor, "Open RGB color picker");
            this.buttonPickColor.UseVisualStyleBackColor = false;
            this.buttonPickColor.Click += new System.EventHandler(this.buttonPickColor_Click);
            // 
            // buttonReplace
            // 
            this.buttonReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonReplace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReplace.Enabled = false;
            this.buttonReplace.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReplace.ForeColor = System.Drawing.Color.White;
            this.buttonReplace.Location = new System.Drawing.Point(215, 285);
            this.buttonReplace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(76, 38);
            this.buttonReplace.TabIndex = 9;
            this.buttonReplace.Text = "Replace Old Color";
            this.toolTip1.SetToolTip(this.buttonReplace, "Replace currently selected ship color with the color preview");
            this.buttonReplace.UseVisualStyleBackColor = false;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BackColor = System.Drawing.Color.Black;
            this.textBoxOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxOutput.ForeColor = System.Drawing.Color.White;
            this.textBoxOutput.Location = new System.Drawing.Point(18, 410);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(426, 106);
            this.textBoxOutput.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 388);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Debug Console";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Enabled = false;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(247, 343);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(152, 48);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save Changes";
            this.toolTip1.SetToolTip(this.buttonSave, "Save changes to blueprint file");
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUpdateHSV
            // 
            this.buttonUpdateHSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonUpdateHSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateHSV.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUpdateHSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateHSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateHSV.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateHSV.Location = new System.Drawing.Point(65, 89);
            this.buttonUpdateHSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdateHSV.Name = "buttonUpdateHSV";
            this.buttonUpdateHSV.Size = new System.Drawing.Size(68, 36);
            this.buttonUpdateHSV.TabIndex = 14;
            this.buttonUpdateHSV.Text = "Update HSV";
            this.toolTip1.SetToolTip(this.buttonUpdateHSV, "Manually update HSV values");
            this.buttonUpdateHSV.UseVisualStyleBackColor = false;
            this.buttonUpdateHSV.Click += new System.EventHandler(this.buttonUpdateHSV_Click);
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.BackColor = System.Drawing.Color.Black;
            this.numericUpDownValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownValue.ForeColor = System.Drawing.Color.White;
            this.numericUpDownValue.Location = new System.Drawing.Point(65, 66);
            this.numericUpDownValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(68, 19);
            this.numericUpDownValue.TabIndex = 18;
            this.numericUpDownValue.ValueChanged += new System.EventHandler(this.numericUpDownValue_ValueChanged);
            // 
            // numericUpDownSaturation
            // 
            this.numericUpDownSaturation.BackColor = System.Drawing.Color.Black;
            this.numericUpDownSaturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSaturation.ForeColor = System.Drawing.Color.White;
            this.numericUpDownSaturation.Location = new System.Drawing.Point(65, 41);
            this.numericUpDownSaturation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownSaturation.Name = "numericUpDownSaturation";
            this.numericUpDownSaturation.Size = new System.Drawing.Size(68, 19);
            this.numericUpDownSaturation.TabIndex = 17;
            this.numericUpDownSaturation.ValueChanged += new System.EventHandler(this.numericUpDownSaturation_ValueChanged);
            // 
            // numericUpDownHue
            // 
            this.numericUpDownHue.BackColor = System.Drawing.Color.Black;
            this.numericUpDownHue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownHue.ForeColor = System.Drawing.Color.White;
            this.numericUpDownHue.Location = new System.Drawing.Point(65, 19);
            this.numericUpDownHue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownHue.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownHue.Name = "numericUpDownHue";
            this.numericUpDownHue.Size = new System.Drawing.Size(68, 19);
            this.numericUpDownHue.TabIndex = 16;
            this.numericUpDownHue.ValueChanged += new System.EventHandler(this.numericUpDownHue_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Saturation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Hue:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Value:";
            // 
            // groupBoxHSV
            // 
            this.groupBoxHSV.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxHSV.Controls.Add(this.numericUpDownHue);
            this.groupBoxHSV.Controls.Add(this.label5);
            this.groupBoxHSV.Controls.Add(this.label7);
            this.groupBoxHSV.Controls.Add(this.label6);
            this.groupBoxHSV.Controls.Add(this.buttonUpdateHSV);
            this.groupBoxHSV.Controls.Add(this.numericUpDownValue);
            this.groupBoxHSV.Controls.Add(this.numericUpDownSaturation);
            this.groupBoxHSV.Enabled = false;
            this.groupBoxHSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHSV.ForeColor = System.Drawing.Color.White;
            this.groupBoxHSV.Location = new System.Drawing.Point(299, 188);
            this.groupBoxHSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxHSV.Name = "groupBoxHSV";
            this.groupBoxHSV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxHSV.Size = new System.Drawing.Size(142, 136);
            this.groupBoxHSV.TabIndex = 23;
            this.groupBoxHSV.TabStop = false;
            this.groupBoxHSV.Text = "HSV Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Blueprint Filepath";
            // 
            // checkBoxShowRGB
            // 
            this.checkBoxShowRGB.AutoSize = true;
            this.checkBoxShowRGB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowRGB.Enabled = false;
            this.checkBoxShowRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowRGB.Location = new System.Drawing.Point(7, 147);
            this.checkBoxShowRGB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxShowRGB.Name = "checkBoxShowRGB";
            this.checkBoxShowRGB.Size = new System.Drawing.Size(114, 17);
            this.checkBoxShowRGB.TabIndex = 25;
            this.checkBoxShowRGB.Text = "Show RGB Values";
            this.toolTip1.SetToolTip(this.checkBoxShowRGB, "Switch between HSV and RGB display");
            this.checkBoxShowRGB.UseVisualStyleBackColor = true;
            this.checkBoxShowRGB.CheckedChanged += new System.EventHandler(this.checkBoxShowRGB_CheckedChanged);
            // 
            // buttonAddColor
            // 
            this.buttonAddColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonAddColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddColor.Enabled = false;
            this.buttonAddColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAddColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddColor.ForeColor = System.Drawing.Color.White;
            this.buttonAddColor.Location = new System.Drawing.Point(215, 240);
            this.buttonAddColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddColor.Name = "buttonAddColor";
            this.buttonAddColor.Size = new System.Drawing.Size(76, 40);
            this.buttonAddColor.TabIndex = 26;
            this.buttonAddColor.Text = "Add to \r\nColor Picker";
            this.toolTip1.SetToolTip(this.buttonAddColor, "Add current color preview to the RGB color picker");
            this.buttonAddColor.UseVisualStyleBackColor = false;
            this.buttonAddColor.Click += new System.EventHandler(this.buttonAddColor_Click);
            // 
            // checkBoxVisualUpdate
            // 
            this.checkBoxVisualUpdate.AutoSize = true;
            this.checkBoxVisualUpdate.Enabled = false;
            this.checkBoxVisualUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVisualUpdate.Location = new System.Drawing.Point(7, 169);
            this.checkBoxVisualUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxVisualUpdate.Name = "checkBoxVisualUpdate";
            this.checkBoxVisualUpdate.Size = new System.Drawing.Size(168, 17);
            this.checkBoxVisualUpdate.TabIndex = 27;
            this.checkBoxVisualUpdate.Text = "Offset for Visual Update 1.186";
            this.toolTip1.SetToolTip(this.checkBoxVisualUpdate, "This modifies all colors to appear in-game the same as they did before SE Update " +
        "1.186");
            this.checkBoxVisualUpdate.UseVisualStyleBackColor = true;
            this.checkBoxVisualUpdate.CheckedChanged += new System.EventHandler(this.checkBoxVisualUpdate_CheckedChanged);
            // 
            // backgroundWorkerUpdate
            // 
            this.backgroundWorkerUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerUpdate_DoWork);
            this.backgroundWorkerUpdate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerUpdate_RunWorkerCompleted);
            // 
            // pictureBoxNewColorPreview
            // 
            this.pictureBoxNewColorPreview.BackColor = System.Drawing.Color.Black;
            this.pictureBoxNewColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxNewColorPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNewColorPreview.Enabled = false;
            this.pictureBoxNewColorPreview.Location = new System.Drawing.Point(364, 87);
            this.pictureBoxNewColorPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxNewColorPreview.Name = "pictureBoxNewColorPreview";
            this.pictureBoxNewColorPreview.Size = new System.Drawing.Size(80, 85);
            this.pictureBoxNewColorPreview.TabIndex = 28;
            this.pictureBoxNewColorPreview.TabStop = false;
            this.pictureBoxNewColorPreview.Click += new System.EventHandler(this.pictureBoxColorPreview_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(362, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "New Color";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(299, 93);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 55);
            this.label9.TabIndex = 30;
            this.label9.Text = "⬅";
            // 
            // groupBoxMisc
            // 
            this.groupBoxMisc.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMisc.Controls.Add(this.checkBoxRepair);
            this.groupBoxMisc.Controls.Add(this.checkBoxBuild);
            this.groupBoxMisc.Enabled = false;
            this.groupBoxMisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMisc.ForeColor = System.Drawing.Color.White;
            this.groupBoxMisc.Location = new System.Drawing.Point(18, 276);
            this.groupBoxMisc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxMisc.Name = "groupBoxMisc";
            this.groupBoxMisc.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxMisc.Size = new System.Drawing.Size(183, 64);
            this.groupBoxMisc.TabIndex = 33;
            this.groupBoxMisc.TabStop = false;
            this.groupBoxMisc.Text = "Misc. Functions";
            // 
            // checkBoxRepair
            // 
            this.checkBoxRepair.AutoSize = true;
            this.checkBoxRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRepair.Location = new System.Drawing.Point(7, 17);
            this.checkBoxRepair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxRepair.Name = "checkBoxRepair";
            this.checkBoxRepair.Size = new System.Drawing.Size(106, 17);
            this.checkBoxRepair.TabIndex = 35;
            this.checkBoxRepair.Text = "Repair All Blocks";
            this.checkBoxRepair.UseVisualStyleBackColor = true;
            // 
            // checkBoxBuild
            // 
            this.checkBoxBuild.AutoSize = true;
            this.checkBoxBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBuild.Location = new System.Drawing.Point(7, 39);
            this.checkBoxBuild.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxBuild.Name = "checkBoxBuild";
            this.checkBoxBuild.Size = new System.Drawing.Size(98, 17);
            this.checkBoxBuild.TabIndex = 36;
            this.checkBoxBuild.Text = "Build All Blocks";
            this.checkBoxBuild.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.checkBoxVisualUpdate);
            this.groupBox2.Controls.Add(this.checkBoxShowRGB);
            this.groupBox2.Controls.Add(this.listBoxColors);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(182, 197);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ship Colors";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(465, 531);
            this.Controls.Add(this.groupBoxMisc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBoxNewColorPreview);
            this.Controls.Add(this.buttonAddColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.buttonPickColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxOldColorPreview);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.groupBoxHSV);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Whip\'s Ship Recolor Tool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOldColorPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHue)).EndInit();
            this.groupBoxHSV.ResumeLayout(false);
            this.groupBoxHSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewColorPreview)).EndInit();
            this.groupBoxMisc.ResumeLayout(false);
            this.groupBoxMisc.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.ListBox listBoxColors;
        private System.Windows.Forms.PictureBox pictureBoxOldColorPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPickColor;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdateHSV;
        private System.Windows.Forms.NumericUpDown numericUpDownValue;
        private System.Windows.Forms.NumericUpDown numericUpDownSaturation;
        private System.Windows.Forms.NumericUpDown numericUpDownHue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxHSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxShowRGB;
        private System.Windows.Forms.Button buttonAddColor;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerUpdate;
        private System.Windows.Forms.CheckBox checkBoxVisualUpdate;
        private System.Windows.Forms.PictureBox pictureBoxNewColorPreview;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxMisc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxRepair;
        private System.Windows.Forms.CheckBox checkBoxBuild;
    }
}

