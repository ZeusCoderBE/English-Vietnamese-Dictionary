namespace Excersise3
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.login_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.account_textbox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Hide_Password_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.Honeydew;
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.login_button.Location = new System.Drawing.Point(24, 346);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(182, 58);
            this.login_button.TabIndex = 7;
            this.login_button.Text = "Login ";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Honeydew;
            this.exit_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.Red;
            this.exit_button.Location = new System.Drawing.Point(445, 346);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(188, 58);
            this.exit_button.TabIndex = 8;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // account_textbox
            // 
            this.account_textbox.BackColor = System.Drawing.Color.Honeydew;
            this.account_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.account_textbox.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.account_textbox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.account_textbox.Location = new System.Drawing.Point(231, 199);
            this.account_textbox.Name = "account_textbox";
            this.account_textbox.Size = new System.Drawing.Size(306, 41);
            this.account_textbox.TabIndex = 9;
            // 
            // password_textBox
            // 
            this.password_textBox.BackColor = System.Drawing.Color.Honeydew;
            this.password_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.password_textBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.password_textBox.Location = new System.Drawing.Point(231, 271);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(306, 41);
            this.password_textBox.TabIndex = 10;
            this.password_textBox.UseSystemPasswordChar = true;
            this.password_textBox.TextChanged += new System.EventHandler(this.password_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Image = global::Excersise3.Properties.Resources._005;
            this.label1.Location = new System.Drawing.Point(56, 200);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(131, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "Account ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Image = global::Excersise3.Properties.Resources._005;
            this.label2.Location = new System.Drawing.Point(56, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 40);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hide_Password_button
            // 
            this.Hide_Password_button.BackColor = System.Drawing.Color.Honeydew;
            this.Hide_Password_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hide_Password_button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Hide_Password_button.Location = new System.Drawing.Point(231, 346);
            this.Hide_Password_button.Name = "Hide_Password_button";
            this.Hide_Password_button.Size = new System.Drawing.Size(188, 58);
            this.Hide_Password_button.TabIndex = 13;
            this.Hide_Password_button.Text = "Show Password";
            this.Hide_Password_button.UseVisualStyleBackColor = true;
            this.Hide_Password_button.Click += new System.EventHandler(this.Hide_Password_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Image = global::Excersise3.Properties.Resources._005;
            this.label3.Location = new System.Drawing.Point(56, 41);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(249, 40);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tài Khoản: admin ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Image = global::Excersise3.Properties.Resources._005;
            this.label4.Location = new System.Drawing.Point(56, 109);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(296, 40);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mật Khẩu: admin123 ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Excersise3.Properties.Resources._004;
            this.ClientSize = new System.Drawing.Size(656, 423);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Hide_Password_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.account_textbox);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.login_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.TextBox account_textbox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Hide_Password_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}