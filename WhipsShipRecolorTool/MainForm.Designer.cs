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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.listBoxColors = new System.Windows.Forms.ListBox();
            this.pictureBoxColorPreview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPickColor = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHue)).BeginInit();
            this.groupBoxHSV.SuspendLayout();
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
            this.textBoxFilePath.Size = new System.Drawing.Size(527, 22);
            this.textBoxFilePath.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowse.Location = new System.Drawing.Point(579, 35);
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
            this.listBoxColors.FormattingEnabled = true;
            this.listBoxColors.ItemHeight = 16;
            this.listBoxColors.Location = new System.Drawing.Point(30, 106);
            this.listBoxColors.Name = "listBoxColors";
            this.listBoxColors.ScrollAlwaysVisible = true;
            this.listBoxColors.Size = new System.Drawing.Size(220, 164);
            this.listBoxColors.TabIndex = 3;
            this.listBoxColors.SelectedIndexChanged += new System.EventHandler(this.listBoxColors_SelectedIndexChanged);
            // 
            // pictureBoxColorPreview
            // 
            this.pictureBoxColorPreview.BackColor = System.Drawing.Color.Black;
            this.pictureBoxColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxColorPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxColorPreview.Enabled = false;
            this.pictureBoxColorPreview.Location = new System.Drawing.Point(256, 126);
            this.pictureBoxColorPreview.Name = "pictureBoxColorPreview";
            this.pictureBoxColorPreview.Size = new System.Drawing.Size(106, 104);
            this.pictureBoxColorPreview.TabIndex = 4;
            this.pictureBoxColorPreview.TabStop = false;
            this.pictureBoxColorPreview.Click += new System.EventHandler(this.pictureBoxColorPreview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Color Preview";
            // 
            // buttonPickColor
            // 
            this.buttonPickColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPickColor.Enabled = false;
            this.buttonPickColor.Location = new System.Drawing.Point(368, 123);
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
            this.buttonReplace.Location = new System.Drawing.Point(368, 236);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(102, 44);
            this.buttonReplace.TabIndex = 9;
            this.buttonReplace.Text = "Replace";
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
            this.textBoxOutput.Location = new System.Drawing.Point(30, 396);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(624, 73);
            this.textBoxOutput.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Debug Console";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ship Color List";
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(267, 298);
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
            this.groupBoxHSV.Location = new System.Drawing.Point(477, 106);
            this.groupBoxHSV.Name = "groupBoxHSV";
            this.groupBoxHSV.Size = new System.Drawing.Size(190, 161);
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
            this.checkBoxShowRGB.Location = new System.Drawing.Point(30, 276);
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
            this.buttonAddColor.Location = new System.Drawing.Point(368, 181);
            this.buttonAddColor.Name = "buttonAddColor";
            this.buttonAddColor.Size = new System.Drawing.Size(102, 49);
            this.buttonAddColor.TabIndex = 26;
            this.buttonAddColor.Text = "Add to \r\nColor Picker";
            this.toolTip1.SetToolTip(this.buttonAddColor, "Add current color preview to the RGB color picker");
            this.buttonAddColor.UseVisualStyleBackColor = true;
            this.buttonAddColor.Click += new System.EventHandler(this.buttonAddColor_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 481);
            this.Controls.Add(this.buttonAddColor);
            this.Controls.Add(this.checkBoxShowRGB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.buttonPickColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxColorPreview);
            this.Controls.Add(this.listBoxColors);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.groupBoxHSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Whip\'s Blueprint Recolor Tool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHue)).EndInit();
            this.groupBoxHSV.ResumeLayout(false);
            this.groupBoxHSV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.ListBox listBoxColors;
        private System.Windows.Forms.PictureBox pictureBoxColorPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPickColor;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
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
    }
}

