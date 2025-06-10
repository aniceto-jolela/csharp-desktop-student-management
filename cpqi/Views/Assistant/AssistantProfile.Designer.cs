namespace cpqi.Views.Assistant
{
    partial class AssistantProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssistantProfile));
            splitContainer1 = new SplitContainer();
            LblValidUntil = new Krypton.Toolkit.KryptonLabel();
            LblIssuedOn = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            LblNBI = new Krypton.Toolkit.KryptonLabel();
            PbPhoto = new Krypton.Toolkit.KryptonPictureBox();
            LblRole = new Krypton.Toolkit.KryptonLabel();
            LblPhone = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            LblEmail = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            LblBirthDay = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel15 = new Krypton.Toolkit.KryptonLabel();
            LblSex = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            LblFullName = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            LblUser = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel18 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbPhoto).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.Window;
            splitContainer1.Panel1.Controls.Add(LblValidUntil);
            splitContainer1.Panel1.Controls.Add(LblIssuedOn);
            splitContainer1.Panel1.Controls.Add(kryptonLabel6);
            splitContainer1.Panel1.Controls.Add(kryptonLabel4);
            splitContainer1.Panel1.Controls.Add(LblNBI);
            splitContainer1.Panel1.Controls.Add(PbPhoto);
            splitContainer1.Panel1.Controls.Add(LblRole);
            splitContainer1.Panel1.RightToLeft = RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.GradientActiveCaption;
            splitContainer1.Panel2.Controls.Add(LblPhone);
            splitContainer1.Panel2.Controls.Add(kryptonLabel11);
            splitContainer1.Panel2.Controls.Add(LblEmail);
            splitContainer1.Panel2.Controls.Add(kryptonLabel9);
            splitContainer1.Panel2.Controls.Add(LblBirthDay);
            splitContainer1.Panel2.Controls.Add(kryptonLabel15);
            splitContainer1.Panel2.Controls.Add(LblSex);
            splitContainer1.Panel2.Controls.Add(kryptonLabel7);
            splitContainer1.Panel2.Controls.Add(LblFullName);
            splitContainer1.Panel2.Controls.Add(kryptonLabel5);
            splitContainer1.Panel2.Controls.Add(LblUser);
            splitContainer1.Panel2.Controls.Add(kryptonLabel18);
            splitContainer1.Panel2.Controls.Add(kryptonLabel2);
            splitContainer1.Panel2.RightToLeft = RightToLeft.No;
            splitContainer1.RightToLeft = RightToLeft.No;
            splitContainer1.Size = new Size(907, 453);
            splitContainer1.SplitterDistance = 383;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 8;
            // 
            // LblValidUntil
            // 
            LblValidUntil.Location = new Point(284, 403);
            LblValidUntil.Name = "LblValidUntil";
            LblValidUntil.Size = new Size(73, 20);
            LblValidUntil.TabIndex = 57;
            LblValidUntil.Values.Text = "12/12/2025";
            // 
            // LblIssuedOn
            // 
            LblIssuedOn.Location = new Point(99, 403);
            LblIssuedOn.Name = "LblIssuedOn";
            LblIssuedOn.Size = new Size(73, 20);
            LblIssuedOn.TabIndex = 56;
            LblIssuedOn.Values.Text = "08/12/2025";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(207, 403);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(83, 20);
            kryptonLabel6.TabIndex = 55;
            kryptonLabel6.Values.Text = "VALIDO ATÉ :";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(20, 403);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(86, 20);
            kryptonLabel4.TabIndex = 53;
            kryptonLabel4.Values.Text = "EMITIDO EM :";
            // 
            // LblNBI
            // 
            LblNBI.Location = new Point(88, 334);
            LblNBI.Name = "LblNBI";
            LblNBI.Size = new Size(202, 37);
            LblNBI.StateNormal.ShortText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNBI.TabIndex = 23;
            LblNBI.Values.Text = "123456789LA123";
            // 
            // PbPhoto
            // 
            PbPhoto.Image = Properties.Resources.administrator;
            PbPhoto.Location = new Point(79, 53);
            PbPhoto.Name = "PbPhoto";
            PbPhoto.Size = new Size(224, 235);
            PbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            PbPhoto.TabIndex = 6;
            PbPhoto.TabStop = false;
            // 
            // LblRole
            // 
            LblRole.Location = new Point(114, 308);
            LblRole.Name = "LblRole";
            LblRole.Size = new Size(152, 20);
            LblRole.StateNormal.ShortText.Color1 = Color.Red;
            LblRole.TabIndex = 22;
            LblRole.Values.Text = "Assistent Admininistrativo";
            // 
            // LblPhone
            // 
            LblPhone.Location = new Point(190, 282);
            LblPhone.Name = "LblPhone";
            LblPhone.Size = new Size(102, 20);
            LblPhone.TabIndex = 16;
            LblPhone.Values.Text = "+244 935948572";
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Location = new Point(91, 282);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new Size(72, 20);
            kryptonLabel11.TabIndex = 15;
            kryptonLabel11.Values.Text = "TELEFONE :";
            // 
            // LblEmail
            // 
            LblEmail.Location = new Point(190, 249);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(116, 20);
            LblEmail.TabIndex = 14;
            LblEmail.Values.Text = "miguel@gmail.com";
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(91, 249);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(51, 20);
            kryptonLabel9.TabIndex = 13;
            kryptonLabel9.Values.Text = "EMAIL :";
            // 
            // LblBirthDay
            // 
            LblBirthDay.Location = new Point(249, 334);
            LblBirthDay.Name = "LblBirthDay";
            LblBirthDay.Size = new Size(73, 20);
            LblBirthDay.TabIndex = 20;
            LblBirthDay.Values.Text = "03/12/1839";
            // 
            // kryptonLabel15
            // 
            kryptonLabel15.Location = new Point(91, 334);
            kryptonLabel15.Name = "kryptonLabel15";
            kryptonLabel15.Size = new Size(146, 20);
            kryptonLabel15.TabIndex = 19;
            kryptonLabel15.Values.Text = "DATA DE NASCIMENTO :";
            kryptonLabel15.Click += kryptonLabel15_Click;
            // 
            // LblSex
            // 
            LblSex.Location = new Point(190, 216);
            LblSex.Name = "LblSex";
            LblSex.Size = new Size(22, 20);
            LblSex.TabIndex = 12;
            LblSex.Values.Text = "M";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(91, 216);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(46, 20);
            kryptonLabel7.TabIndex = 11;
            kryptonLabel7.Values.Text = "SEXO :";
            // 
            // LblFullName
            // 
            LblFullName.Location = new Point(190, 183);
            LblFullName.Name = "LblFullName";
            LblFullName.Size = new Size(95, 20);
            LblFullName.TabIndex = 10;
            LblFullName.Values.Text = "Miguel Da Sílva";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(91, 183);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(52, 20);
            kryptonLabel5.TabIndex = 9;
            kryptonLabel5.Values.Text = "NOME :";
            // 
            // LblUser
            // 
            LblUser.Location = new Point(190, 150);
            LblUser.Name = "LblUser";
            LblUser.Size = new Size(48, 20);
            LblUser.TabIndex = 8;
            LblUser.Values.Text = "miguel";
            // 
            // kryptonLabel18
            // 
            kryptonLabel18.Location = new Point(218, 53);
            kryptonLabel18.Name = "kryptonLabel18";
            kryptonLabel18.Size = new Size(104, 20);
            kryptonLabel18.TabIndex = 3;
            kryptonLabel18.Values.Text = "DADOS PESSOAL";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(91, 150);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(68, 20);
            kryptonLabel2.TabIndex = 7;
            kryptonLabel2.Values.Text = "USUÁRIO :";
            // 
            // AssistantProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 453);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AssistantProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssistantProfile";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Krypton.Toolkit.KryptonLabel LblValidUntil;
        private Krypton.Toolkit.KryptonLabel LblIssuedOn;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel LblNBI;
        private Krypton.Toolkit.KryptonLabel LblRole;
        private Krypton.Toolkit.KryptonLabel LblBirthDay;
        private Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private Krypton.Toolkit.KryptonLabel LblPhone;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonLabel LblEmail;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel LblSex;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel LblFullName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel LblUser;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonPictureBox PbPhoto;
        private Krypton.Toolkit.KryptonLabel kryptonLabel18;
    }
}