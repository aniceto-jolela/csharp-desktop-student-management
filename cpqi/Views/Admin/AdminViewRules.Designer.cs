namespace cpqi.Views.Admin
{
    partial class AdminViewRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminViewRules));
            dgvRules = new Krypton.Toolkit.KryptonDataGridView();
            roleBindingSource = new BindingSource(components);
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            pbPdf = new Krypton.Toolkit.KryptonPictureBox();
            roleIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRules).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPdf).BeginInit();
            SuspendLayout();
            // 
            // dgvRules
            // 
            dgvRules.AllowUserToAddRows = false;
            dgvRules.AllowUserToDeleteRows = false;
            dgvRules.AllowUserToResizeColumns = false;
            dgvRules.AllowUserToResizeRows = false;
            dgvRules.AutoGenerateColumns = false;
            dgvRules.AutoGenerateKryptonColumns = false;
            dgvRules.BorderStyle = BorderStyle.None;
            dgvRules.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvRules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRules.Columns.AddRange(new DataGridViewColumn[] { roleIDDataGridViewTextBoxColumn, roleNameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dgvRules.DataSource = roleBindingSource;
            dgvRules.Dock = DockStyle.Bottom;
            dgvRules.ImeMode = ImeMode.NoControl;
            dgvRules.Location = new Point(0, 123);
            dgvRules.MultiSelect = false;
            dgvRules.Name = "dgvRules";
            dgvRules.ReadOnly = true;
            dgvRules.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRules.RowTemplate.ReadOnly = true;
            dgvRules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRules.Size = new Size(611, 101);
            dgvRules.TabIndex = 2;
            dgvRules.TabStop = false;
            // 
            // roleBindingSource
            // 
            roleBindingSource.DataSource = typeof(Models.Role);
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Image = Properties.Resources.marketeq__work;
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
            kryptonLabel1.Size = new Size(86, 30);
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 4;
            kryptonLabel1.Values.Text = "CARGOS";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonPictureBox1);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Dock = DockStyle.Top;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(611, 45);
            kryptonPanel1.StateNormal.Color1 = SystemColors.ControlLight;
            kryptonPanel1.TabIndex = 5;
            // 
            // pbPdf
            // 
            pbPdf.Cursor = Cursors.Hand;
            pbPdf.Image = Properties.Resources.material_icon_theme__pdf;
            pbPdf.Location = new Point(562, 79);
            pbPdf.Name = "pbPdf";
            pbPdf.Size = new Size(29, 38);
            pbPdf.SizeMode = PictureBoxSizeMode.Zoom;
            pbPdf.TabIndex = 6;
            pbPdf.TabStop = false;
            pbPdf.Click += pbPdf_Click;
            // 
            // roleIDDataGridViewTextBoxColumn
            // 
            roleIDDataGridViewTextBoxColumn.DataPropertyName = "RoleID";
            roleIDDataGridViewTextBoxColumn.HeaderText = "Nº";
            roleIDDataGridViewTextBoxColumn.Name = "roleIDDataGridViewTextBoxColumn";
            roleIDDataGridViewTextBoxColumn.ReadOnly = true;
            roleIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // roleNameDataGridViewTextBoxColumn
            // 
            roleNameDataGridViewTextBoxColumn.DataPropertyName = "RoleName";
            roleNameDataGridViewTextBoxColumn.HeaderText = "CARGOS";
            roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
            roleNameDataGridViewTextBoxColumn.ReadOnly = true;
            roleNameDataGridViewTextBoxColumn.Width = 155;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "DESCRIÇÃO";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 365;
            // 
            // AdminViewRules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 224);
            Controls.Add(pbPdf);
            Controls.Add(kryptonPanel1);
            Controls.Add(dgvRules);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminViewRules";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewRules";
            Load += ViewRules_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRules).EndInit();
            ((System.ComponentModel.ISupportInitialize)roleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPdf).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonDataGridView dgvRules;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPictureBox pbPdf;
        private BindingSource roleBindingSource;
        private DataGridViewTextBoxColumn roleIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}