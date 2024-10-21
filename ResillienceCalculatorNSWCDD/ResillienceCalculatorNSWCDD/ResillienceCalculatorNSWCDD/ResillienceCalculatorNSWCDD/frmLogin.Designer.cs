namespace ResillienceCalculatorNSWCDD
{
    partial class frmLogin
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
            label1 = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lbUser = new Label();
            lbPassword = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 25);
            label1.TabIndex = 0;
            label1.Text = "Please enter your credentials:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(22, 175);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(419, 249);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(124, 39);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 27);
            textBox2.TabIndex = 4;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUser.Location = new Point(22, 54);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(95, 25);
            lbUser.TabIndex = 5;
            lbUser.Text = "Username:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPassword.Location = new Point(22, 107);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(96, 25);
            lbPassword.TabIndex = 6;
            lbPassword.Text = "Password: ";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 300);
            Controls.Add(lbPassword);
            Controls.Add(lbUser);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogin;
        private Button btnExit;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lbUser;
        private Label lbPassword;
    }
}