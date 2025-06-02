namespace cpqi.Views.Admin
{
    partial class AdminViewAdministrativeAssistant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminViewAdministrativeAssistant));
            dgvAdminAssistant = new Krypton.Toolkit.KryptonDataGridView();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)dgvAdminAssistant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvAdminAssistant
            // 
            dgvAdminAssistant.AllowUserToDeleteRows = false;
            dgvAdminAssistant.AutoGenerateKryptonColumns = false;
            dgvAdminAssistant.BorderStyle = BorderStyle.None;
            dgvAdminAssistant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminAssistant.Location = new Point(12, 97);
            dgvAdminAssistant.Name = "dgvAdminAssistant";
            dgvAdminAssistant.ReadOnly = true;
            dgvAdminAssistant.Size = new Size(1261, 332);
            dgvAdminAssistant.TabIndex = 5;
            dgvAdminAssistant.CellContentClick += dgvAdminAssistant_CellContentClick;
            dgvAdminAssistant.CellValueChanged += dgvAdminAssistant_CellValueChanged;
            dgvAdminAssistant.UserDeletingRow += dgvAdminAssistant_UserDeletingRow;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonPictureBox1);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Dock = DockStyle.Top;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1273, 45);
            kryptonPanel1.StateNormal.Color1 = SystemColors.ControlLight;
            kryptonPanel1.TabIndex = 6;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Image = Properties.Resources.flat_color_icons__assistant;
            kryptonPictureBox1.Location = new Point(494, 13);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(21, 23);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBox1.TabIndex = 3;
            kryptonPictureBox1.TabStop = false;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(517, 11);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(308, 30);
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 4;
            kryptonLabel1.Values.Text = "ASSISTENTE ADMINISTRATIVO(A)S";
            // 
            // AdminViewAdministrativeAssistant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 459);
            Controls.Add(kryptonPanel1);
            Controls.Add(dgvAdminAssistant);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminViewAdministrativeAssistant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewRegisterAdministrativeAssistant";
            ((System.ComponentModel.ISupportInitialize)dgvAdminAssistant).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonDataGridView dgvAdminAssistant;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}