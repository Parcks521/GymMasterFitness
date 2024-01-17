namespace GymMasterFitness
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            loginUserName = new RichTextBox();
            loginPassword = new RichTextBox();
            btnLogin = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Russo One", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(195, 355);
            label1.Name = "label1";
            label1.Size = new Size(475, 77);
            label1.TabIndex = 0;
            label1.Text = "GYM MASTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(362, 434);
            label2.Name = "label2";
            label2.Size = new Size(127, 33);
            label2.TabIndex = 1;
            label2.Text = "FITNESS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(966, 226);
            label3.Name = "label3";
            label3.Size = new Size(89, 37);
            label3.TabIndex = 2;
            label3.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(824, 295);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 3;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(824, 397);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // loginUserName
            // 
            loginUserName.Location = new Point(824, 319);
            loginUserName.Name = "loginUserName";
            loginUserName.Size = new Size(394, 42);
            loginUserName.TabIndex = 5;
            loginUserName.Text = "";
            // 
            // loginPassword
            // 
            loginPassword.Location = new Point(824, 434);
            loginPassword.Name = "loginPassword";
            loginPassword.Size = new Size(394, 42);
            loginPassword.TabIndex = 6;
            loginPassword.Text = "";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Chocolate;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(844, 532);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(143, 48);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Chocolate;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.Transparent;
            btnReset.Location = new Point(1048, 532);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(143, 48);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._6375161;
            ClientSize = new Size(1331, 848);
            Controls.Add(btnReset);
            Controls.Add(btnLogin);
            Controls.Add(loginPassword);
            Controls.Add(loginUserName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Login";
            Text = "GymMasterFitness";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox loginUserName;
        private RichTextBox loginPassword;
        private Button btnLogin;
        private Button btnReset;
    }
}