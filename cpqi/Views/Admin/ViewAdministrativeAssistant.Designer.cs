namespace cpqi.Views.Admin
{
    partial class ViewAdministrativeAssistant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAdministrativeAssistant));
            dgvAdminAssistant = new Krypton.Toolkit.KryptonDataGridView();
            userIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sexDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            photoPathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isStaffDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isActiveDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isSuperUserDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dateJoinedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fileBiPathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            issuedOnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            validUntilDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fileCvPathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdByDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedByDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)dgvAdminAssistant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvAdminAssistant
            // 
            dgvAdminAssistant.AllowUserToDeleteRows = false;
            dgvAdminAssistant.AutoGenerateColumns = false;
            dgvAdminAssistant.AutoGenerateKryptonColumns = false;
            dgvAdminAssistant.BorderStyle = BorderStyle.None;
            dgvAdminAssistant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminAssistant.Columns.AddRange(new DataGridViewColumn[] { userIDDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, sexDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, photoPathDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, isStaffDataGridViewCheckBoxColumn, isActiveDataGridViewCheckBoxColumn, isSuperUserDataGridViewCheckBoxColumn, dateJoinedDataGridViewTextBoxColumn, fileBiPathDataGridViewTextBoxColumn, issuedOnDataGridViewTextBoxColumn, validUntilDataGridViewTextBoxColumn, fileCvPathDataGridViewTextBoxColumn, roleIDDataGridViewTextBoxColumn, createdAtDataGridViewTextBoxColumn, createdByDataGridViewTextBoxColumn, updatedAtDataGridViewTextBoxColumn, updatedByDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn });
            dgvAdminAssistant.DataSource = userBindingSource;
            dgvAdminAssistant.Location = new Point(12, 97);
            dgvAdminAssistant.Name = "dgvAdminAssistant";
            dgvAdminAssistant.ReadOnly = true;
            dgvAdminAssistant.Size = new Size(873, 332);
            dgvAdminAssistant.TabIndex = 5;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photoPathDataGridViewTextBoxColumn
            // 
            photoPathDataGridViewTextBoxColumn.DataPropertyName = "PhotoPath";
            photoPathDataGridViewTextBoxColumn.HeaderText = "PhotoPath";
            photoPathDataGridViewTextBoxColumn.Name = "photoPathDataGridViewTextBoxColumn";
            photoPathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isStaffDataGridViewCheckBoxColumn
            // 
            isStaffDataGridViewCheckBoxColumn.DataPropertyName = "IsStaff";
            isStaffDataGridViewCheckBoxColumn.HeaderText = "IsStaff";
            isStaffDataGridViewCheckBoxColumn.Name = "isStaffDataGridViewCheckBoxColumn";
            isStaffDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isSuperUserDataGridViewCheckBoxColumn
            // 
            isSuperUserDataGridViewCheckBoxColumn.DataPropertyName = "IsSuperUser";
            isSuperUserDataGridViewCheckBoxColumn.HeaderText = "IsSuperUser";
            isSuperUserDataGridViewCheckBoxColumn.Name = "isSuperUserDataGridViewCheckBoxColumn";
            isSuperUserDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // dateJoinedDataGridViewTextBoxColumn
            // 
            dateJoinedDataGridViewTextBoxColumn.DataPropertyName = "DateJoined";
            dateJoinedDataGridViewTextBoxColumn.HeaderText = "DateJoined";
            dateJoinedDataGridViewTextBoxColumn.Name = "dateJoinedDataGridViewTextBoxColumn";
            dateJoinedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileBiPathDataGridViewTextBoxColumn
            // 
            fileBiPathDataGridViewTextBoxColumn.DataPropertyName = "FileBiPath";
            fileBiPathDataGridViewTextBoxColumn.HeaderText = "FileBiPath";
            fileBiPathDataGridViewTextBoxColumn.Name = "fileBiPathDataGridViewTextBoxColumn";
            fileBiPathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // issuedOnDataGridViewTextBoxColumn
            // 
            issuedOnDataGridViewTextBoxColumn.DataPropertyName = "IssuedOn";
            issuedOnDataGridViewTextBoxColumn.HeaderText = "IssuedOn";
            issuedOnDataGridViewTextBoxColumn.Name = "issuedOnDataGridViewTextBoxColumn";
            issuedOnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // validUntilDataGridViewTextBoxColumn
            // 
            validUntilDataGridViewTextBoxColumn.DataPropertyName = "ValidUntil";
            validUntilDataGridViewTextBoxColumn.HeaderText = "ValidUntil";
            validUntilDataGridViewTextBoxColumn.Name = "validUntilDataGridViewTextBoxColumn";
            validUntilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileCvPathDataGridViewTextBoxColumn
            // 
            fileCvPathDataGridViewTextBoxColumn.DataPropertyName = "FileCvPath";
            fileCvPathDataGridViewTextBoxColumn.HeaderText = "FileCvPath";
            fileCvPathDataGridViewTextBoxColumn.Name = "fileCvPathDataGridViewTextBoxColumn";
            fileCvPathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleIDDataGridViewTextBoxColumn
            // 
            roleIDDataGridViewTextBoxColumn.DataPropertyName = "RoleID";
            roleIDDataGridViewTextBoxColumn.HeaderText = "RoleID";
            roleIDDataGridViewTextBoxColumn.Name = "roleIDDataGridViewTextBoxColumn";
            roleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
            createdByDataGridViewTextBoxColumn.HeaderText = "CreatedBy";
            createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            createdByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            updatedAtDataGridViewTextBoxColumn.DataPropertyName = "UpdatedAt";
            updatedAtDataGridViewTextBoxColumn.HeaderText = "UpdatedAt";
            updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            updatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedByDataGridViewTextBoxColumn
            // 
            updatedByDataGridViewTextBoxColumn.DataPropertyName = "UpdatedBy";
            updatedByDataGridViewTextBoxColumn.HeaderText = "UpdatedBy";
            updatedByDataGridViewTextBoxColumn.Name = "updatedByDataGridViewTextBoxColumn";
            updatedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Role";
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Models.User);
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonPictureBox1);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Dock = DockStyle.Top;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(897, 45);
            kryptonPanel1.StateNormal.Color1 = SystemColors.ControlLight;
            kryptonPanel1.TabIndex = 6;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Image = Properties.Resources.flat_color_icons__assistant;
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
            kryptonLabel1.Size = new Size(308, 30);
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 4;
            kryptonLabel1.Values.Text = "ASSISTENTE ADMINISTRATIVO(A)S";
            // 
            // ViewAdministrativeAssistant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 458);
            Controls.Add(kryptonPanel1);
            Controls.Add(dgvAdminAssistant);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewAdministrativeAssistant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewRegisterAdministrativeAssistant";
            Load += ViewAdministrativeAssistant_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdminAssistant).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
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
        private BindingSource userBindingSource;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn photoPathDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isStaffDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isSuperUserDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn dateJoinedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fileBiPathDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn issuedOnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn validUntilDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fileCvPathDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
    }
}