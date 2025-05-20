namespace cpqi.Views.Admin
{
    partial class adHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adHome));
            lbl_datatime = new Label();
            kryptonNavigator1 = new Krypton.Navigator.KryptonNavigator();
            kryptonPage1 = new Krypton.Navigator.KryptonPage();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonPage2 = new Krypton.Navigator.KryptonPage();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonPage3 = new Krypton.Navigator.KryptonPage();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            btn_logout = new Button();
            btn_profile = new Button();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            btnPag1 = new Krypton.Toolkit.KryptonButton();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            btnPag3 = new Krypton.Toolkit.KryptonButton();
            btnPag2 = new Krypton.Toolkit.KryptonButton();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)kryptonNavigator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPage1).BeginInit();
            kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPage2).BeginInit();
            kryptonPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPage3).BeginInit();
            kryptonPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_datatime
            // 
            lbl_datatime.Anchor = AnchorStyles.Top;
            lbl_datatime.AutoSize = true;
            lbl_datatime.Location = new Point(262, 11);
            lbl_datatime.Name = "lbl_datatime";
            lbl_datatime.Size = new Size(58, 15);
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
            kryptonNavigator1.SelectedIndex = 0;
            kryptonNavigator1.Size = new Size(656, 282);
            kryptonNavigator1.StateNormal.Panel.Color1 = SystemColors.Window;
            kryptonNavigator1.TabIndex = 16;
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
            kryptonPage1.Size = new Size(656, 282);
            kryptonPage1.Text = "kryptonPage1";
            kryptonPage1.ToolTipTitle = "Page ToolTip";
            kryptonPage1.UniqueName = "9d355c6fb8ef4fb4a0606d0717e1c6ce";
            kryptonPage1.Click += kryptonPage1_Click;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(76, 60);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(89, 20);
            kryptonLabel1.TabIndex = 17;
            kryptonLabel1.Values.Text = "DASHABORDS";
            // 
            // kryptonPage2
            // 
            kryptonPage2.AutoHiddenSlideSize = new Size(200, 200);
            kryptonPage2.Controls.Add(kryptonLabel2);
            kryptonPage2.Flags = 65534;
            kryptonPage2.LastVisibleSet = true;
            kryptonPage2.MinimumSize = new Size(150, 50);
            kryptonPage2.Name = "kryptonPage2";
            kryptonPage2.Size = new Size(425, 205);
            kryptonPage2.Text = "kryptonPage2";
            kryptonPage2.ToolTipTitle = "Page ToolTip";
            kryptonPage2.UniqueName = "dddca1eda0b54d9d8f68b502055e0a4e";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(137, 90);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(72, 20);
            kryptonLabel2.TabIndex = 17;
            kryptonLabel2.Values.Text = "REGISTRAR";
            // 
            // kryptonPage3
            // 
            kryptonPage3.AutoHiddenSlideSize = new Size(200, 200);
            kryptonPage3.Controls.Add(kryptonLabel3);
            kryptonPage3.Flags = 65534;
            kryptonPage3.LastVisibleSet = true;
            kryptonPage3.MinimumSize = new Size(150, 50);
            kryptonPage3.Name = "kryptonPage3";
            kryptonPage3.Size = new Size(425, 205);
            kryptonPage3.Text = "kryptonPage3";
            kryptonPage3.ToolTipTitle = "Page ToolTip";
            kryptonPage3.UniqueName = "1b3fc701b155449fa45b707b4ed2400f";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(155, 116);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(76, 20);
            kryptonLabel3.TabIndex = 18;
            kryptonLabel3.Values.Text = "VISUALIZAR";
            // 
            // btn_logout
            // 
            btn_logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_logout.Location = new Point(567, 3);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(75, 23);
            btn_logout.TabIndex = 12;
            btn_logout.Text = "Sair";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_profile
            // 
            btn_profile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_profile.Location = new Point(485, 3);
            btn_profile.Name = "btn_profile";
            btn_profile.Size = new Size(75, 23);
            btn_profile.TabIndex = 14;
            btn_profile.Text = "Perfil";
            btn_profile.UseVisualStyleBackColor = true;
            btn_profile.Click += btn_profile_Click;
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
            kryptonPictureBox1.Click += kryptonPictureBox1_Click;
            // 
            // btnPag1
            // 
            btnPag1.Location = new Point(49, 106);
            btnPag1.Name = "btnPag1";
            btnPag1.Size = new Size(90, 25);
            btnPag1.TabIndex = 1;
            btnPag1.Values.DropDownArrowColor = Color.Empty;
            btnPag1.Values.Text = "INICIO";
            btnPag1.Click += btnPag1_Click_1;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(btnPag3);
            kryptonPanel1.Controls.Add(btnPag2);
            kryptonPanel1.Controls.Add(btnPag1);
            kryptonPanel1.Controls.Add(kryptonPictureBox1);
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(200, 282);
            kryptonPanel1.TabIndex = 17;
            // 
            // btnPag3
            // 
            btnPag3.Location = new Point(49, 208);
            btnPag3.Name = "btnPag3";
            btnPag3.Size = new Size(90, 25);
            btnPag3.TabIndex = 16;
            btnPag3.Values.DropDownArrowColor = Color.Empty;
            btnPag3.Values.Text = "VISUALIZAR";
            btnPag3.Click += btnPag3_Click_1;
            // 
            // btnPag2
            // 
            btnPag2.Location = new Point(49, 158);
            btnPag2.Name = "btnPag2";
            btnPag2.Size = new Size(90, 25);
            btnPag2.TabIndex = 15;
            btnPag2.Values.DropDownArrowColor = Color.Empty;
            btnPag2.Values.Text = "REGISTRAR";
            btnPag2.Click += btnPag2_Click_1;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(btn_profile);
            kryptonPanel2.Controls.Add(btn_logout);
            kryptonPanel2.Controls.Add(lbl_datatime);
            kryptonPanel2.Dock = DockStyle.Top;
            kryptonPanel2.Location = new Point(200, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(656, 36);
            kryptonPanel2.StateNormal.Color1 = SystemColors.AppWorkspace;
            kryptonPanel2.TabIndex = 18;
            kryptonPanel2.Paint += kryptonPanel2_Paint;
            // 
            // adHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 282);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonNavigator1);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "adHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HOME";
            FormClosing += adHome_FormClosing;
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
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_datatime;
        private Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private Krypton.Navigator.KryptonPage kryptonPage1;
        private Krypton.Navigator.KryptonPage kryptonPage2;
        private Krypton.Navigator.KryptonPage kryptonPage3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Button btn_logout;
        private Button btn_profile;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonButton btnPag1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton btnPag3;
        private Krypton.Toolkit.KryptonButton btnPag2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
    }
}