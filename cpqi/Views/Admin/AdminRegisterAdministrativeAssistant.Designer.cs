namespace cpqi.Views.Admin
{
    partial class AdminRegisterAdministrativeAssistant
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRegisterAdministrativeAssistant));
            BtnRegister = new Krypton.Toolkit.KryptonButton();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            BtnPhoto = new Krypton.Toolkit.KryptonButton();
            kryptonLabel28 = new Krypton.Toolkit.KryptonLabel();
            BtnCV = new Krypton.Toolkit.KryptonButton();
            BtnBI = new Krypton.Toolkit.KryptonButton();
            DtpDateOfBirth = new Krypton.Toolkit.KryptonDateTimePicker();
            TxtPhone = new Krypton.Toolkit.KryptonTextBox();
            TxtEmail = new Krypton.Toolkit.KryptonTextBox();
            TxtFullName = new Krypton.Toolkit.KryptonTextBox();
            TxtUserName = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel27 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel26 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel25 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel19 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel20 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel21 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel22 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel23 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel24 = new Krypton.Toolkit.KryptonLabel();
            CbSex = new Krypton.Toolkit.KryptonComboBox();
            TxtRole = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            TxtPassword = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            DtpIssuedOn = new Krypton.Toolkit.KryptonDateTimePicker();
            DtpValidUntil = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            EpUser = new ErrorProvider(components);
            EpFullName = new ErrorProvider(components);
            TxtNBI = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            EpEmail = new ErrorProvider(components);
            EpPhone = new ErrorProvider(components);
            EpNBI = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CbSex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EpUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EpFullName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EpEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EpPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EpNBI).BeginInit();
            SuspendLayout();
            // 
            // BtnRegister
            // 
            BtnRegister.Cursor = Cursors.Hand;
            BtnRegister.Location = new Point(433, 505);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(90, 25);
            BtnRegister.TabIndex = 23;
            BtnRegister.Values.DropDownArrowColor = Color.Empty;
            BtnRegister.Values.Text = "REGISTRAR";
            BtnRegister.Click += BtnRegister_Click;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonPictureBox1);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Dock = DockStyle.Top;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(896, 45);
            kryptonPanel1.StateNormal.Color1 = SystemColors.ControlLight;
            kryptonPanel1.TabIndex = 24;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Image = Properties.Resources.mdi__user_tie;
            kryptonPictureBox1.Location = new Point(239, 13);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(21, 23);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBox1.TabIndex = 3;
            kryptonPictureBox1.TabStop = false;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(262, 11);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(294, 30);
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 4;
            kryptonLabel1.Values.Text = "ASSISTENTE ADMINISTRATIVO/A";
            // 
            // BtnPhoto
            // 
            BtnPhoto.Cursor = Cursors.Hand;
            BtnPhoto.Location = new Point(384, 314);
            BtnPhoto.Name = "BtnPhoto";
            BtnPhoto.Size = new Size(46, 25);
            BtnPhoto.TabIndex = 43;
            BtnPhoto.Values.DropDownArrowColor = Color.Empty;
            BtnPhoto.Values.Text = "";
            BtnPhoto.Click += btnPhoto_Click;
            // 
            // kryptonLabel28
            // 
            kryptonLabel28.Location = new Point(336, 319);
            kryptonLabel28.Name = "kryptonLabel28";
            kryptonLabel28.Size = new Size(48, 20);
            kryptonLabel28.TabIndex = 42;
            kryptonLabel28.Values.Text = "FOTO :";
            // 
            // BtnCV
            // 
            BtnCV.Cursor = Cursors.Hand;
            BtnCV.Location = new Point(576, 314);
            BtnCV.Name = "BtnCV";
            BtnCV.Size = new Size(54, 25);
            BtnCV.TabIndex = 40;
            BtnCV.Values.DropDownArrowColor = Color.Empty;
            BtnCV.Values.Text = "";
            BtnCV.Click += btnCV_Click;
            // 
            // BtnBI
            // 
            BtnBI.Cursor = Cursors.Hand;
            BtnBI.Location = new Point(484, 314);
            BtnBI.Name = "BtnBI";
            BtnBI.Size = new Size(48, 25);
            BtnBI.TabIndex = 39;
            BtnBI.Values.DropDownArrowColor = Color.Empty;
            BtnBI.Values.Text = "";
            BtnBI.Click += btnBI_Click;
            // 
            // DtpDateOfBirth
            // 
            DtpDateOfBirth.Format = DateTimePickerFormat.Short;
            DtpDateOfBirth.Location = new Point(336, 239);
            DtpDateOfBirth.Name = "DtpDateOfBirth";
            DtpDateOfBirth.Size = new Size(115, 21);
            DtpDateOfBirth.TabIndex = 37;
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(336, 272);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(294, 23);
            TxtPhone.TabIndex = 36;
            TxtPhone.Validating += TxtPhone_Validating;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(336, 203);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(294, 23);
            TxtEmail.TabIndex = 34;
            TxtEmail.Validating += TxtEmail_Validating;
            // 
            // TxtFullName
            // 
            TxtFullName.Location = new Point(336, 160);
            TxtFullName.Name = "TxtFullName";
            TxtFullName.Size = new Size(294, 23);
            TxtFullName.TabIndex = 33;
            TxtFullName.Validating += txtFullName_Validating;
            // 
            // TxtUserName
            // 
            TxtUserName.Location = new Point(336, 124);
            TxtUserName.Name = "TxtUserName";
            TxtUserName.Size = new Size(294, 23);
            TxtUserName.TabIndex = 32;
            TxtUserName.Validating += txtUserName_Validating;
            // 
            // kryptonLabel27
            // 
            kryptonLabel27.Location = new Point(179, 402);
            kryptonLabel27.Name = "kryptonLabel27";
            kryptonLabel27.Size = new Size(108, 20);
            kryptonLabel27.TabIndex = 31;
            kryptonLabel27.Values.Text = "BI - EMITIDO EM :";
            // 
            // kryptonLabel26
            // 
            kryptonLabel26.Location = new Point(542, 319);
            kryptonLabel26.Name = "kryptonLabel26";
            kryptonLabel26.Size = new Size(32, 20);
            kryptonLabel26.TabIndex = 27;
            kryptonLabel26.Values.Text = "CV :";
            // 
            // kryptonLabel25
            // 
            kryptonLabel25.Location = new Point(451, 319);
            kryptonLabel25.Name = "kryptonLabel25";
            kryptonLabel25.Size = new Size(27, 20);
            kryptonLabel25.TabIndex = 26;
            kryptonLabel25.Values.Text = "BI :";
            // 
            // kryptonLabel19
            // 
            kryptonLabel19.Location = new Point(179, 239);
            kryptonLabel19.Name = "kryptonLabel19";
            kryptonLabel19.Size = new Size(146, 20);
            kryptonLabel19.TabIndex = 25;
            kryptonLabel19.Values.Text = "DATA DE NASCIMENTO :";
            // 
            // kryptonLabel20
            // 
            kryptonLabel20.Location = new Point(179, 275);
            kryptonLabel20.Name = "kryptonLabel20";
            kryptonLabel20.Size = new Size(72, 20);
            kryptonLabel20.TabIndex = 24;
            kryptonLabel20.Values.Text = "TELEFONE :";
            // 
            // kryptonLabel21
            // 
            kryptonLabel21.Location = new Point(179, 206);
            kryptonLabel21.Name = "kryptonLabel21";
            kryptonLabel21.Size = new Size(51, 20);
            kryptonLabel21.TabIndex = 23;
            kryptonLabel21.Values.Text = "EMAIL :";
            // 
            // kryptonLabel22
            // 
            kryptonLabel22.Location = new Point(480, 237);
            kryptonLabel22.Name = "kryptonLabel22";
            kryptonLabel22.Size = new Size(46, 20);
            kryptonLabel22.TabIndex = 22;
            kryptonLabel22.Values.Text = "SEXO :";
            // 
            // kryptonLabel23
            // 
            kryptonLabel23.Location = new Point(179, 160);
            kryptonLabel23.Name = "kryptonLabel23";
            kryptonLabel23.Size = new Size(115, 20);
            kryptonLabel23.TabIndex = 21;
            kryptonLabel23.Values.Text = "NOME COMPLETO:";
            // 
            // kryptonLabel24
            // 
            kryptonLabel24.Location = new Point(179, 124);
            kryptonLabel24.Name = "kryptonLabel24";
            kryptonLabel24.Size = new Size(68, 20);
            kryptonLabel24.TabIndex = 20;
            kryptonLabel24.Values.Text = "USUÁRIO :";
            // 
            // CbSex
            // 
            CbSex.Cursor = Cursors.Hand;
            CbSex.DropDownStyle = ComboBoxStyle.DropDownList;
            CbSex.DropDownWidth = 75;
            CbSex.Items.AddRange(new object[] { "MASCULINO", "FEMININO", "OUTRO" });
            CbSex.Location = new Point(527, 237);
            CbSex.Name = "CbSex";
            CbSex.Size = new Size(103, 22);
            CbSex.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            CbSex.TabIndex = 44;
            // 
            // TxtRole
            // 
            TxtRole.AlwaysActive = false;
            TxtRole.Enabled = false;
            TxtRole.Location = new Point(703, 77);
            TxtRole.Name = "TxtRole";
            TxtRole.ReadOnly = true;
            TxtRole.ShortcutsEnabled = false;
            TxtRole.Size = new Size(181, 23);
            TxtRole.TabIndex = 45;
            TxtRole.Text = "ASSISTENTE ADMINISTRATIVO/A";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(641, 79);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(57, 20);
            kryptonLabel2.TabIndex = 46;
            kryptonLabel2.Values.Text = "CARGO :";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(336, 448);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '●';
            TxtPassword.Size = new Size(294, 23);
            TxtPassword.TabIndex = 48;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(180, 448);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(106, 20);
            kryptonLabel3.TabIndex = 47;
            kryptonLabel3.Values.Text = "PALAVRA PASSE :";
            // 
            // DtpIssuedOn
            // 
            DtpIssuedOn.Format = DateTimePickerFormat.Short;
            DtpIssuedOn.Location = new Point(336, 402);
            DtpIssuedOn.Name = "DtpIssuedOn";
            DtpIssuedOn.Size = new Size(115, 21);
            DtpIssuedOn.TabIndex = 49;
            // 
            // DtpValidUntil
            // 
            DtpValidUntil.Format = DateTimePickerFormat.Short;
            DtpValidUntil.Location = new Point(536, 402);
            DtpValidUntil.Name = "DtpValidUntil";
            DtpValidUntil.Size = new Size(94, 21);
            DtpValidUntil.TabIndex = 51;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(457, 402);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(83, 20);
            kryptonLabel4.TabIndex = 50;
            kryptonLabel4.Values.Text = "VALIDO ATÉ :";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "FOTO";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "BI";
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "CV";
            // 
            // EpUser
            // 
            EpUser.ContainerControl = this;
            // 
            // EpFullName
            // 
            EpFullName.ContainerControl = this;
            // 
            // TxtNBI
            // 
            TxtNBI.Location = new Point(336, 356);
            TxtNBI.MaxLength = 14;
            TxtNBI.Name = "TxtNBI";
            TxtNBI.Size = new Size(294, 23);
            TxtNBI.TabIndex = 53;
            TxtNBI.Validating += TxtNBI_Validating;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(179, 359);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(169, 20);
            kryptonLabel5.TabIndex = 52;
            kryptonLabel5.Values.Text = "Nº BILHETE DE IDENTIDADE :";
            // 
            // EpEmail
            // 
            EpEmail.ContainerControl = this;
            // 
            // EpPhone
            // 
            EpPhone.ContainerControl = this;
            // 
            // EpNBI
            // 
            EpNBI.ContainerControl = this;
            // 
            // AdminRegisterAdministrativeAssistant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 567);
            Controls.Add(TxtNBI);
            Controls.Add(kryptonLabel5);
            Controls.Add(DtpValidUntil);
            Controls.Add(kryptonLabel4);
            Controls.Add(DtpIssuedOn);
            Controls.Add(TxtPassword);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(TxtRole);
            Controls.Add(CbSex);
            Controls.Add(BtnPhoto);
            Controls.Add(kryptonPanel1);
            Controls.Add(kryptonLabel28);
            Controls.Add(BtnRegister);
            Controls.Add(BtnCV);
            Controls.Add(BtnBI);
            Controls.Add(DtpDateOfBirth);
            Controls.Add(TxtPhone);
            Controls.Add(kryptonLabel24);
            Controls.Add(TxtEmail);
            Controls.Add(kryptonLabel23);
            Controls.Add(TxtFullName);
            Controls.Add(kryptonLabel22);
            Controls.Add(TxtUserName);
            Controls.Add(kryptonLabel21);
            Controls.Add(kryptonLabel27);
            Controls.Add(kryptonLabel20);
            Controls.Add(kryptonLabel26);
            Controls.Add(kryptonLabel19);
            Controls.Add(kryptonLabel25);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminRegisterAdministrativeAssistant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterAdministrativeAssistant";
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CbSex).EndInit();
            ((System.ComponentModel.ISupportInitialize)EpUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)EpFullName).EndInit();
            ((System.ComponentModel.ISupportInitialize)EpEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)EpPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)EpNBI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonButton BtnRegister;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton BtnPhoto;
        private Krypton.Toolkit.KryptonLabel kryptonLabel28;
        private Krypton.Toolkit.KryptonButton BtnCV;
        private Krypton.Toolkit.KryptonButton BtnBI;
        private Krypton.Toolkit.KryptonDateTimePicker DtpDateOfBirth;
        private Krypton.Toolkit.KryptonTextBox TxtPhone;
        private Krypton.Toolkit.KryptonTextBox TxtEmail;
        private Krypton.Toolkit.KryptonTextBox TxtFullName;
        private Krypton.Toolkit.KryptonTextBox TxtUserName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel27;
        private Krypton.Toolkit.KryptonLabel kryptonLabel26;
        private Krypton.Toolkit.KryptonLabel kryptonLabel25;
        private Krypton.Toolkit.KryptonLabel kryptonLabel19;
        private Krypton.Toolkit.KryptonLabel kryptonLabel20;
        private Krypton.Toolkit.KryptonLabel kryptonLabel21;
        private Krypton.Toolkit.KryptonLabel kryptonLabel22;
        private Krypton.Toolkit.KryptonLabel kryptonLabel23;
        private Krypton.Toolkit.KryptonLabel kryptonLabel24;
        private Krypton.Toolkit.KryptonComboBox CbSex;
        private Krypton.Toolkit.KryptonTextBox TxtRole;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox TxtPassword;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonDateTimePicker DtpIssuedOn;
        private Krypton.Toolkit.KryptonDateTimePicker DtpValidUntil;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
        private ErrorProvider EpUser;
        private ErrorProvider EpFullName;
        private Krypton.Toolkit.KryptonTextBox TxtNBI;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ErrorProvider EpEmail;
        private ErrorProvider EpPhone;
        private ErrorProvider EpNBI;
    }
}