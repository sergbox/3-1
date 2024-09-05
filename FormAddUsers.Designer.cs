namespace _3_1
{
    partial class FormAddUsers
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
            this.components = new System.ComponentModel.Container();
            this.buttonback = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.phonemaskedtextbox = new System.Windows.Forms.MaskedTextBox();
            this.roleidcombobox = new System.Windows.Forms.ComboBox();
            this.radioButtonmen = new System.Windows.Forms.RadioButton();
            this.radioButtonwomen = new System.Windows.Forms.RadioButton();
            this.second_nametextbox = new System.Windows.Forms.TextBox();
            this.first_nametextbox = new System.Windows.Forms.TextBox();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.passwordtextbox2 = new System.Windows.Forms.TextBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.logintextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bindingSourceRole = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRole)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(37, 31);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(75, 23);
            this.buttonback.TabIndex = 0;
            this.buttonback.Text = "Назад";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(571, 285);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(75, 23);
            this.buttonadd.TabIndex = 1;
            this.buttonadd.Text = "Добавить";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // phonemaskedtextbox
            // 
            this.phonemaskedtextbox.Location = new System.Drawing.Point(130, 268);
            this.phonemaskedtextbox.Mask = "+7 (000) 000-00-00";
            this.phonemaskedtextbox.Name = "phonemaskedtextbox";
            this.phonemaskedtextbox.Size = new System.Drawing.Size(147, 20);
            this.phonemaskedtextbox.TabIndex = 2;
            // 
            // roleidcombobox
            // 
            this.roleidcombobox.DataSource = this.bindingSourceRole;
            this.roleidcombobox.DisplayMember = "Name";
            this.roleidcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleidcombobox.FormattingEnabled = true;
            this.roleidcombobox.Location = new System.Drawing.Point(499, 198);
            this.roleidcombobox.Name = "roleidcombobox";
            this.roleidcombobox.Size = new System.Drawing.Size(147, 21);
            this.roleidcombobox.TabIndex = 3;
            this.roleidcombobox.ValueMember = "ID";
            // 
            // radioButtonmen
            // 
            this.radioButtonmen.AutoSize = true;
            this.radioButtonmen.Checked = true;
            this.radioButtonmen.Location = new System.Drawing.Point(476, 235);
            this.radioButtonmen.Name = "radioButtonmen";
            this.radioButtonmen.Size = new System.Drawing.Size(71, 17);
            this.radioButtonmen.TabIndex = 4;
            this.radioButtonmen.TabStop = true;
            this.radioButtonmen.Text = "Мужской";
            this.radioButtonmen.UseVisualStyleBackColor = true;
            // 
            // radioButtonwomen
            // 
            this.radioButtonwomen.AutoSize = true;
            this.radioButtonwomen.Location = new System.Drawing.Point(574, 235);
            this.radioButtonwomen.Name = "radioButtonwomen";
            this.radioButtonwomen.Size = new System.Drawing.Size(72, 17);
            this.radioButtonwomen.TabIndex = 5;
            this.radioButtonwomen.Text = "Женский";
            this.radioButtonwomen.UseVisualStyleBackColor = true;
            // 
            // second_nametextbox
            // 
            this.second_nametextbox.Location = new System.Drawing.Point(499, 151);
            this.second_nametextbox.Name = "second_nametextbox";
            this.second_nametextbox.Size = new System.Drawing.Size(147, 20);
            this.second_nametextbox.TabIndex = 6;
            // 
            // first_nametextbox
            // 
            this.first_nametextbox.Location = new System.Drawing.Point(499, 103);
            this.first_nametextbox.Name = "first_nametextbox";
            this.first_nametextbox.Size = new System.Drawing.Size(147, 20);
            this.first_nametextbox.TabIndex = 7;
            // 
            // emailtextbox
            // 
            this.emailtextbox.Location = new System.Drawing.Point(130, 228);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(147, 20);
            this.emailtextbox.TabIndex = 8;
            // 
            // passwordtextbox2
            // 
            this.passwordtextbox2.Location = new System.Drawing.Point(130, 188);
            this.passwordtextbox2.Name = "passwordtextbox2";
            this.passwordtextbox2.PasswordChar = '*';
            this.passwordtextbox2.Size = new System.Drawing.Size(147, 20);
            this.passwordtextbox2.TabIndex = 9;
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(130, 147);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.PasswordChar = '*';
            this.passwordtextbox.Size = new System.Drawing.Size(147, 20);
            this.passwordtextbox.TabIndex = 10;
            // 
            // logintextbox
            // 
            this.logintextbox.Location = new System.Drawing.Point(130, 100);
            this.logintextbox.Name = "logintextbox";
            this.logintextbox.Size = new System.Drawing.Size(147, 20);
            this.logintextbox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Добавление Нового Пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Повтор пароля:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Эл. почта:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Телефон:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Имя:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Фамилия:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(390, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Роль:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(390, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Пол:";
            // 
            // bindingSourceRole
            // 
            this.bindingSourceRole.DataSource = typeof(_3_1.DBContext.Roles);
            // 
            // FormAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 357);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logintextbox);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.passwordtextbox2);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.first_nametextbox);
            this.Controls.Add(this.second_nametextbox);
            this.Controls.Add(this.radioButtonwomen);
            this.Controls.Add(this.radioButtonmen);
            this.Controls.Add(this.roleidcombobox);
            this.Controls.Add(this.phonemaskedtextbox);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.buttonback);
            this.Name = "FormAddUsers";
            this.Text = "FormAddUsers";
            this.Load += new System.EventHandler(this.FormAddUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.MaskedTextBox phonemaskedtextbox;
        private System.Windows.Forms.ComboBox roleidcombobox;
        private System.Windows.Forms.RadioButton radioButtonmen;
        private System.Windows.Forms.RadioButton radioButtonwomen;
        private System.Windows.Forms.TextBox second_nametextbox;
        private System.Windows.Forms.TextBox first_nametextbox;
        private System.Windows.Forms.TextBox emailtextbox;
        private System.Windows.Forms.TextBox passwordtextbox2;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.TextBox logintextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource bindingSourceRole;
    }
}