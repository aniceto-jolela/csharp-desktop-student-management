namespace cpqi.Views.Admin
{
    partial class ViewRules
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
            label1 = new Label();
            dgv_Rules = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Rules).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 62);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cargos";
            // 
            // dgv_Rules
            // 
            dgv_Rules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Rules.Location = new Point(69, 124);
            dgv_Rules.Name = "dgv_Rules";
            dgv_Rules.Size = new Size(662, 150);
            dgv_Rules.TabIndex = 1;
            // 
            // ViewRules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_Rules);
            Controls.Add(label1);
            Name = "ViewRules";
            Text = "ViewRules";
            ((System.ComponentModel.ISupportInitialize)dgv_Rules).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_Rules;
    }
}