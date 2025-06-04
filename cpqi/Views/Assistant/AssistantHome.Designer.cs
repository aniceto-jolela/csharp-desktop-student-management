namespace cpqi.Views.Assistant
{
    partial class AssistantHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssistantHome));
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            lblFullName = new Label();
            PbProfile = new Krypton.Toolkit.KryptonPictureBox();
            PbLogout = new Krypton.Toolkit.KryptonPictureBox();
            lbl_datatime = new Label();
            kryptonNavigator1 = new Krypton.Navigator.KryptonNavigator();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            BtnPag3 = new Krypton.Toolkit.KryptonButton();
            BtnPag2 = new Krypton.Toolkit.KryptonButton();
            BtnPag1 = new Krypton.Toolkit.KryptonButton();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonNavigator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
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
            kryptonPanel2.Size = new Size(1127, 36);
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
            PbProfile.Image = (Image)resources.GetObject("PbProfile.Image");
            PbProfile.Location = new Point(2048, 3);
            PbProfile.Name = "PbProfile";
            PbProfile.Size = new Size(33, 30);
            PbProfile.SizeMode = PictureBoxSizeMode.Zoom;
            PbProfile.TabIndex = 20;
            PbProfile.TabStop = false;
            // 
            // PbLogout
            // 
            PbLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PbLogout.Cursor = Cursors.Hand;
            PbLogout.Image = (Image)resources.GetObject("PbLogout.Image");
            PbLogout.Location = new Point(2110, 5);
            PbLogout.Name = "PbLogout";
            PbLogout.Size = new Size(19, 28);
            PbLogout.SizeMode = PictureBoxSizeMode.Zoom;
            PbLogout.TabIndex = 19;
            PbLogout.TabStop = false;
            // 
            // lbl_datatime
            // 
            lbl_datatime.Anchor = AnchorStyles.Top;
            lbl_datatime.AutoSize = true;
            lbl_datatime.Font = new Font("Segoe UI", 12F);
            lbl_datatime.Location = new Point(1009, 7);
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
            kryptonNavigator1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonNavigator1.Size = new Size(1127, 458);
            kryptonNavigator1.StateNormal.Panel.Color1 = SystemColors.Window;
            kryptonNavigator1.TabIndex = 19;
            kryptonNavigator1.Text = "kryptonNavigator1";
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
            kryptonPanel1.Size = new Size(200, 458);
            kryptonPanel1.TabIndex = 20;
            // 
            // BtnPag3
            // 
            BtnPag3.Cursor = Cursors.Hand;
            BtnPag3.Location = new Point(3, 214);
            BtnPag3.Name = "BtnPag3";
            BtnPag3.Size = new Size(194, 51);
            BtnPag3.TabIndex = 16;
            BtnPag3.Values.DropDownArrowColor = Color.Empty;
            BtnPag3.Values.Text = "VISUALIZAR";
            // 
            // BtnPag2
            // 
            BtnPag2.Cursor = Cursors.Hand;
            BtnPag2.Location = new Point(3, 158);
            BtnPag2.Name = "BtnPag2";
            BtnPag2.Size = new Size(194, 50);
            BtnPag2.TabIndex = 15;
            BtnPag2.Values.DropDownArrowColor = Color.Empty;
            BtnPag2.Values.Text = "REGISTRAR";
            // 
            // BtnPag1
            // 
            BtnPag1.Cursor = Cursors.Hand;
            BtnPag1.Location = new Point(3, 106);
            BtnPag1.Name = "BtnPag1";
            BtnPag1.Size = new Size(194, 46);
            BtnPag1.TabIndex = 1;
            BtnPag1.Values.DropDownArrowColor = Color.Empty;
            BtnPag1.Values.Text = "INICIO";
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Image = Properties.Resources.cpqi;
            kryptonPictureBox1.Location = new Point(39, 0);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(115, 80);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBox1.TabIndex = 0;
            kryptonPictureBox1.TabStop = false;
            // 
            // AssistantHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 458);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonNavigator1);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AssistantHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssistantHome";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonNavigator1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Label lblFullName;
        private Krypton.Toolkit.KryptonPictureBox PbProfile;
        private Krypton.Toolkit.KryptonPictureBox PbLogout;
        private Label lbl_datatime;
        private Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton BtnPag3;
        private Krypton.Toolkit.KryptonButton BtnPag2;
        private Krypton.Toolkit.KryptonButton BtnPag1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
    }
}