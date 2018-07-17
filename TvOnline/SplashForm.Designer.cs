namespace TvOnline
{
    partial class SplashForm
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
            System.Windows.Forms.Label lblTitle;
            this.splash_bkgnd = new System.Windows.Forms.PictureBox();
            this.splash_progBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splash_bkgnd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            lblTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            lblTitle.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            lblTitle.Location = new System.Drawing.Point(0, 344);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(340, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "TV Online - PAV 2017-1";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splash_bkgnd
            // 
            this.splash_bkgnd.BackColor = System.Drawing.Color.Transparent;
            this.splash_bkgnd.Dock = System.Windows.Forms.DockStyle.Top;
            this.splash_bkgnd.Image = global::TvOnline.Properties.Resources.dino_tv;
            this.splash_bkgnd.Location = new System.Drawing.Point(0, 0);
            this.splash_bkgnd.Name = "splash_bkgnd";
            this.splash_bkgnd.Size = new System.Drawing.Size(340, 343);
            this.splash_bkgnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.splash_bkgnd.TabIndex = 0;
            this.splash_bkgnd.TabStop = false;
            // 
            // splash_progBar
            // 
            this.splash_progBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splash_progBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splash_progBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splash_progBar.ForeColor = System.Drawing.Color.DarkBlue;
            this.splash_progBar.Location = new System.Drawing.Point(0, 389);
            this.splash_progBar.Maximum = 102;
            this.splash_progBar.Name = "splash_progBar";
            this.splash_progBar.Size = new System.Drawing.Size(340, 18);
            this.splash_progBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.splash_progBar.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(340, 407);
            this.Controls.Add(lblTitle);
            this.Controls.Add(this.splash_progBar);
            this.Controls.Add(this.splash_bkgnd);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TV Online";
            this.TransparencyKey = System.Drawing.Color.Azure;
            ((System.ComponentModel.ISupportInitialize)(this.splash_bkgnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox splash_bkgnd;
        private System.Windows.Forms.ProgressBar splash_progBar;
        private System.Windows.Forms.Timer timer1;
    }
}