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
            this.backgroundWorkerUpdate = new System.ComponentModel.BackgroundWorker();
            this.checkBoxVisualUpdate = new System.Windows.Forms.CheckBox();
            this.pictureBoxNewColorPreview = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxMisc = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxRepair = new System.Windows.Forms.CheckBox();
            this.checkBoxBuild = new System.Windows.Forms.CheckBox();
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
            this.textBoxFilePath.Location = new System.Drawing.Point(30, 41);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(459, 22);
            this.textBoxFilePath.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowse.Location = new System.Drawing.Point(506, 35);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 34);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.toolTip1.SetToolTip(this.buttonBrowse, "Browse for blueprint file");
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // listBoxColors
            // 
            this.listBoxColors.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxColors.FormattingEnabled = true;
            this.listBoxColors.ItemHeight = 16;
            this.listBoxColors.Location = new System.Drawing.Point(12, 21);
            this.listBoxColors.Name = "listBoxColors";
            this.listBoxColors.ScrollAlwaysVisible = true;
            this.listBoxColors.Size = new System.Drawing.Size(220, 164);
            this.listBoxColors.TabIndex = 3;
            this.listBoxColors.SelectedIndexChanged += new System.EventHandler(this.listBoxColors_SelectedIndexChanged);
            // 
            // pictureBoxOldColorPreview
            // 
            this.pictureBoxOldColorPreview.BackColor = System.Drawing.Color.Black;
            this.pictureBoxOldColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxOldColorPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxOldColorPreview.Enabled = false;
            this.pictureBoxOldColorPreview.Location = new System.Drawing.Point(287, 107);
            this.pictureBoxOldColorPreview.Name = "pictureBoxOldColorPreview";
            this.pictureBoxOldColorPreview.Size = new System.Drawing.Size(106, 104);
            this.pictureBoxOldColorPreview.TabIndex = 4;
            this.pictureBoxOldColorPreview.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Old Color";
            // 
            // buttonPickColor
            // 
            this.buttonPickColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPickColor.Enabled = false;
            this.buttonPickColor.Location = new System.Drawing.Point(287, 238);
            this.buttonPickColor.Name = "buttonPickColor";
            this.buttonPickColor.Size = new System.Drawing.Size(102, 52);
            this.buttonPickColor.TabIndex = 8;
            this.buttonPickColor.Text = "RGB Color Picker";
            this.toolTip1.SetToolTip(this.buttonPickColor, "Open RGB color picker");
            this.buttonPickColor.UseVisualStyleBackColor = true;
            this.buttonPickColor.Click += new System.EventHandler(this.buttonPickColor_Click);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReplace.Enabled = false;
            this.buttonReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReplace.Location = new System.Drawing.Point(287, 351);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(102, 47);
            this.buttonReplace.TabIndex = 9;
            this.buttonReplace.Text = "Replace Old Color";
            this.toolTip1.SetToolTip(this.buttonReplace, "Replace currently selected ship color with the color preview");
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxOutput.Location = new System.Drawing.Point(24, 505);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(567, 129);
            this.textBoxOutput.TabIndex = 10;
            this.textBoxOutput.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Debug Console";
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(329, 422);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(203, 59);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save Changes";
            this.toolTip1.SetToolTip(this.buttonSave, "Save changes to blueprint file");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUpdateHSV
            // 
            this.buttonUpdateHSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateHSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateHSV.Location = new System.Drawing.Point(87, 109);
            this.buttonUpdateHSV.Name = "buttonUpdateHSV";
            this.buttonUpdateHSV.Size = new System.Drawing.Size(91, 44);
            this.buttonUpdateHSV.TabIndex = 14;
            this.buttonUpdateHSV.Text = "Update HSV";
            this.toolTip1.SetToolTip(this.buttonUpdateHSV, "Manually update HSV values");
            this.buttonUpdateHSV.UseVisualStyleBackColor = true;
            this.buttonUpdateHSV.Click += new System.EventHandler(this.buttonUpdateHSV_Click);
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownValue.Location = new System.Drawing.Point(87, 81);
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(91, 22);
            this.numericUpDownValue.TabIndex = 18;
            this.numericUpDownValue.ValueChanged += new System.EventHandler(this.numericUpDownValue_ValueChanged);
            // 
            // numericUpDownSaturation
            // 
            this.numericUpDownSaturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSaturation.Location = new System.Drawing.Point(87, 51);
            this.numericUpDownSaturation.Name = "numericUpDownSaturation";
            this.numericUpDownSaturation.Size = new System.Drawing.Size(91, 22);
            this.numericUpDownSaturation.TabIndex = 17;
            this.numericUpDownSaturation.ValueChanged += new System.EventHandler(this.numericUpDownSaturation_ValueChanged);
            // 
            // numericUpDownHue
            // 
            this.numericUpDownHue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownHue.Location = new System.Drawing.Point(87, 23);
            this.numericUpDownHue.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownHue.Name = "numericUpDownHue";
            this.numericUpDownHue.Size = new System.Drawing.Size(91, 22);
            this.numericUpDownHue.TabIndex = 16;
            this.numericUpDownHue.ValueChanged += new System.EventHandler(this.numericUpDownHue_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Saturation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Hue:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Value:";
            // 
            // groupBoxHSV
            // 
            this.groupBoxHSV.Controls.Add(this.numericUpDownHue);
            this.groupBoxHSV.Controls.Add(this.label5);
            this.groupBoxHSV.Controls.Add(this.label7);
            this.groupBoxHSV.Controls.Add(this.label6);
            this.groupBoxHSV.Controls.Add(this.buttonUpdateHSV);
            this.groupBoxHSV.Controls.Add(this.numericUpDownValue);
            this.groupBoxHSV.Controls.Add(this.numericUpDownSaturation);
            this.groupBoxHSV.Enabled = false;
            this.groupBoxHSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHSV.Location = new System.Drawing.Point(399, 231);
            this.groupBoxHSV.Name = "groupBoxHSV";
            this.groupBoxHSV.Size = new System.Drawing.Size(190, 167);
            this.groupBoxHSV.TabIndex = 23;
            this.groupBoxHSV.TabStop = false;
            this.groupBoxHSV.Text = "HSV Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Blueprint Filepath";
            // 
            // checkBoxShowRGB
            // 
            this.checkBoxShowRGB.AutoSize = true;
            this.checkBoxShowRGB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowRGB.Enabled = false;
            this.checkBoxShowRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowRGB.Location = new System.Drawing.Point(12, 191);
            this.checkBoxShowRGB.Name = "checkBoxShowRGB";
            this.checkBoxShowRGB.Size = new System.Drawing.Size(145, 21);
            this.checkBoxShowRGB.TabIndex = 25;
            this.checkBoxShowRGB.Text = "Show RGB Values";
            this.toolTip1.SetToolTip(this.checkBoxShowRGB, "Switch between HSV and RGB display");
            this.checkBoxShowRGB.UseVisualStyleBackColor = true;
            this.checkBoxShowRGB.CheckedChanged += new System.EventHandler(this.checkBoxShowRGB_CheckedChanged);
            // 
            // buttonAddColor
            // 
            this.buttonAddColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddColor.Enabled = false;
            this.buttonAddColor.Location = new System.Drawing.Point(287, 296);
            this.buttonAddColor.Name = "buttonAddColor";
            this.buttonAddColor.Size = new System.Drawing.Size(102, 49);
            this.buttonAddColor.TabIndex = 26;
            this.buttonAddColor.Text = "Add to \r\nColor Picker";
            this.toolTip1.SetToolTip(this.buttonAddColor, "Add current color preview to the RGB color picker");
            this.buttonAddColor.UseVisualStyleBackColor = true;
            this.buttonAddColor.Click += new System.EventHandler(this.buttonAddColor_Click);
            // 
            // backgroundWorkerUpdate
            // 
            this.backgroundWorkerUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerUpdate_DoWork);
            this.backgroundWorkerUpdate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerUpdate_RunWorkerCompleted);
            // 
            // checkBoxVisualUpdate
            // 
            this.checkBoxVisualUpdate.AutoSize = true;
            this.checkBoxVisualUpdate.Enabled = false;
            this.checkBoxVisualUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVisualUpdate.Location = new System.Drawing.Point(11, 218);
            this.checkBoxVisualUpdate.Name = "checkBoxVisualUpdate";
            this.checkBoxVisualUpdate.Size = new System.Drawing.Size(221, 21);
            this.checkBoxVisualUpdate.TabIndex = 27;
            this.checkBoxVisualUpdate.Text = "Offset for Visual Update 1.186";
            this.toolTip1.SetToolTip(this.checkBoxVisualUpdate, "This modifies all colors to appear in-game the same as they did before SE Update " +
        "1.186");
            this.checkBoxVisualUpdate.UseVisualStyleBackColor = true;
            this.checkBoxVisualUpdate.CheckedChanged += new System.EventHandler(this.checkBoxVisualUpdate_CheckedChanged);
            // 
            // pictureBoxNewColorPreview
            // 
            this.pictureBoxNewColorPreview.BackColor = System.Drawing.Color.Black;
            this.pictureBoxNewColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxNewColorPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNewColorPreview.Enabled = false;
            this.pictureBoxNewColorPreview.Location = new System.Drawing.Point(486, 107);
            this.pictureBoxNewColorPreview.Name = "pictureBoxNewColorPreview";
            this.pictureBoxNewColorPreview.Size = new System.Drawing.Size(106, 104);
            this.pictureBoxNewColorPreview.TabIndex = 28;
            this.pictureBoxNewColorPreview.TabStop = false;
            this.pictureBoxNewColorPreview.Click += new System.EventHandler(this.pictureBoxColorPreview_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(483, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "New Color";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(399, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 69);
            this.label9.TabIndex = 30;
            this.label9.Text = "⬅";
            // 
            // groupBoxMisc
            // 
            this.groupBoxMisc.Controls.Add(this.checkBoxRepair);
            this.groupBoxMisc.Controls.Add(this.checkBoxBuild);
            this.groupBoxMisc.Enabled = false;
            this.groupBoxMisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMisc.Location = new System.Drawing.Point(26, 340);
            this.groupBoxMisc.Name = "groupBoxMisc";
            this.groupBoxMisc.Size = new System.Drawing.Size(241, 79);
            this.groupBoxMisc.TabIndex = 33;
            this.groupBoxMisc.TabStop = false;
            this.groupBoxMisc.Text = "Misc. Functions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxVisualUpdate);
            this.groupBox2.Controls.Add(this.checkBoxShowRGB);
            this.groupBox2.Controls.Add(this.listBoxColors);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 247);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ship Colors";
            // 
            // checkBoxRepair
            // 
            this.checkBoxRepair.AutoSize = true;
            this.checkBoxRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRepair.Location = new System.Drawing.Point(12, 21);
            this.checkBoxRepair.Name = "checkBoxRepair";
            this.checkBoxRepair.Size = new System.Drawing.Size(136, 21);
            this.checkBoxRepair.TabIndex = 35;
            this.checkBoxRepair.Text = "Repair All Blocks";
            this.checkBoxRepair.UseVisualStyleBackColor = true;
            // 
            // checkBoxBuild
            // 
            this.checkBoxBuild.AutoSize = true;
            this.checkBoxBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBuild.Location = new System.Drawing.Point(12, 48);
            this.checkBoxBuild.Name = "checkBoxBuild";
            this.checkBoxBuild.Size = new System.Drawing.Size(125, 21);
            this.checkBoxBuild.TabIndex = 36;
            this.checkBoxBuild.Text = "Build All Blocks";
            this.checkBoxBuild.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 654);
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

