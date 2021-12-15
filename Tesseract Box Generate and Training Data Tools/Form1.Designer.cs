namespace Tesseract_Box_Generate_and_Training_Data_Tools
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Box_TifPath_Textbox = new System.Windows.Forms.TextBox();
            this.Browsetif_but = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BrowseOutput_but = new System.Windows.Forms.Button();
            this.Psm_Combox = new System.Windows.Forms.ComboBox();
            this.OutputPath_Textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fontname_Textbox = new System.Windows.Forms.TextBox();
            this.GenBox_But = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Train_psm_Combox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Train_Fontname_Textbox = new System.Windows.Forms.TextBox();
            this.Train_But = new System.Windows.Forms.Button();
            this.Train_TifPath_Textbox = new System.Windows.Forms.TextBox();
            this.Train_BrowseBox_but = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TessEXE_Textbox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Log_Textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Box_TifPath_Textbox
            // 
            this.Box_TifPath_Textbox.Location = new System.Drawing.Point(97, 22);
            this.Box_TifPath_Textbox.Name = "Box_TifPath_Textbox";
            this.Box_TifPath_Textbox.ReadOnly = true;
            this.Box_TifPath_Textbox.Size = new System.Drawing.Size(241, 20);
            this.Box_TifPath_Textbox.TabIndex = 0;
            // 
            // Browsetif_but
            // 
            this.Browsetif_but.Location = new System.Drawing.Point(344, 17);
            this.Browsetif_but.Name = "Browsetif_but";
            this.Browsetif_but.Size = new System.Drawing.Size(85, 28);
            this.Browsetif_but.TabIndex = 1;
            this.Browsetif_but.Text = "Browse .tif ";
            this.Browsetif_but.UseVisualStyleBackColor = true;
            this.Browsetif_but.Click += new System.EventHandler(this.Browsetif_but_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BrowseOutput_but);
            this.groupBox1.Controls.Add(this.Psm_Combox);
            this.groupBox1.Controls.Add(this.OutputPath_Textbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fontname_Textbox);
            this.groupBox1.Controls.Add(this.GenBox_But);
            this.groupBox1.Controls.Add(this.Box_TifPath_Textbox);
            this.groupBox1.Controls.Add(this.Browsetif_but);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 181);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Bounding Box";
            // 
            // BrowseOutput_but
            // 
            this.BrowseOutput_but.Location = new System.Drawing.Point(346, 49);
            this.BrowseOutput_but.Name = "BrowseOutput_but";
            this.BrowseOutput_but.Size = new System.Drawing.Size(34, 22);
            this.BrowseOutput_but.TabIndex = 8;
            this.BrowseOutput_but.Text = "...";
            this.BrowseOutput_but.UseVisualStyleBackColor = true;
            this.BrowseOutput_but.Click += new System.EventHandler(this.BrowseOutput_but_Click);
            // 
            // Psm_Combox
            // 
            this.Psm_Combox.FormattingEnabled = true;
            this.Psm_Combox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.Psm_Combox.Location = new System.Drawing.Point(145, 112);
            this.Psm_Combox.Name = "Psm_Combox";
            this.Psm_Combox.Size = new System.Drawing.Size(56, 21);
            this.Psm_Combox.TabIndex = 6;
            // 
            // OutputPath_Textbox
            // 
            this.OutputPath_Textbox.Location = new System.Drawing.Point(99, 51);
            this.OutputPath_Textbox.Name = "OutputPath_Textbox";
            this.OutputPath_Textbox.ReadOnly = true;
            this.OutputPath_Textbox.Size = new System.Drawing.Size(241, 20);
            this.OutputPath_Textbox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Page Segmentation Mode:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Output Directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = ".tif Path: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Font name: ";
            // 
            // fontname_Textbox
            // 
            this.fontname_Textbox.Location = new System.Drawing.Point(75, 80);
            this.fontname_Textbox.MaxLength = 5;
            this.fontname_Textbox.Name = "fontname_Textbox";
            this.fontname_Textbox.Size = new System.Drawing.Size(64, 20);
            this.fontname_Textbox.TabIndex = 2;
            // 
            // GenBox_But
            // 
            this.GenBox_But.Location = new System.Drawing.Point(8, 142);
            this.GenBox_But.Name = "GenBox_But";
            this.GenBox_But.Size = new System.Drawing.Size(104, 28);
            this.GenBox_But.TabIndex = 2;
            this.GenBox_But.Text = "Gen Box";
            this.GenBox_But.UseVisualStyleBackColor = true;
            this.GenBox_But.Click += new System.EventHandler(this.GenBox_But_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Train_psm_Combox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Train_Fontname_Textbox);
            this.groupBox2.Controls.Add(this.Train_But);
            this.groupBox2.Controls.Add(this.Train_TifPath_Textbox);
            this.groupBox2.Controls.Add(this.Train_BrowseBox_but);
            this.groupBox2.Location = new System.Drawing.Point(12, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 159);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Train Tesseract";
            // 
            // Train_psm_Combox
            // 
            this.Train_psm_Combox.FormattingEnabled = true;
            this.Train_psm_Combox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.Train_psm_Combox.Location = new System.Drawing.Point(143, 88);
            this.Train_psm_Combox.Name = "Train_psm_Combox";
            this.Train_psm_Combox.Size = new System.Drawing.Size(56, 21);
            this.Train_psm_Combox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Page Segmentation Mode:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Font name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Box Path: ";
            // 
            // Train_Fontname_Textbox
            // 
            this.Train_Fontname_Textbox.Location = new System.Drawing.Point(75, 56);
            this.Train_Fontname_Textbox.MaxLength = 5;
            this.Train_Fontname_Textbox.Name = "Train_Fontname_Textbox";
            this.Train_Fontname_Textbox.ReadOnly = true;
            this.Train_Fontname_Textbox.Size = new System.Drawing.Size(64, 20);
            this.Train_Fontname_Textbox.TabIndex = 7;
            // 
            // Train_But
            // 
            this.Train_But.Location = new System.Drawing.Point(7, 121);
            this.Train_But.Name = "Train_But";
            this.Train_But.Size = new System.Drawing.Size(105, 28);
            this.Train_But.TabIndex = 2;
            this.Train_But.Text = "Train";
            this.Train_But.UseVisualStyleBackColor = true;
            this.Train_But.Click += new System.EventHandler(this.Train_But_Click);
            // 
            // Train_TifPath_Textbox
            // 
            this.Train_TifPath_Textbox.Location = new System.Drawing.Point(75, 23);
            this.Train_TifPath_Textbox.Name = "Train_TifPath_Textbox";
            this.Train_TifPath_Textbox.ReadOnly = true;
            this.Train_TifPath_Textbox.Size = new System.Drawing.Size(241, 20);
            this.Train_TifPath_Textbox.TabIndex = 0;
            // 
            // Train_BrowseBox_but
            // 
            this.Train_BrowseBox_but.Location = new System.Drawing.Point(322, 19);
            this.Train_BrowseBox_but.Name = "Train_BrowseBox_but";
            this.Train_BrowseBox_but.Size = new System.Drawing.Size(85, 26);
            this.Train_BrowseBox_but.TabIndex = 1;
            this.Train_BrowseBox_but.Text = "Browse .box";
            this.Train_BrowseBox_but.UseVisualStyleBackColor = true;
            this.Train_BrowseBox_but.Click += new System.EventHandler(this.Train_Browsetif_but_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.TessEXE_Textbox);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 60);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tesseract Executable";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tesseract Path;";
            // 
            // TessEXE_Textbox
            // 
            this.TessEXE_Textbox.Location = new System.Drawing.Point(102, 27);
            this.TessEXE_Textbox.Name = "TessEXE_Textbox";
            this.TessEXE_Textbox.ReadOnly = true;
            this.TessEXE_Textbox.Size = new System.Drawing.Size(241, 20);
            this.TessEXE_Textbox.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(349, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Log_Textbox
            // 
            this.Log_Textbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Log_Textbox.Location = new System.Drawing.Point(12, 443);
            this.Log_Textbox.Multiline = true;
            this.Log_Textbox.Name = "Log_Textbox";
            this.Log_Textbox.ReadOnly = true;
            this.Log_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log_Textbox.Size = new System.Drawing.Size(457, 137);
            this.Log_Textbox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Process Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 592);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Log_Textbox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tesseract Box Generate and Training Data Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Box_TifPath_Textbox;
        private System.Windows.Forms.Button Browsetif_but;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Train_But;
        private System.Windows.Forms.TextBox Train_TifPath_Textbox;
        private System.Windows.Forms.Button Train_BrowseBox_but;
        private System.Windows.Forms.Button GenBox_But;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TessEXE_Textbox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fontname_Textbox;
        private System.Windows.Forms.TextBox OutputPath_Textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BrowseOutput_but;
        private System.Windows.Forms.ComboBox Psm_Combox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Train_Fontname_Textbox;
        private System.Windows.Forms.ComboBox Train_psm_Combox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Log_Textbox;
        private System.Windows.Forms.Label label9;
    }
}

