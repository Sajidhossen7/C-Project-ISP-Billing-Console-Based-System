namespace ISPManagement
{
    partial class FormLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblWelcome = new System.Windows.Forms.Label();
            this.Btnlogin = new System.Windows.Forms.Button();
            this.CheckBoxRemember = new System.Windows.Forms.CheckBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.TxtBoxUsername = new System.Windows.Forms.TextBox();
            this.TxtBoxPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ISPManagement.Properties.Resources.loginPageIMG;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 642);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.TxtBoxPassword);
            this.panel2.Controls.Add(this.LblPassword);
            this.panel2.Controls.Add(this.TxtBoxUsername);
            this.panel2.Controls.Add(this.LblUsername);
            this.panel2.Controls.Add(this.CheckBoxRemember);
            this.panel2.Controls.Add(this.Btnlogin);
            this.panel2.Controls.Add(this.LblLogin);
            this.panel2.Controls.Add(this.LblWelcome);
            this.panel2.Location = new System.Drawing.Point(316, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 431);
            this.panel2.TabIndex = 2;
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.BackColor = System.Drawing.Color.Transparent;
            this.LblLogin.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblLogin.Location = new System.Drawing.Point(111, 55);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(253, 21);
            this.LblLogin.TabIndex = 1;
            this.LblLogin.Text = "Login your account to continue";
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcome.ForeColor = System.Drawing.Color.BlueViolet;
            this.LblWelcome.Location = new System.Drawing.Point(123, 11);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(199, 34);
            this.LblWelcome.TabIndex = 0;
            this.LblWelcome.Text = "Welcome Back";
            // 
            // Btnlogin
            // 
            this.Btnlogin.BackColor = System.Drawing.Color.Wheat;
            this.Btnlogin.Location = new System.Drawing.Point(204, 395);
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Size = new System.Drawing.Size(75, 23);
            this.Btnlogin.TabIndex = 2;
            this.Btnlogin.Text = "Login";
            this.Btnlogin.UseVisualStyleBackColor = false;
            // 
            // CheckBoxRemember
            // 
            this.CheckBoxRemember.AutoSize = true;
            this.CheckBoxRemember.Location = new System.Drawing.Point(129, 278);
            this.CheckBoxRemember.Name = "CheckBoxRemember";
            this.CheckBoxRemember.Size = new System.Drawing.Size(126, 17);
            this.CheckBoxRemember.TabIndex = 3;
            this.CheckBoxRemember.Text = "Remember Password";
            this.CheckBoxRemember.UseVisualStyleBackColor = true;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.Location = new System.Drawing.Point(99, 144);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(67, 15);
            this.LblUsername.TabIndex = 4;
            this.LblUsername.Text = "User Name";
            // 
            // TxtBoxUsername
            // 
            this.TxtBoxUsername.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxUsername.Location = new System.Drawing.Point(204, 144);
            this.TxtBoxUsername.Name = "TxtBoxUsername";
            this.TxtBoxUsername.Size = new System.Drawing.Size(158, 22);
            this.TxtBoxUsername.TabIndex = 5;
            // 
            // TxtBoxPassword
            // 
            this.TxtBoxPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxPassword.Location = new System.Drawing.Point(204, 219);
            this.TxtBoxPassword.Name = "TxtBoxPassword";
            this.TxtBoxPassword.PasswordChar = '*';
            this.TxtBoxPassword.Size = new System.Drawing.Size(158, 22);
            this.TxtBoxPassword.TabIndex = 7;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(99, 219);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(59, 15);
            this.LblPassword.TabIndex = 6;
            this.LblPassword.Text = "Password";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 641);
            this.Controls.Add(this.panel1);
            this.Name = "FormLogin";
            this.Text = "login";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.TextBox TxtBoxUsername;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.CheckBox CheckBoxRemember;
        private System.Windows.Forms.Button Btnlogin;
        private System.Windows.Forms.TextBox TxtBoxPassword;
        private System.Windows.Forms.Label LblPassword;
    }
}