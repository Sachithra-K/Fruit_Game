namespace drag
{
    partial class splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            this.Progressbarsplash = new System.Windows.Forms.ProgressBar();
            this.splashtimer = new System.Windows.Forms.Timer(this.components);
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Progressbarsplash
            // 
            this.Progressbarsplash.ForeColor = System.Drawing.Color.Lime;
            this.Progressbarsplash.Location = new System.Drawing.Point(-1, 464);
            this.Progressbarsplash.MarqueeAnimationSpeed = 50;
            this.Progressbarsplash.Name = "Progressbarsplash";
            this.Progressbarsplash.Size = new System.Drawing.Size(958, 36);
            this.Progressbarsplash.TabIndex = 0;
            // 
            // splashtimer
            // 
            this.splashtimer.Enabled = true;
            this.splashtimer.Interval = 30;
            this.splashtimer.Tick += new System.EventHandler(this.splashtimer_Tick);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Image = global::drag.Properties.Resources.FindMyVegi_2;
            this.picLogo.Location = new System.Drawing.Point(54, 26);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(858, 432);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 515);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.Progressbarsplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splash";
            this.Load += new System.EventHandler(this.splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar Progressbarsplash;
        private System.Windows.Forms.Timer splashtimer;
        private System.Windows.Forms.PictureBox picLogo;
    }
}