namespace cpqi.Views.Teacher
{
    partial class TeacherHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherHome));
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            lblFullName = new Label();
            PbProfile = new Krypton.Toolkit.KryptonPictureBox();
            PbLogout = new Krypton.Toolkit.KryptonPictureBox();
            lbl_datatime = new Label();
            kryptonNavigator1 = new Krypton.Navigator.KryptonNavigator();
            kryptonPage1 = new Krypton.Navigator.KryptonPage();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonPage2 = new Krypton.Navigator.KryptonPage();
            kryptonPage3 = new Krypton.Navigator.KryptonPage();
            kryptonPictureBox3 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonButton8 = new Krypton.Toolkit.KryptonButton();
            kryptonButton7 = new Krypton.Toolkit.KryptonButton();
            kryptonButton6 = new Krypton.Toolkit.KryptonButton();
            BtnRule = new Krypton.Toolkit.KryptonButton();
            kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            BtnViewAdminAssistant = new Krypton.Toolkit.KryptonButton();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            BtnPag3 = new Krypton.Toolkit.KryptonButton();
            BtnPag2 = new Krypton.Toolkit.KryptonButton();
            BtnPag1 = new Krypton.Toolkit.KryptonButton();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonPictureBox2 = new Krypton.Toolkit.KryptonPictureBox();
            BtnRStudent = new Krypton.Toolkit.KryptonButton();
            BtnRTeacher = new Krypton.Toolkit.KryptonButton();
            BtnRAssistant = new Krypton.Toolkit.KryptonButton();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonNavigator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPage1).BeginInit();
            kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPage2).BeginInit();
            kryptonPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPage3).BeginInit();
            kryptonPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(lblFullName);
            kryptonPanel2.Controls.Add(PbProfile);
            kryptonPanel2.Controls.Add(PbLogout);
            kryptonPanel2.Controls.Add(lbl_datatime);
            kryptonPanel2.Dock = DockStyle.Top;
            kryptonPanel2.Location = new Point(200, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1147, 36);
            kryptonPanel2.StateNormal.Color1 = SystemColors.ButtonFace;
            kryptonPanel2.TabIndex = 21;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(16, 10);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(61, 15);
            lblFullName.TabIndex = 21;
            lblFullName.Text = "Full Name";
            // 
            // PbProfile
            // 
            PbProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PbProfile.Cursor = Cursors.Hand;
            PbProfile.Image = Properties.Resources.administrator;
            PbProfile.Location = new Point(1038, 3);
            PbProfile.Name = "PbProfile";
            PbProfile.Size = new Size(33, 30);
            PbProfile.SizeMode = PictureBoxSizeMode.Zoom;
            PbProfile.TabIndex = 20;
            PbProfile.TabStop = false;
            PbProfile.Click += PbProfile_Click;
            // 
            // PbLogout
            // 
            PbLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PbLogout.Cursor = Cursors.Hand;
            PbLogout.Image = (Image)resources.GetObject("PbLogout.Image");
            PbLogout.Location = new Point(1100, 5);
            PbLogout.Name = "PbLogout";
            PbLogout.Size = new Size(19, 28);
            PbLogout.SizeMode = PictureBoxSizeMode.Zoom;
            PbLogout.TabIndex = 19;
            PbLogout.TabStop = false;
            PbLogout.Click += PbLogout_Click;
            // 
            // lbl_datatime
            // 
            lbl_datatime.Anchor = AnchorStyles.Top;
            lbl_datatime.AutoSize = true;
            lbl_datatime.Font = new Font("Segoe UI", 12F);
            lbl_datatime.Location = new Point(548, 8);
            lbl_datatime.Name = "lbl_datatime";
            lbl_datatime.Size = new Size(77, 21);
            lbl_datatime.TabIndex = 13;
            lbl_datatime.Text = "Date time";
            // 
            // kryptonNavigator1
            // 
            kryptonNavigator1.ControlKryptonFormFeatures = false;
            kryptonNavigator1.Dock = DockStyle.Fill;
            kryptonNavigator1.Location = new Point(200, 0);
            kryptonNavigator1.NavigatorMode = Krypton.Navigator.NavigatorMode.Panel;
            kryptonNavigator1.Owner = null;
            kryptonNavigator1.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
            kryptonNavigator1.Pages.AddRange(new Krypton.Navigator.KryptonPage[] { kryptonPage1, kryptonPage2, kryptonPage3 });
            kryptonNavigator1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonNavigator1.SelectedIndex = 2;
            kryptonNavigator1.Size = new Size(1147, 398);
            kryptonNavigator1.StateNormal.Panel.Color1 = SystemColors.Window;
            kryptonNavigator1.TabIndex = 19;
            kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            kryptonPage1.AutoHiddenSlideSize = new Size(200, 200);
            kryptonPage1.Controls.Add(kryptonLabel1);
            kryptonPage1.Flags = 65534;
            kryptonPage1.LastVisibleSet = true;
            kryptonPage1.MinimumSize = new Size(150, 50);
            kryptonPage1.Name = "kryptonPage1";
            kryptonPage1.Size = new Size(1141, 416);
            kryptonPage1.Text = "kryptonPage1";
            kryptonPage1.ToolTipTitle = "Page ToolTip";
            kryptonPage1.UniqueName = "22edfcd6eaf54dc59b64709d2eb3d885";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(526, 198);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(89, 20);
            kryptonLabel1.TabIndex = 18;
            kryptonLabel1.Values.Text = "DASHBOARDS";
            // 
            // kryptonPage2
            // 
            kryptonPage2.AutoHiddenSlideSize = new Size(200, 200);
            kryptonPage2.Controls.Add(kryptonPictureBox2);
            kryptonPage2.Controls.Add(BtnRAssistant);
            kryptonPage2.Controls.Add(BtnRStudent);
            kryptonPage2.Controls.Add(kryptonLabel2);
            kryptonPage2.Controls.Add(BtnRTeacher);
            kryptonPage2.Flags = 65534;
            kryptonPage2.LastVisibleSet = true;
            kryptonPage2.MinimumSize = new Size(150, 50);
            kryptonPage2.Name = "kryptonPage2";
            kryptonPage2.Size = new Size(1147, 398);
            kryptonPage2.Text = "kryptonPage2";
            kryptonPage2.ToolTipTitle = "Page ToolTip";
            kryptonPage2.UniqueName = "647bbbb7977846a38ff6ff598724f2fd";
            // 
            // kryptonPage3
            // 
            kryptonPage3.AutoHiddenSlideSize = new Size(200, 200);
            kryptonPage3.Controls.Add(kryptonPictureBox3);
            kryptonPage3.Controls.Add(kryptonLabel4);
            kryptonPage3.Controls.Add(kryptonButton8);
            kryptonPage3.Controls.Add(kryptonButton7);
            kryptonPage3.Controls.Add(kryptonButton6);
            kryptonPage3.Controls.Add(BtnRule);
            kryptonPage3.Controls.Add(kryptonButton4);
            kryptonPage3.Controls.Add(kryptonButton3);
            kryptonPage3.Controls.Add(kryptonButton2);
            kryptonPage3.Controls.Add(BtnViewAdminAssistant);
            kryptonPage3.Flags = 65534;
            kryptonPage3.LastVisibleSet = true;
            kryptonPage3.MinimumSize = new Size(150, 50);
            kryptonPage3.Name = "kryptonPage3";
            kryptonPage3.Size = new Size(1147, 398);
            kryptonPage3.Text = "kryptonPage3";
            kryptonPage3.ToolTipTitle = "Page ToolTip";
            kryptonPage3.UniqueName = "b8fac60cccba4470973cc743191de2c6";
            // 
            // kryptonPictureBox3
            // 
            kryptonPictureBox3.Image = (Image)resources.GetObject("kryptonPictureBox3.Image");
            kryptonPictureBox3.Location = new Point(16, 78);
            kryptonPictureBox3.Name = "kryptonPictureBox3";
            kryptonPictureBox3.Size = new Size(22, 22);
            kryptonPictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBox3.TabIndex = 38;
            kryptonPictureBox3.TabStop = false;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(44, 70);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(122, 32);
            kryptonLabel4.StateNormal.ShortText.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 37;
            kryptonLabel4.Values.Text = "VISUALIZAR";
            // 
            // kryptonButton8
            // 
            kryptonButton8.Cursor = Cursors.Hand;
            kryptonButton8.Location = new Point(619, 292);
            kryptonButton8.Name = "kryptonButton8";
            kryptonButton8.Size = new Size(205, 79);
            kryptonButton8.TabIndex = 36;
            kryptonButton8.Values.DropDownArrowColor = Color.Empty;
            kryptonButton8.Values.Image = Properties.Resources.uis__grid;
            kryptonButton8.Values.Text = "PAUTAS";
            // 
            // kryptonButton7
            // 
            kryptonButton7.Cursor = Cursors.Hand;
            kryptonButton7.Location = new Point(367, 292);
            kryptonButton7.Name = "kryptonButton7";
            kryptonButton7.Size = new Size(219, 79);
            kryptonButton7.TabIndex = 35;
            kryptonButton7.Values.DropDownArrowColor = Color.Empty;
            kryptonButton7.Values.Image = Properties.Resources.healthicons__health_worker_form;
            kryptonButton7.Values.Text = "PRESENÇA";
            // 
            // kryptonButton6
            // 
            kryptonButton6.Location = new Point(849, 292);
            kryptonButton6.Name = "kryptonButton6";
            kryptonButton6.Size = new Size(208, 79);
            kryptonButton6.TabIndex = 34;
            kryptonButton6.Values.DropDownArrowColor = Color.Empty;
            kryptonButton6.Values.Image = Properties.Resources.basil__invoice_solid;
            kryptonButton6.Values.Text = "FATURAS";
            // 
            // BtnRule
            // 
            BtnRule.Cursor = Cursors.Hand;
            BtnRule.Location = new Point(16, 292);
            BtnRule.Name = "BtnRule";
            BtnRule.Size = new Size(316, 79);
            BtnRule.TabIndex = 33;
            BtnRule.Values.DropDownArrowColor = Color.Empty;
            BtnRule.Values.Image = Properties.Resources.marketeq__work;
            BtnRule.Values.Text = "CARGOS";
            // 
            // kryptonButton4
            // 
            kryptonButton4.Cursor = Cursors.Hand;
            kryptonButton4.Location = new Point(619, 162);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.Size = new Size(205, 79);
            kryptonButton4.TabIndex = 32;
            kryptonButton4.Values.DropDownArrowColor = Color.Empty;
            kryptonButton4.Values.Image = Properties.Resources.medical_icon__i_registration;
            kryptonButton4.Values.Text = "FICHA DE INSCRIÇOES";
            // 
            // kryptonButton3
            // 
            kryptonButton3.Location = new Point(849, 162);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.Size = new Size(208, 79);
            kryptonButton3.TabIndex = 31;
            kryptonButton3.Values.DropDownArrowColor = Color.Empty;
            kryptonButton3.Values.Image = Properties.Resources.arcticons__classchartsstudents;
            kryptonButton3.Values.Text = "ALUNOS";
            // 
            // kryptonButton2
            // 
            kryptonButton2.Cursor = Cursors.Hand;
            kryptonButton2.Location = new Point(367, 162);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(219, 79);
            kryptonButton2.TabIndex = 30;
            kryptonButton2.Values.DropDownArrowColor = Color.Empty;
            kryptonButton2.Values.Image = Properties.Resources.noto__teacher_dark_skin_tone;
            kryptonButton2.Values.Text = "PROFESSORES";
            // 
            // BtnViewAdminAssistant
            // 
            BtnViewAdminAssistant.Cursor = Cursors.Hand;
            BtnViewAdminAssistant.Location = new Point(16, 162);
            BtnViewAdminAssistant.Name = "BtnViewAdminAssistant";
            BtnViewAdminAssistant.Size = new Size(316, 79);
            BtnViewAdminAssistant.TabIndex = 29;
            BtnViewAdminAssistant.Values.DropDownArrowColor = Color.Empty;
            BtnViewAdminAssistant.Values.Image = Properties.Resources.flat_color_icons__assistant;
            BtnViewAdminAssistant.Values.Text = "ASSISTENTES ADMINISTRATIVO(A)S";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(BtnPag3);
            kryptonPanel1.Controls.Add(BtnPag2);
            kryptonPanel1.Controls.Add(BtnPag1);
            kryptonPanel1.Controls.Add(kryptonPictureBox1);
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(200, 398);
            kryptonPanel1.TabIndex = 20;
            // 
            // BtnPag3
            // 
            BtnPag3.Cursor = Cursors.Hand;
            BtnPag3.Location = new Point(3, 247);
            BtnPag3.Name = "BtnPag3";
            BtnPag3.Size = new Size(194, 51);
            BtnPag3.TabIndex = 16;
            BtnPag3.Values.DropDownArrowColor = Color.Empty;
            BtnPag3.Values.Text = "VISUALIZAR";
            BtnPag3.Click += BtnPag3_Click;
            // 
            // BtnPag2
            // 
            BtnPag2.Cursor = Cursors.Hand;
            BtnPag2.Location = new Point(3, 191);
            BtnPag2.Name = "BtnPag2";
            BtnPag2.Size = new Size(194, 50);
            BtnPag2.TabIndex = 15;
            BtnPag2.Values.DropDownArrowColor = Color.Empty;
            BtnPag2.Values.Text = "REGISTRAR";
            BtnPag2.Click += BtnPag2_Click;
            // 
            // BtnPag1
            // 
            BtnPag1.Cursor = Cursors.Hand;
            BtnPag1.Location = new Point(3, 139);
            BtnPag1.Name = "BtnPag1";
            BtnPag1.Size = new Size(194, 46);
            BtnPag1.TabIndex = 1;
            BtnPag1.Values.DropDownArrowColor = Color.Empty;
            BtnPag1.Values.Text = "INICIO";
            BtnPag1.Click += BtnPag1_Click;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Image = Properties.Resources.cpqi;
            kryptonPictureBox1.Location = new Point(25, 3);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(152, 131);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            kryptonPictureBox1.TabIndex = 0;
            kryptonPictureBox1.TabStop = false;
            // 
            // kryptonPictureBox2
            // 
            kryptonPictureBox2.Image = Properties.Resources.mdi__register_outline;
            kryptonPictureBox2.Location = new Point(16, 76);
            kryptonPictureBox2.Name = "kryptonPictureBox2";
            kryptonPictureBox2.Size = new Size(22, 22);
            kryptonPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBox2.TabIndex = 25;
            kryptonPictureBox2.TabStop = false;
            // 
            // BtnRStudent
            // 
            BtnRStudent.Cursor = Cursors.Hand;
            BtnRStudent.Location = new Point(616, 162);
            BtnRStudent.Name = "BtnRStudent";
            BtnRStudent.Size = new Size(171, 79);
            BtnRStudent.TabIndex = 26;
            BtnRStudent.Values.DropDownArrowColor = Color.Empty;
            BtnRStudent.Values.Image = (Image)resources.GetObject("BtnRStudent.Values.Image");
            BtnRStudent.Values.Text = "ALUNO";
            // 
            // BtnRTeacher
            // 
            BtnRTeacher.Cursor = Cursors.Hand;
            BtnRTeacher.Location = new Point(343, 162);
            BtnRTeacher.Name = "BtnRTeacher";
            BtnRTeacher.Size = new Size(243, 79);
            BtnRTeacher.TabIndex = 24;
            BtnRTeacher.Values.DropDownArrowColor = Color.Empty;
            BtnRTeacher.Values.Image = Properties.Resources.wpf__add_user;
            BtnRTeacher.Values.Text = "PROFESSOR";
            // 
            // BtnRAssistant
            // 
            BtnRAssistant.Cursor = Cursors.Hand;
            BtnRAssistant.Location = new Point(16, 162);
            BtnRAssistant.Name = "BtnRAssistant";
            BtnRAssistant.Size = new Size(292, 79);
            BtnRAssistant.TabIndex = 22;
            BtnRAssistant.Values.DropDownArrowColor = Color.Empty;
            BtnRAssistant.Values.Image = Properties.Resources.mdi__user_tie;
            BtnRAssistant.Values.Text = "ASSISTENTE ADMINISTRATIVO(A)";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(44, 70);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(115, 32);
            kryptonLabel2.StateNormal.ShortText.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 23;
            kryptonLabel2.Values.Text = "REGISTRAR";
            // 
            // TeacherHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 398);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonNavigator1);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TeacherHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherHome";
            WindowState = FormWindowState.Maximized;
            FormClosing += TeacherHome_FormClosing;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonNavigator1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPage1).EndInit();
            kryptonPage1.ResumeLayout(false);
            kryptonPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPage2).EndInit();
            kryptonPage2.ResumeLayout(false);
            kryptonPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPage3).EndInit();
            kryptonPage3.ResumeLayout(false);
            kryptonPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Label lblFullName;
        private Label lbl_datatime;
        private Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton BtnPag3;
        private Krypton.Toolkit.KryptonPictureBox PbProfile;
        private Krypton.Toolkit.KryptonPictureBox PbLogout;
        private Krypton.Toolkit.KryptonButton BtnPag2;
        private Krypton.Toolkit.KryptonButton BtnPag1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Navigator.KryptonPage kryptonPage1;
        private Krypton.Navigator.KryptonPage kryptonPage2;
        private Krypton.Navigator.KryptonPage kryptonPage3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonButton kryptonButton8;
        private Krypton.Toolkit.KryptonButton kryptonButton7;
        private Krypton.Toolkit.KryptonButton kryptonButton6;
        private Krypton.Toolkit.KryptonButton BtnRule;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton BtnViewAdminAssistant;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox2;
        private Krypton.Toolkit.KryptonButton BtnRAssistant;
        private Krypton.Toolkit.KryptonButton BtnRStudent;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton BtnRTeacher;
    }
}