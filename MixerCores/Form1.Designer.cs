
namespace MixerCores
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
            this.TrackRed = new MetroFramework.Controls.MetroTrackBar();
            this.TrackGreen = new MetroFramework.Controls.MetroTrackBar();
            this.TrackBlue = new MetroFramework.Controls.MetroTrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Labelred = new MetroFramework.Controls.MetroLabel();
            this.Labelgreen = new MetroFramework.Controls.MetroLabel();
            this.Labelblue = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TrackRed
            // 
            this.TrackRed.BackColor = System.Drawing.Color.Transparent;
            this.TrackRed.Location = new System.Drawing.Point(44, 87);
            this.TrackRed.Maximum = 255;
            this.TrackRed.Name = "TrackRed";
            this.TrackRed.Size = new System.Drawing.Size(210, 25);
            this.TrackRed.TabIndex = 0;
            this.TrackRed.Text = "TrackRed";
            this.TrackRed.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TrackRed.Value = 0;
            this.TrackRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.changecolor);
            // 
            // TrackGreen
            // 
            this.TrackGreen.BackColor = System.Drawing.Color.Transparent;
            this.TrackGreen.Location = new System.Drawing.Point(44, 134);
            this.TrackGreen.Maximum = 255;
            this.TrackGreen.Name = "TrackGreen";
            this.TrackGreen.Size = new System.Drawing.Size(210, 25);
            this.TrackGreen.TabIndex = 1;
            this.TrackGreen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TrackGreen.Value = 0;
            this.TrackGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.changecolor);
            // 
            // TrackBlue
            // 
            this.TrackBlue.BackColor = System.Drawing.Color.Transparent;
            this.TrackBlue.Location = new System.Drawing.Point(44, 179);
            this.TrackBlue.Maximum = 255;
            this.TrackBlue.Name = "TrackBlue";
            this.TrackBlue.Size = new System.Drawing.Size(210, 25);
            this.TrackBlue.TabIndex = 2;
            this.TrackBlue.Text = "TrackBlue";
            this.TrackBlue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TrackBlue.Value = 0;
            this.TrackBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.changecolor);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(44, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 165);
            this.panel1.TabIndex = 3;
            // 
            // Labelred
            // 
            this.Labelred.AutoSize = true;
            this.Labelred.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Labelred.Location = new System.Drawing.Point(268, 87);
            this.Labelred.Name = "Labelred";
            this.Labelred.Size = new System.Drawing.Size(16, 19);
            this.Labelred.TabIndex = 4;
            this.Labelred.Text = "0";
            this.Labelred.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Labelgreen
            // 
            this.Labelgreen.AutoSize = true;
            this.Labelgreen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Labelgreen.Location = new System.Drawing.Point(268, 134);
            this.Labelgreen.Name = "Labelgreen";
            this.Labelgreen.Size = new System.Drawing.Size(16, 19);
            this.Labelgreen.TabIndex = 6;
            this.Labelgreen.Text = "0";
            this.Labelgreen.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Labelblue
            // 
            this.Labelblue.AutoSize = true;
            this.Labelblue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Labelblue.Location = new System.Drawing.Point(268, 179);
            this.Labelblue.Name = "Labelblue";
            this.Labelblue.Size = new System.Drawing.Size(16, 19);
            this.Labelblue.TabIndex = 7;
            this.Labelblue.Text = "0";
            this.Labelblue.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(292, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(292, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 20);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(292, 178);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 20);
            this.panel4.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 542);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Labelblue);
            this.Controls.Add(this.Labelgreen);
            this.Controls.Add(this.Labelred);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TrackBlue);
            this.Controls.Add(this.TrackGreen);
            this.Controls.Add(this.TrackRed);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mix Color";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.changecolor);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTrackBar TrackRed;
        private MetroFramework.Controls.MetroTrackBar TrackGreen;
        private MetroFramework.Controls.MetroTrackBar TrackBlue;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel Labelred;
        private MetroFramework.Controls.MetroLabel Labelgreen;
        private MetroFramework.Controls.MetroLabel Labelblue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

