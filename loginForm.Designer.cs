namespace Login_and_Register_System
{
    partial class loginForm
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
            lblBackLog = new Label();
            lblHaveAcc = new Label();
            button1 = new Button();
            btnRegister = new Button();
            checkbxshowpass = new CheckBox();
            txtpassword = new TextBox();
            txtUsername = new TextBox();
            lblpassword = new Label();
            lblusername = new Label();
            lblgetstart = new Label();
            SuspendLayout();
            // 
            // lblBackLog
            // 
            lblBackLog.AutoSize = true;
            lblBackLog.Cursor = Cursors.Hand;
            lblBackLog.ForeColor = Color.RoyalBlue;
            lblBackLog.Location = new Point(94, 532);
            lblBackLog.Name = "lblBackLog";
            lblBackLog.Size = new Size(157, 28);
            lblBackLog.TabIndex = 16;
            lblBackLog.Text = "Create Account";
            lblBackLog.Click += lblBackLog_Click;
            // 
            // lblHaveAcc
            // 
            lblHaveAcc.AutoSize = true;
            lblHaveAcc.Location = new Point(63, 504);
            lblHaveAcc.Name = "lblHaveAcc";
            lblHaveAcc.Size = new Size(226, 28);
            lblHaveAcc.TabIndex = 17;
            lblHaveAcc.Text = "Dont Have an Account";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(42, 427);
            button1.Name = "button1";
            button1.Size = new Size(289, 48);
            button1.TabIndex = 14;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DodgerBlue;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(42, 363);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(289, 48);
            btnRegister.TabIndex = 15;
            btnRegister.Text = "LOGIN";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // checkbxshowpass
            // 
            checkbxshowpass.AutoSize = true;
            checkbxshowpass.Cursor = Cursors.Hand;
            checkbxshowpass.FlatStyle = FlatStyle.Flat;
            checkbxshowpass.Location = new Point(148, 303);
            checkbxshowpass.Name = "checkbxshowpass";
            checkbxshowpass.Size = new Size(178, 32);
            checkbxshowpass.TabIndex = 13;
            checkbxshowpass.Text = "Show Password";
            checkbxshowpass.UseVisualStyleBackColor = true;
            checkbxshowpass.CheckedChanged += checkbxshowpass_CheckedChanged;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.FromArgb(230, 231, 233);
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(42, 259);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '.';
            txtpassword.Size = new Size(289, 35);
            txtpassword.TabIndex = 11;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(42, 180);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(289, 35);
            txtUsername.TabIndex = 12;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(42, 228);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(100, 28);
            lblpassword.TabIndex = 8;
            lblpassword.Text = "Password";
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(42, 149);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(106, 28);
            lblusername.TabIndex = 9;
            lblusername.Text = "Username";
            // 
            // lblgetstart
            // 
            lblgetstart.AutoSize = true;
            lblgetstart.Font = new Font("MS UI Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblgetstart.ForeColor = Color.RoyalBlue;
            lblgetstart.Location = new Point(63, 61);
            lblgetstart.Name = "lblgetstart";
            lblgetstart.Size = new Size(226, 40);
            lblgetstart.TabIndex = 6;
            lblgetstart.Text = "Get Started";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(370, 638);
            Controls.Add(lblBackLog);
            Controls.Add(lblHaveAcc);
            Controls.Add(button1);
            Controls.Add(btnRegister);
            Controls.Add(checkbxshowpass);
            Controls.Add(txtpassword);
            Controls.Add(txtUsername);
            Controls.Add(lblpassword);
            Controls.Add(lblusername);
            Controls.Add(lblgetstart);
            Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginForm";
            Load += loginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBackLog;
        private Label lblHaveAcc;
        private Button button1;
        private Button btnRegister;
        private CheckBox checkbxshowpass;
        private TextBox txtpassword;
        private TextBox txtUsername;
        private Label lblpassword;
        private Label lblusername;
        private Label lblgetstart;
    }
}