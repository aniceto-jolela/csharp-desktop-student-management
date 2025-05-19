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
            dgvAdminAssistant = new DataGridView();
            label1 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAdminAssistant).BeginInit();
            SuspendLayout();
            // 
            // dgvAdminAssistant
            // 
            dgvAdminAssistant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminAssistant.Location = new Point(68, 97);
            dgvAdminAssistant.Name = "dgvAdminAssistant";
            dgvAdminAssistant.Size = new Size(621, 332);
            dgvAdminAssistant.TabIndex = 0;  
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 38);
            label1.Name = "label1";
            label1.Size = new Size(187, 15);
            label1.TabIndex = 1;
            label1.Text = "ASSISTENTE ADMINISTRATIVO(A)S";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(422, 68);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(512, 68);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(614, 68);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Excluir";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // ViewAdministrativeAssistant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(dgvAdminAssistant);
            Name = "ViewAdministrativeAssistant";
            Text = "ViewRegisterAdministrativeAssistant";
            ((System.ComponentModel.ISupportInitialize)dgvAdminAssistant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAdminAssistant;
        private Label label1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}