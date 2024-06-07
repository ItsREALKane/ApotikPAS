namespace ApotikPAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtUser = new TextBox();
            txtPw = new TextBox();
            btnLogin = new Button();
            btnClose = new Button();
            checkBox1 = new CheckBox();
            label1 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(145, 171);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Username";
            txtUser.Size = new Size(180, 27);
            txtUser.TabIndex = 0;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPw
            // 
            txtPw.Location = new Point(145, 228);
            txtPw.Name = "txtPw";
            txtPw.PasswordChar = '*';
            txtPw.PlaceholderText = "Password";
            txtPw.Size = new Size(180, 27);
            txtPw.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(136, 342);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(236, 342);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(169, 261);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Square721 BT", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(24, 24, 24);
            label1.Location = new Point(189, 88);
            label1.Name = "label1";
            label1.Size = new Size(90, 34);
            label1.TabIndex = 4;
            label1.Text = "Login";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Square721 BT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(24, 24, 24);
            label7.Location = new Point(43, 41);
            label7.Name = "label7";
            label7.Size = new Size(391, 36);
            label7.TabIndex = 5;
            label7.Text = "APOTEK ORANG SEHAT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(483, 545);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(txtPw);
            Controls.Add(txtUser);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPw;
        private Button btnLogin;
        private Button btnClose;
        private CheckBox checkBox1;
        private Label label1;
        private Label label7;
    }
}