namespace Gym_Membership_System_wDesign
{
    partial class Login_Logout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Logout));
            panel1 = new Panel();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnShow = new Button();
            btnHide = new Button();
            btnLogin = new Button();
            button5 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(865, 111);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold);
            label3.Location = new Point(35, 25);
            label3.Name = "label3";
            label3.Size = new Size(806, 57);
            label3.TabIndex = 5;
            label3.Text = " Hinundayan Gym Management System";
            label3.Click += label3_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14F);
            txtUsername.Location = new Point(95, 107);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(354, 48);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 17F);
            txtPassword.Location = new Point(95, 237);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(354, 48);
            txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(95, 66);
            label1.Name = "label1";
            label1.Size = new Size(172, 41);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(95, 193);
            label2.Name = "label2";
            label2.Size = new Size(172, 41);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(67, 85, 92);
            panel2.Controls.Add(btnShow);
            panel2.Controls.Add(btnHide);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(176, 403);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 387);
            panel2.TabIndex = 5;
            // 
            // btnShow
            // 
            btnShow.BackgroundImage = (Image)resources.GetObject("btnShow.BackgroundImage");
            btnShow.BackgroundImageLayout = ImageLayout.Stretch;
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.Font = new Font("Segoe UI", 1F);
            btnShow.Location = new Point(388, 183);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(61, 48);
            btnShow.TabIndex = 9;
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Visible = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnHide
            // 
            btnHide.BackgroundImage = (Image)resources.GetObject("btnHide.BackgroundImage");
            btnHide.BackgroundImageLayout = ImageLayout.Stretch;
            btnHide.FlatAppearance.BorderSize = 0;
            btnHide.Font = new Font("Segoe UI", 1F);
            btnHide.Location = new Point(388, 237);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(61, 48);
            btnHide.TabIndex = 6;
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14F);
            btnLogin.Location = new Point(222, 312);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(131, 42);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderSize = 0;
            button5.Font = new Font("Segoe UI", 19F);
            button5.Location = new Point(388, 237);
            button5.Name = "button5";
            button5.Size = new Size(61, 48);
            button5.TabIndex = 8;
            button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(271, 117);
            button2.Name = "button2";
            button2.Size = new Size(335, 259);
            button2.TabIndex = 6;
            button2.Text = " ";
            button2.UseVisualStyleBackColor = true;
            // 
            // Login_Logout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 820);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Login_Logout";
            Text = "Login_Logout";
            Load += Login_Logout_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Button btnHide;
        private Button btnLogin;
        private Button button2;
        private Button button5;
        private Button btnShow;
    }
}