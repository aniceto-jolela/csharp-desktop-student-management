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
            textBox1 = new TextBox();
            Usuário = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            textBox5 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(270, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(359, 23);
            textBox1.TabIndex = 0;
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
            // textBox2
            // 
            textBox2.Location = new Point(270, 217);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(357, 23);
            textBox2.TabIndex = 2;
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
            // textBox3
            // 
            textBox3.Location = new Point(270, 263);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(359, 23);
            textBox3.TabIndex = 4;
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
            // textBox4
            // 
            textBox4.Location = new Point(270, 145);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(359, 23);
            textBox4.TabIndex = 7;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(272, 186);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 9;
            label5.Text = "Sexo : ";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(315, 186);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(36, 19);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "M";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(365, 187);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(31, 19);
            radioButton2.TabIndex = 11;
            radioButton2.Text = "F";
            radioButton2.UseVisualStyleBackColor = true;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(559, 188);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(70, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(390, 375);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "REGISTRAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(271, 315);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(358, 23);
            textBox5.TabIndex = 16;
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
            // RegisterAdministrativeAssistant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(Usuário);
            Controls.Add(textBox1);
            Name = "RegisterAdministrativeAssistant";
            Text = "RegisterAdministrativeAssistant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label Usuário;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private TextBox textBox5;
        private Label label7;
    }
}