namespace drag
{
    partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.btnplay = new System.Windows.Forms.Button();
			this.btnquit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnplay
			// 
			this.btnplay.BackColor = System.Drawing.Color.Transparent;
			this.btnplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnplay.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnplay.FlatAppearance.BorderSize = 0;
			this.btnplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnplay.Location = new System.Drawing.Point(512, 207);
			this.btnplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnplay.Name = "btnplay";
			this.btnplay.Size = new System.Drawing.Size(207, 46);
			this.btnplay.TabIndex = 0;
			this.btnplay.UseVisualStyleBackColor = false;
			this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
			// 
			// btnquit
			// 
			this.btnquit.BackColor = System.Drawing.Color.Transparent;
			this.btnquit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnquit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnquit.FlatAppearance.BorderSize = 0;
			this.btnquit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnquit.Location = new System.Drawing.Point(512, 388);
			this.btnquit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnquit.Name = "btnquit";
			this.btnquit.Size = new System.Drawing.Size(207, 46);
			this.btnquit.TabIndex = 1;
			this.btnquit.UseVisualStyleBackColor = false;
			this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::drag.Properties.Resources.sss1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1253, 586);
			this.Controls.Add(this.btnquit);
			this.Controls.Add(this.btnplay);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.Name = "Form2";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "eLearning Game |Find My Veggie ";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnquit;
    }
}