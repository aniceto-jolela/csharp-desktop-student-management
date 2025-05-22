namespace cpqi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lbl_version = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btn_login = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.AccessibleDescription = "Primeiro teste";
            txtUserName.AccessibleName = "Second test";
            txtUserName.AccessibleRole = AccessibleRole.Text;
            txtUserName.ImeMode = ImeMode.NoControl;
            txtUserName.Location = new Point(359, 139);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Entra com o nome ou com seu email";
            txtUserName.Size = new Size(282, 23);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(359, 231);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Palavra passe";
            txtPassword.Size = new Size(282, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 120);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Usuário :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 211);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 4;
            label3.Text = "Palavra Passe :";
            // 
            // lbl_version
            // 
            lbl_version.AutoSize = true;
            lbl_version.BackColor = Color.Transparent;
            lbl_version.Location = new Point(10, 415);
            lbl_version.Name = "lbl_version";
            lbl_version.Size = new Size(45, 15);
            lbl_version.TabIndex = 7;
            lbl_version.Text = "Version";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(511, 415);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 8;
            label5.Text = " © 2025";
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.cpqi;
            pictureBox1.Location = new Point(18, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.Image = Properties.Resources.backgreoundBlue;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(703, 451);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.mingcute__user_3_fill;
            pictureBox3.Location = new Point(359, 109);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.ph__lock_key_thin;
            pictureBox4.Location = new Point(361, 200);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // btn_login
            // 
            btn_login.Cursor = Cursors.Hand;
            btn_login.Location = new Point(361, 289);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(90, 25);
            btn_login.TabIndex = 13;
            btn_login.Values.DropDownArrowColor = Color.Empty;
            btn_login.Values.Text = "ENTRAR";
            btn_login.Click += btn_login_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 450);
            Controls.Add(btn_login);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(lbl_version);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Label lbl_version;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Krypton.Toolkit.KryptonButton btn_login;
    }
}
