namespace Login_and_Register_System
{
    partial class Form1
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
            lblgetstart = new Label();
            lblusername = new Label();
            txtUsername = new TextBox();
            lblpassword = new Label();
            txtpassword = new TextBox();
            lblconfirmpass = new Label();
            txtconfirmpass = new TextBox();
            checkbxshowpass = new CheckBox();
            btnRegister = new Button();
            button1 = new Button();
            lblHaveAcc = new Label();
            lblBackLog = new Label();
            SuspendLayout();
            // 
            // lblgetstart
            // 
            lblgetstart.AutoSize = true;
            lblgetstart.Font = new Font("MS UI Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblgetstart.ForeColor = Color.RoyalBlue;
            lblgetstart.Location = new Point(53, 72);
            lblgetstart.Name = "lblgetstart";
            lblgetstart.Size = new Size(226, 40);
            lblgetstart.TabIndex = 0;
            lblgetstart.Text = "Get Started";
            lblgetstart.Click += label1_Click;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(32, 149);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(106, 28);
            lblusername.TabIndex = 1;
            lblusername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(32, 180);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(289, 35);
            txtUsername.TabIndex = 2;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(32, 228);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(100, 28);
            lblpassword.TabIndex = 1;
            lblpassword.Text = "Password";
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.FromArgb(230, 231, 233);
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("MS UI Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(32, 259);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(289, 35);
            txtpassword.TabIndex = 2;
            // 
            // lblconfirmpass
            // 
            lblconfirmpass.AutoSize = true;
            lblconfirmpass.Location = new Point(32, 310);
            lblconfirmpass.Name = "lblconfirmpass";
            lblconfirmpass.Size = new Size(182, 28);
            lblconfirmpass.TabIndex = 1;
            lblconfirmpass.Text = "Confirm Password";
            // 
            // txtconfirmpass
            // 
            txtconfirmpass.BackColor = Color.FromArgb(230, 231, 233);
            txtconfirmpass.BorderStyle = BorderStyle.None;
            txtconfirmpass.Font = new Font("MS UI Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtconfirmpass.Location = new Point(32, 341);
            txtconfirmpass.Multiline = true;
            txtconfirmpass.Name = "txtconfirmpass";
            txtconfirmpass.Size = new Size(289, 35);
            txtconfirmpass.TabIndex = 2;
            // 
            // checkbxshowpass
            // 
            checkbxshowpass.AutoSize = true;
            checkbxshowpass.Cursor = Cursors.Hand;
            checkbxshowpass.FlatStyle = FlatStyle.Flat;
            checkbxshowpass.Location = new Point(138, 382);
            checkbxshowpass.Name = "checkbxshowpass";
            checkbxshowpass.Size = new Size(178, 32);
            checkbxshowpass.TabIndex = 3;
            checkbxshowpass.Text = "Show Password";
            checkbxshowpass.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DodgerBlue;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(32, 442);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(289, 48);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(32, 506);
            button1.Name = "button1";
            button1.Size = new Size(289, 48);
            button1.TabIndex = 4;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblHaveAcc
            // 
            lblHaveAcc.AutoSize = true;
            lblHaveAcc.Location = new Point(53, 583);
            lblHaveAcc.Name = "lblHaveAcc";
            lblHaveAcc.Size = new Size(252, 28);
            lblHaveAcc.TabIndex = 5;
            lblHaveAcc.Text = "Already Have an Account";
            // 
            // lblBackLog
            // 
            lblBackLog.AutoSize = true;
            lblBackLog.Cursor = Cursors.Hand;
            lblBackLog.ForeColor = Color.RoyalBlue;
            lblBackLog.Location = new Point(93, 611);
            lblBackLog.Name = "lblBackLog";
            lblBackLog.Size = new Size(149, 28);
            lblBackLog.TabIndex = 5;
            lblBackLog.Text = "Back to LOGIN";
            lblBackLog.Click += lblBackLog_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(368, 691);
            Controls.Add(lblBackLog);
            Controls.Add(lblHaveAcc);
            Controls.Add(button1);
            Controls.Add(btnRegister);
            Controls.Add(checkbxshowpass);
            Controls.Add(txtconfirmpass);
            Controls.Add(txtpassword);
            Controls.Add(txtUsername);
            Controls.Add(lblconfirmpass);
            Controls.Add(lblpassword);
            Controls.Add(lblusername);
            Controls.Add(lblgetstart);
            Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblgetstart;
        private Label lblusername;
        private TextBox txtUsername;
        private Label lblpassword;
        private TextBox txtpassword;
        private Label lblconfirmpass;
        private TextBox txtconfirmpass;
        private CheckBox checkbxshowpass;
        private Button btnRegister;
        private Button button1;
        private Label lblHaveAcc;
        private Label lblBackLog;
    }
}
