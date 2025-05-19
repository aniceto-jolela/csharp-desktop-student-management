namespace cpqi.Views.Admin
{
    partial class RegisterAdministrativeAssistant
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
            txtUserName = new TextBox();
            Usuário = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            txtPhone = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtFullName = new TextBox();
            label4 = new Label();
            label6 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            btnRegister = new Button();
            txtPassword = new TextBox();
            label7 = new Label();
            cbSex = new ComboBox();
            label5 = new Label();
            ckbIsActive = new CheckBox();
            ckbIsStaff = new CheckBox();
            ckbIsSuperUser = new CheckBox();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(270, 101);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(359, 23);
            txtUserName.TabIndex = 0;
            // 
            // Usuário
            // 
            Usuário.AutoSize = true;
            Usuário.Location = new Point(130, 108);
            Usuário.Name = "Usuário";
            Usuário.Size = new Size(56, 15);
            Usuário.TabIndex = 1;
            Usuário.Text = "Usuário : ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(270, 217);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(357, 23);
            txtEmail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 221);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Email : ";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(270, 263);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(359, 23);
            txtPhone.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 266);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 5;
            label2.Text = "Nº Telefone : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 41);
            label3.Name = "label3";
            label3.Size = new Size(163, 15);
            label3.TabIndex = 6;
            label3.Text = "ASSISTENTE ADMINISTRATIVA";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(270, 145);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(359, 23);
            txtFullName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 146);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 8;
            label4.Text = "Nome Completo : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(439, 188);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 12;
            label6.Text = "Data de Nascimento";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(559, 188);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(70, 23);
            dtpDateOfBirth.TabIndex = 13;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(428, 459);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 15;
            btnRegister.Text = "REGISTRAR";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(271, 315);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(358, 23);
            txtPassword.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(129, 317);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 17;
            label7.Text = "Palavra passe : ";
            // 
            // cbSex
            // 
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "M", "F", "O" });
            cbSex.Location = new Point(270, 180);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(121, 23);
            cbSex.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(183, 188);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 19;
            label5.Text = "Sexo";
            // 
            // ckbIsActive
            // 
            ckbIsActive.AutoSize = true;
            ckbIsActive.Location = new Point(275, 354);
            ckbIsActive.Name = "ckbIsActive";
            ckbIsActive.Size = new Size(67, 19);
            ckbIsActive.TabIndex = 20;
            ckbIsActive.Text = "IsActive";
            ckbIsActive.UseVisualStyleBackColor = true;
            // 
            // ckbIsStaff
            // 
            ckbIsStaff.AutoSize = true;
            ckbIsStaff.Location = new Point(392, 354);
            ckbIsStaff.Name = "ckbIsStaff";
            ckbIsStaff.Size = new Size(58, 19);
            ckbIsStaff.TabIndex = 21;
            ckbIsStaff.Text = "IsStaff";
            ckbIsStaff.UseVisualStyleBackColor = true;
            // 
            // ckbIsSuperUser
            // 
            ckbIsSuperUser.AutoSize = true;
            ckbIsSuperUser.Location = new Point(512, 354);
            ckbIsSuperUser.Name = "ckbIsSuperUser";
            ckbIsSuperUser.Size = new Size(87, 19);
            ckbIsSuperUser.TabIndex = 22;
            ckbIsSuperUser.Text = "IsSuperUser";
            ckbIsSuperUser.UseVisualStyleBackColor = true;
            // 
            // RegisterAdministrativeAssistant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 511);
            Controls.Add(ckbIsSuperUser);
            Controls.Add(ckbIsStaff);
            Controls.Add(ckbIsActive);
            Controls.Add(label5);
            Controls.Add(cbSex);
            Controls.Add(label7);
            Controls.Add(txtPassword);
            Controls.Add(btnRegister);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtFullName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPhone);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(Usuário);
            Controls.Add(txtUserName);
            Name = "RegisterAdministrativeAssistant";
            Text = "RegisterAdministrativeAssistant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private Label Usuário;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtPhone;
        private Label label2;
        private Label label3;
        private TextBox txtFullName;
        private Label label4;
        private Label label6;
        private DateTimePicker dtpDateOfBirth;
        private Button btnRegister;
        private TextBox txtPassword;
        private Label label7;
        private ComboBox cbSex;
        private Label label5;
        private CheckBox ckbIsActive;
        private CheckBox ckbIsStaff;
        private CheckBox ckbIsSuperUser;
    }
}