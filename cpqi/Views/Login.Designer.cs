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
            TxtUserName = new TextBox();
            TxtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lbl_version = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            BtnLogin = new Krypton.Toolkit.KryptonButton();
            PbExit = new Krypton.Toolkit.KryptonPictureBox();
            PbLoading = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbLoading).BeginInit();
            SuspendLayout();
            // 
            // TxtUserName
            // 
            TxtUserName.AccessibleDescription = "Primeiro teste";
            TxtUserName.AccessibleName = "Second test";
            TxtUserName.AccessibleRole = AccessibleRole.Text;
            TxtUserName.ImeMode = ImeMode.NoControl;
            TxtUserName.Location = new Point(359, 139);
            TxtUserName.Name = "TxtUserName";
            TxtUserName.PlaceholderText = "Entra com o nome de usuário";
            TxtUserName.Size = new Size(282, 23);
            TxtUserName.TabIndex = 1;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(359, 231);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PlaceholderText = "Palavra passe";
            TxtPassword.Size = new Size(282, 23);
            TxtPassword.TabIndex = 2;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 120);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Usuário :";
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
            // BtnLogin
            // 
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.Location = new Point(361, 289);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(90, 25);
            BtnLogin.TabIndex = 13;
            BtnLogin.Values.DropDownArrowColor = Color.Empty;
            BtnLogin.Values.Text = "ENTRAR";
            BtnLogin.Click += BtnLogin_Click;
            // 
            // PbExit
            // 
            PbExit.Cursor = Cursors.Hand;
            PbExit.Image = Properties.Resources.material_symbols__all_out_rounded;
            PbExit.Location = new Point(668, 12);
            PbExit.Name = "PbExit";
            PbExit.Size = new Size(24, 22);
            PbExit.SizeMode = PictureBoxSizeMode.Zoom;
            PbExit.TabIndex = 14;
            PbExit.TabStop = false;
            PbExit.Click += PbExit_Click;
            // 
            // PbLoading
            // 
            PbLoading.Image = Properties.Resources.Loading;
            PbLoading.Location = new Point(578, 330);
            PbLoading.Name = "PbLoading";
            PbLoading.Size = new Size(114, 87);
            PbLoading.SizeMode = PictureBoxSizeMode.Zoom;
            PbLoading.TabIndex = 15;
            PbLoading.TabStop = false;
            PbLoading.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 450);
            Controls.Add(PbLoading);
            Controls.Add(PbExit);
            Controls.Add(BtnLogin);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(lbl_version);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUserName);
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
            ((System.ComponentModel.ISupportInitialize)PbExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbLoading).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtUserName;
        private TextBox TxtPassword;
        private Label label2;
        private Label label3;
        private Label lbl_version;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Krypton.Toolkit.KryptonButton BtnLogin;
        private Krypton.Toolkit.KryptonPictureBox PbExit;
        private Krypton.Toolkit.KryptonPictureBox PbLoading;
    }
}
