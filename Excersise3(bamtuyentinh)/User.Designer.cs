namespace Excersise3
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.Search_textbox = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.watch_button = new System.Windows.Forms.Button();
            this.choose = new System.Windows.Forms.Label();
            this.show_textbox = new System.Windows.Forms.RichTextBox();
            this.Remove_people = new System.Windows.Forms.Button();
            this.ExitApp = new System.Windows.Forms.Button();
            this.rdt_Searchbutton = new System.Windows.Forms.RadioButton();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Search_textbox
            // 
            this.Search_textbox.BackColor = System.Drawing.Color.Honeydew;
            this.Search_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_textbox.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Search_textbox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Search_textbox.Location = new System.Drawing.Point(662, 109);
            this.Search_textbox.Name = "Search_textbox";
            this.Search_textbox.Size = new System.Drawing.Size(330, 52);
            this.Search_textbox.TabIndex = 3;
            this.Search_textbox.TextChanged += new System.EventHandler(this.Search_textbox_TextChanged);
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.Honeydew;
            this.Search_button.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Search_button.Location = new System.Drawing.Point(1048, 328);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(200, 102);
            this.Search_button.TabIndex = 5;
            this.Search_button.Text = "Translation ";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // watch_button
            // 
            this.watch_button.BackColor = System.Drawing.Color.Honeydew;
            this.watch_button.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watch_button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.watch_button.Location = new System.Drawing.Point(1305, 328);
            this.watch_button.Name = "watch_button";
            this.watch_button.Size = new System.Drawing.Size(193, 102);
            this.watch_button.TabIndex = 6;
            this.watch_button.Text = "Open Word Dictionary";
            this.watch_button.UseVisualStyleBackColor = false;
            this.watch_button.Click += new System.EventHandler(this.watch_button_Click);
            // 
            // choose
            // 
            this.choose.AutoSize = true;
            this.choose.BackColor = System.Drawing.Color.Moccasin;
            this.choose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.choose.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.choose.ForeColor = System.Drawing.Color.RoyalBlue;
            this.choose.Image = global::Excersise3.Properties.Resources._003;
            this.choose.Location = new System.Drawing.Point(247, 0);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(745, 59);
            this.choose.TabIndex = 8;
            this.choose.Text = "ENGLISH-VIETNAMESE DICTIONARY";
            this.choose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // show_textbox
            // 
            this.show_textbox.BackColor = System.Drawing.Color.Honeydew;
            this.show_textbox.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_textbox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.show_textbox.Location = new System.Drawing.Point(12, 220);
            this.show_textbox.Name = "show_textbox";
            this.show_textbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.show_textbox.Size = new System.Drawing.Size(966, 653);
            this.show_textbox.TabIndex = 4;
            this.show_textbox.Text = "";
            this.show_textbox.TextChanged += new System.EventHandler(this.show_textbox_TextChanged);
            // 
            // Remove_people
            // 
            this.Remove_people.BackColor = System.Drawing.Color.Honeydew;
            this.Remove_people.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_people.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Remove_people.Location = new System.Drawing.Point(1048, 511);
            this.Remove_people.Name = "Remove_people";
            this.Remove_people.Size = new System.Drawing.Size(200, 91);
            this.Remove_people.TabIndex = 18;
            this.Remove_people.Text = "Clear TextBox";
            this.Remove_people.UseVisualStyleBackColor = false;
            this.Remove_people.Click += new System.EventHandler(this.Remove_people_Click);
            // 
            // ExitApp
            // 
            this.ExitApp.BackColor = System.Drawing.Color.Honeydew;
            this.ExitApp.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitApp.ForeColor = System.Drawing.Color.Red;
            this.ExitApp.Location = new System.Drawing.Point(1305, 511);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(199, 91);
            this.ExitApp.TabIndex = 19;
            this.ExitApp.Text = "Exit";
            this.ExitApp.UseVisualStyleBackColor = false;
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // rdt_Searchbutton
            // 
            this.rdt_Searchbutton.AutoSize = true;
            this.rdt_Searchbutton.BackColor = System.Drawing.Color.Gold;
            this.rdt_Searchbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdt_Searchbutton.Location = new System.Drawing.Point(12, 114);
            this.rdt_Searchbutton.Name = "rdt_Searchbutton";
            this.rdt_Searchbutton.Size = new System.Drawing.Size(620, 42);
            this.rdt_Searchbutton.TabIndex = 22;
            this.rdt_Searchbutton.TabStop = true;
            this.rdt_Searchbutton.Text = "Searching Of Meaning (EngLish - VietNamese)\r\n";
            this.rdt_Searchbutton.UseVisualStyleBackColor = false;
            this.rdt_Searchbutton.CheckedChanged += new System.EventHandler(this.rdt_Searchbutton_CheckedChanged);
            // 
            // dtpNgay
            // 
            this.dtpNgay.CalendarForeColor = System.Drawing.Color.SkyBlue;
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtpNgay.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpNgay.Location = new System.Drawing.Point(1340, 0);
            this.dtpNgay.Margin = new System.Windows.Forms.Padding(5);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.ShowCheckBox = true;
            this.dtpNgay.Size = new System.Drawing.Size(250, 25);
            this.dtpNgay.TabIndex = 25;
            // 
            // User
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::Excersise3.Properties.Resources._005;
            this.ClientSize = new System.Drawing.Size(1590, 839);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.Remove_people);
            this.Controls.Add(this.watch_button);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.rdt_Searchbutton);
            this.Controls.Add(this.ExitApp);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.show_textbox);
            this.Controls.Add(this.Search_textbox);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.Google_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Search_textbox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button watch_button;
        private System.Windows.Forms.RichTextBox show_textbox;
        private System.Windows.Forms.Button Remove_people;
        private System.Windows.Forms.Button ExitApp;
        private System.Windows.Forms.RadioButton rdt_Searchbutton;
        private System.Windows.Forms.Label choose;
        private System.Windows.Forms.DateTimePicker dtpNgay;
    }
}