namespace BMI_CAL
{
    partial class registerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateOfBirth = new System.Windows.Forms.MaskedTextBox();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.registerButton = new System.Windows.Forms.Button();
            this.bloodType = new System.Windows.Forms.ComboBox();
            this.gender_female = new System.Windows.Forms.RadioButton();
            this.gender_male = new System.Windows.Forms.RadioButton();
            this.password_2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.password_1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateOfBirth);
            this.panel1.Controls.Add(this.linkLogin);
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Controls.Add(this.bloodType);
            this.panel1.Controls.Add(this.gender_female);
            this.panel1.Controls.Add(this.gender_male);
            this.panel1.Controls.Add(this.password_2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.password_1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.surname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(85, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 427);
            this.panel1.TabIndex = 2;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(52, 204);
            this.dateOfBirth.Mask = "00/00/0000";
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(203, 20);
            this.dateOfBirth.TabIndex = 25;
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.Location = new System.Drawing.Point(74, 355);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(150, 13);
            this.linkLogin.TabIndex = 23;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Already a member? Login here";
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(52, 381);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(203, 31);
            this.registerButton.TabIndex = 22;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // bloodType
            // 
            this.bloodType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bloodType.FormattingEnabled = true;
            this.bloodType.Items.AddRange(new object[] {
            "Group A",
            "Group B",
            "Group AB",
            "Group O"});
            this.bloodType.Location = new System.Drawing.Point(52, 246);
            this.bloodType.Name = "bloodType";
            this.bloodType.Size = new System.Drawing.Size(203, 21);
            this.bloodType.TabIndex = 21;
            // 
            // gender_female
            // 
            this.gender_female.AutoSize = true;
            this.gender_female.Location = new System.Drawing.Point(106, 165);
            this.gender_female.Name = "gender_female";
            this.gender_female.Size = new System.Drawing.Size(59, 17);
            this.gender_female.TabIndex = 18;
            this.gender_female.TabStop = true;
            this.gender_female.Text = "Female";
            this.gender_female.UseVisualStyleBackColor = true;
            this.gender_female.CheckedChanged += new System.EventHandler(this.gender_female_CheckedChanged);
            // 
            // gender_male
            // 
            this.gender_male.AutoSize = true;
            this.gender_male.Location = new System.Drawing.Point(52, 165);
            this.gender_male.Name = "gender_male";
            this.gender_male.Size = new System.Drawing.Size(48, 17);
            this.gender_male.TabIndex = 17;
            this.gender_male.TabStop = true;
            this.gender_male.Text = "Male";
            this.gender_male.UseVisualStyleBackColor = true;
            this.gender_male.CheckedChanged += new System.EventHandler(this.gender_male_CheckedChanged);
            // 
            // password_2
            // 
            this.password_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.password_2.Location = new System.Drawing.Point(52, 332);
            this.password_2.Name = "password_2";
            this.password_2.PasswordChar = '*';
            this.password_2.Size = new System.Drawing.Size(203, 20);
            this.password_2.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Confirm Password";
            // 
            // password_1
            // 
            this.password_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.password_1.Location = new System.Drawing.Point(52, 290);
            this.password_1.Name = "password_1";
            this.password_1.PasswordChar = '*';
            this.password_1.Size = new System.Drawing.Size(203, 20);
            this.password_1.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Blood Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "D.O.B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gender";
            // 
            // surname
            // 
            this.surname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.surname.Location = new System.Drawing.Point(52, 123);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(203, 20);
            this.surname.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Surname";
            // 
            // name
            // 
            this.name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.name.Location = new System.Drawing.Point(52, 81);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(203, 20);
            this.name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // username
            // 
            this.username.ForeColor = System.Drawing.SystemColors.ControlText;
            this.username.Location = new System.Drawing.Point(52, 39);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(203, 20);
            this.username.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(136, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Form";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.helpToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "registerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator Register";
            this.Load += new System.EventHandler(this.registerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.ComboBox bloodType;
        private System.Windows.Forms.RadioButton gender_female;
        private System.Windows.Forms.RadioButton gender_male;
        private System.Windows.Forms.TextBox password_2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox password_1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLogin;
        private System.Windows.Forms.MaskedTextBox dateOfBirth;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
    }
}