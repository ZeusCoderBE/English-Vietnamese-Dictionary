namespace Excersise3
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.Admin_button = new System.Windows.Forms.Button();
            this.User_button = new System.Windows.Forms.Button();
            this.ExitApp = new System.Windows.Forms.Button();
            this.Sound_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Admin_button
            // 
            this.Admin_button.BackColor = System.Drawing.Color.Honeydew;
            this.Admin_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Admin_button.Location = new System.Drawing.Point(126, 162);
            this.Admin_button.Name = "Admin_button";
            this.Admin_button.Size = new System.Drawing.Size(217, 75);
            this.Admin_button.TabIndex = 6;
            this.Admin_button.Text = "Administrator";
            this.Admin_button.UseVisualStyleBackColor = false;
            this.Admin_button.Click += new System.EventHandler(this.Admin_button_Click);
            // 
            // User_button
            // 
            this.User_button.BackColor = System.Drawing.Color.Honeydew;
            this.User_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.User_button.Location = new System.Drawing.Point(126, 270);
            this.User_button.Name = "User_button";
            this.User_button.Size = new System.Drawing.Size(217, 73);
            this.User_button.TabIndex = 7;
            this.User_button.Text = "User";
            this.User_button.UseVisualStyleBackColor = false;
            this.User_button.Click += new System.EventHandler(this.User_button_Click);
            // 
            // ExitApp
            // 
            this.ExitApp.BackColor = System.Drawing.Color.Honeydew;
            this.ExitApp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ExitApp.ForeColor = System.Drawing.Color.Red;
            this.ExitApp.Location = new System.Drawing.Point(126, 465);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(217, 69);
            this.ExitApp.TabIndex = 20;
            this.ExitApp.Text = "Exit";
            this.ExitApp.UseVisualStyleBackColor = false;
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // Sound_button
            // 
            this.Sound_button.BackColor = System.Drawing.Color.Honeydew;
            this.Sound_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Sound_button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Sound_button.Location = new System.Drawing.Point(126, 375);
            this.Sound_button.Name = "Sound_button";
            this.Sound_button.Size = new System.Drawing.Size(217, 70);
            this.Sound_button.TabIndex = 25;
            this.Sound_button.Text = "Sound ";
            this.Sound_button.UseVisualStyleBackColor = false;
            this.Sound_button.Click += new System.EventHandler(this.Sound_button_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Excersise3.Properties.Resources._004;
            this.ClientSize = new System.Drawing.Size(461, 699);
            this.Controls.Add(this.Sound_button);
            this.Controls.Add(this.ExitApp);
            this.Controls.Add(this.User_button);
            this.Controls.Add(this.Admin_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Admin_button;
        private System.Windows.Forms.Button User_button;
        private System.Windows.Forms.Button ExitApp;
        private System.Windows.Forms.Button Sound_button;
    }
}