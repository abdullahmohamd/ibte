namespace log_in
{
    partial class mario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Exit = new Button();
            login = new Button();
            username = new Label();
            Password = new Label();
            label3 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.Location = new Point(225, 368);
            Exit.Name = "Exit";
            Exit.Size = new Size(97, 29);
            Exit.TabIndex = 0;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // login
            // 
            login.Location = new Point(482, 368);
            login.Name = "login";
            login.Size = new Size(94, 29);
            login.TabIndex = 1;
            login.Text = "login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 16.2F);
            username.ForeColor = SystemColors.ButtonHighlight;
            username.Location = new Point(326, 108);
            username.Name = "username";
            username.Size = new Size(164, 38);
            username.TabIndex = 2;
            username.Text = "User name :";
            username.Click += username_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 16.2F);
            Password.ForeColor = SystemColors.ButtonHighlight;
            Password.Location = new Point(337, 232);
            Password.Name = "Password";
            Password.Size = new Size(138, 38);
            Password.TabIndex = 3;
            Password.Text = "Password:";
            Password.Click += Password_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 178);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 4;
            label3.Text = "  ";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(185, 171);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(438, 27);
            txtusername.TabIndex = 5;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(185, 284);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(438, 27);
            txtpassword.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Plum;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 62);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(335, 10);
            label2.Name = "label2";
            label2.Size = new Size(92, 41);
            label2.TabIndex = 0;
            label2.Text = "Login";
            // 
            // mario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrchid;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(Password);
            Controls.Add(username);
            Controls.Add(login);
            Controls.Add(Exit);
            Name = "mario";
            Text = "mario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Exit;
        private Button login;
        private Label username;
        private Label Password;
        private Label label3;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Panel panel1;
        private Label label2;
    }
}
