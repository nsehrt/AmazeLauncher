
namespace AmazeLauncher
{
    partial class AmazeLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmazeLauncher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.drawFPS = new System.Windows.Forms.ComboBox();
            this.sobelFilter = new System.Windows.Forms.ComboBox();
            this.anisotropicFilter = new System.Windows.Forms.ComboBox();
            this.shadowQuality = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.refreshRate = new System.Windows.Forms.ComboBox();
            this.vsync = new System.Windows.Forms.ComboBox();
            this.displayMode = new System.Windows.Forms.ComboBox();
            this.resolution = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.drawFPS);
            this.panel1.Controls.Add(this.sobelFilter);
            this.panel1.Controls.Add(this.anisotropicFilter);
            this.panel1.Controls.Add(this.shadowQuality);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.volume);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.refreshRate);
            this.panel1.Controls.Add(this.vsync);
            this.panel1.Controls.Add(this.displayMode);
            this.panel1.Controls.Add(this.resolution);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 409);
            this.panel1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(18, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(366, 2);
            this.label12.TabIndex = 20;
            // 
            // drawFPS
            // 
            this.drawFPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drawFPS.FormattingEnabled = true;
            this.drawFPS.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.drawFPS.Location = new System.Drawing.Point(157, 370);
            this.drawFPS.Name = "drawFPS";
            this.drawFPS.Size = new System.Drawing.Size(227, 21);
            this.drawFPS.TabIndex = 19;
            // 
            // sobelFilter
            // 
            this.sobelFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sobelFilter.FormattingEnabled = true;
            this.sobelFilter.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.sobelFilter.Location = new System.Drawing.Point(157, 315);
            this.sobelFilter.Name = "sobelFilter";
            this.sobelFilter.Size = new System.Drawing.Size(227, 21);
            this.sobelFilter.TabIndex = 18;
            // 
            // anisotropicFilter
            // 
            this.anisotropicFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anisotropicFilter.FormattingEnabled = true;
            this.anisotropicFilter.Items.AddRange(new object[] {
            "None",
            "4x",
            "8x",
            "16x"});
            this.anisotropicFilter.Location = new System.Drawing.Point(157, 278);
            this.anisotropicFilter.Name = "anisotropicFilter";
            this.anisotropicFilter.Size = new System.Drawing.Size(227, 21);
            this.anisotropicFilter.TabIndex = 17;
            // 
            // shadowQuality
            // 
            this.shadowQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shadowQuality.FormattingEnabled = true;
            this.shadowQuality.Items.AddRange(new object[] {
            "None",
            "Low",
            "Medium",
            "High",
            "Highest"});
            this.shadowQuality.Location = new System.Drawing.Point(157, 240);
            this.shadowQuality.Name = "shadowQuality";
            this.shadowQuality.Size = new System.Drawing.Size(227, 21);
            this.shadowQuality.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Draw FPS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Sobel Filter";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Anisotropic Filtering";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Shadow Quality";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(18, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(366, 2);
            this.label7.TabIndex = 11;
            // 
            // volume
            // 
            this.volume.LargeChange = 2;
            this.volume.Location = new System.Drawing.Point(157, 170);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(227, 45);
            this.volume.TabIndex = 10;
            this.volume.Value = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Volume";
            // 
            // refreshRate
            // 
            this.refreshRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.refreshRate.FormattingEnabled = true;
            this.refreshRate.Items.AddRange(new object[] {
            "30hz",
            "60hz",
            "144hz",
            "240hz"});
            this.refreshRate.Location = new System.Drawing.Point(157, 116);
            this.refreshRate.Name = "refreshRate";
            this.refreshRate.Size = new System.Drawing.Size(227, 21);
            this.refreshRate.TabIndex = 8;
            // 
            // vsync
            // 
            this.vsync.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vsync.FormattingEnabled = true;
            this.vsync.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.vsync.Location = new System.Drawing.Point(157, 86);
            this.vsync.Name = "vsync";
            this.vsync.Size = new System.Drawing.Size(227, 21);
            this.vsync.TabIndex = 7;
            // 
            // displayMode
            // 
            this.displayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displayMode.FormattingEnabled = true;
            this.displayMode.Items.AddRange(new object[] {
            "Windowed",
            "Borderless"});
            this.displayMode.Location = new System.Drawing.Point(157, 52);
            this.displayMode.Name = "displayMode";
            this.displayMode.Size = new System.Drawing.Size(227, 21);
            this.displayMode.TabIndex = 6;
            // 
            // resolution
            // 
            this.resolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolution.FormattingEnabled = true;
            this.resolution.Items.AddRange(new object[] {
            "1280x720",
            "1600x900",
            "1920x1080",
            "2560x1440",
            "3840x2160",
            ""});
            this.resolution.Location = new System.Drawing.Point(157, 20);
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(227, 21);
            this.resolution.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(18, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(366, 2);
            this.label5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Refresh Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "V-Sync";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Display Mode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resolution";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AmazeLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 473);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AmazeLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amaze Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox resolution;
        private System.Windows.Forms.ComboBox refreshRate;
        private System.Windows.Forms.ComboBox vsync;
        private System.Windows.Forms.ComboBox displayMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar volume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox drawFPS;
        private System.Windows.Forms.ComboBox sobelFilter;
        private System.Windows.Forms.ComboBox anisotropicFilter;
        private System.Windows.Forms.ComboBox shadowQuality;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
    }
}

