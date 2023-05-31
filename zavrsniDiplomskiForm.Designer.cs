namespace ZadatakDA
{
    partial class zavrsniDiplomskiForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxUloga = new System.Windows.Forms.GroupBox();
            this.textBoxPasswordReg = new System.Windows.Forms.TextBox();
            this.textBoxUsernameReg = new System.Windows.Forms.TextBox();
            this.textBoxPrezimeReg = new System.Windows.Forms.TextBox();
            this.textBoxImeReg = new System.Windows.Forms.TextBox();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.radioButtonProfesor = new System.Windows.Forms.RadioButton();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelImeReg = new System.Windows.Forms.Label();
            this.labelPrezimeReg = new System.Windows.Forms.Label();
            this.labelUsernameReg = new System.Windows.Forms.Label();
            this.labelPasswordReg = new System.Windows.Forms.Label();
            this.groupBoxSmjer = new System.Windows.Forms.GroupBox();
            this.radioButtonStrucni = new System.Windows.Forms.RadioButton();
            this.radioButtonDiplomski = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxUloga.SuspendLayout();
            this.groupBoxSmjer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.passwordLabel);
            this.tabPage1.Controls.Add(this.usernameLabel);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.passwordTextBox);
            this.tabPage1.Controls.Add(this.usernameTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(319, 157);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(319, 105);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 17);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(319, 177);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(142, 22);
            this.passwordTextBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(319, 128);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(142, 22);
            this.usernameTextBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxSmjer);
            this.tabPage2.Controls.Add(this.labelPasswordReg);
            this.tabPage2.Controls.Add(this.labelUsernameReg);
            this.tabPage2.Controls.Add(this.labelPrezimeReg);
            this.tabPage2.Controls.Add(this.labelImeReg);
            this.tabPage2.Controls.Add(this.buttonRegister);
            this.tabPage2.Controls.Add(this.groupBoxUloga);
            this.tabPage2.Controls.Add(this.textBoxPasswordReg);
            this.tabPage2.Controls.Add(this.textBoxUsernameReg);
            this.tabPage2.Controls.Add(this.textBoxPrezimeReg);
            this.tabPage2.Controls.Add(this.textBoxImeReg);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registracija";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxUloga
            // 
            this.groupBoxUloga.Controls.Add(this.radioButtonProfesor);
            this.groupBoxUloga.Controls.Add(this.radioButtonStudent);
            this.groupBoxUloga.Location = new System.Drawing.Point(158, 154);
            this.groupBoxUloga.Name = "groupBoxUloga";
            this.groupBoxUloga.Size = new System.Drawing.Size(157, 78);
            this.groupBoxUloga.TabIndex = 6;
            this.groupBoxUloga.TabStop = false;
            this.groupBoxUloga.Text = "Uloga";
            // 
            // textBoxPasswordReg
            // 
            this.textBoxPasswordReg.Location = new System.Drawing.Point(444, 126);
            this.textBoxPasswordReg.Name = "textBoxPasswordReg";
            this.textBoxPasswordReg.Size = new System.Drawing.Size(152, 22);
            this.textBoxPasswordReg.TabIndex = 3;
            // 
            // textBoxUsernameReg
            // 
            this.textBoxUsernameReg.Location = new System.Drawing.Point(444, 70);
            this.textBoxUsernameReg.Name = "textBoxUsernameReg";
            this.textBoxUsernameReg.Size = new System.Drawing.Size(152, 22);
            this.textBoxUsernameReg.TabIndex = 2;
            // 
            // textBoxPrezimeReg
            // 
            this.textBoxPrezimeReg.Location = new System.Drawing.Point(158, 126);
            this.textBoxPrezimeReg.Name = "textBoxPrezimeReg";
            this.textBoxPrezimeReg.Size = new System.Drawing.Size(157, 22);
            this.textBoxPrezimeReg.TabIndex = 1;
            // 
            // textBoxImeReg
            // 
            this.textBoxImeReg.Location = new System.Drawing.Point(158, 70);
            this.textBoxImeReg.Name = "textBoxImeReg";
            this.textBoxImeReg.Size = new System.Drawing.Size(157, 22);
            this.textBoxImeReg.TabIndex = 0;
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Checked = true;
            this.radioButtonStudent.Location = new System.Drawing.Point(7, 22);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(78, 21);
            this.radioButtonStudent.TabIndex = 0;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "Student";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // radioButtonProfesor
            // 
            this.radioButtonProfesor.AutoSize = true;
            this.radioButtonProfesor.Location = new System.Drawing.Point(7, 50);
            this.radioButtonProfesor.Name = "radioButtonProfesor";
            this.radioButtonProfesor.Size = new System.Drawing.Size(83, 21);
            this.radioButtonProfesor.TabIndex = 1;
            this.radioButtonProfesor.Text = "Profesor";
            this.radioButtonProfesor.UseVisualStyleBackColor = true;
            this.radioButtonProfesor.CheckedChanged += new System.EventHandler(this.radioButtonProfesor_CheckedChanged);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(444, 176);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(152, 36);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "Dovrši registraciju";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelImeReg
            // 
            this.labelImeReg.AutoSize = true;
            this.labelImeReg.Location = new System.Drawing.Point(158, 47);
            this.labelImeReg.Name = "labelImeReg";
            this.labelImeReg.Size = new System.Drawing.Size(30, 17);
            this.labelImeReg.TabIndex = 8;
            this.labelImeReg.Text = "Ime";
            // 
            // labelPrezimeReg
            // 
            this.labelPrezimeReg.AutoSize = true;
            this.labelPrezimeReg.Location = new System.Drawing.Point(158, 103);
            this.labelPrezimeReg.Name = "labelPrezimeReg";
            this.labelPrezimeReg.Size = new System.Drawing.Size(59, 17);
            this.labelPrezimeReg.TabIndex = 9;
            this.labelPrezimeReg.Text = "Prezime";
            // 
            // labelUsernameReg
            // 
            this.labelUsernameReg.AutoSize = true;
            this.labelUsernameReg.Location = new System.Drawing.Point(444, 47);
            this.labelUsernameReg.Name = "labelUsernameReg";
            this.labelUsernameReg.Size = new System.Drawing.Size(73, 17);
            this.labelUsernameReg.TabIndex = 10;
            this.labelUsernameReg.Text = "Username";
            // 
            // labelPasswordReg
            // 
            this.labelPasswordReg.AutoSize = true;
            this.labelPasswordReg.Location = new System.Drawing.Point(444, 103);
            this.labelPasswordReg.Name = "labelPasswordReg";
            this.labelPasswordReg.Size = new System.Drawing.Size(69, 17);
            this.labelPasswordReg.TabIndex = 11;
            this.labelPasswordReg.Text = "Password";
            // 
            // groupBoxSmjer
            // 
            this.groupBoxSmjer.Controls.Add(this.radioButtonDiplomski);
            this.groupBoxSmjer.Controls.Add(this.radioButtonStrucni);
            this.groupBoxSmjer.Location = new System.Drawing.Point(158, 238);
            this.groupBoxSmjer.Name = "groupBoxSmjer";
            this.groupBoxSmjer.Size = new System.Drawing.Size(157, 84);
            this.groupBoxSmjer.TabIndex = 12;
            this.groupBoxSmjer.TabStop = false;
            this.groupBoxSmjer.Text = "Odaberite studij";
            // 
            // radioButtonStrucni
            // 
            this.radioButtonStrucni.AutoSize = true;
            this.radioButtonStrucni.Checked = true;
            this.radioButtonStrucni.Location = new System.Drawing.Point(7, 22);
            this.radioButtonStrucni.Name = "radioButtonStrucni";
            this.radioButtonStrucni.Size = new System.Drawing.Size(105, 21);
            this.radioButtonStrucni.TabIndex = 0;
            this.radioButtonStrucni.TabStop = true;
            this.radioButtonStrucni.Text = "Stučni studij";
            this.radioButtonStrucni.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiplomski
            // 
            this.radioButtonDiplomski.AutoSize = true;
            this.radioButtonDiplomski.Location = new System.Drawing.Point(7, 50);
            this.radioButtonDiplomski.Name = "radioButtonDiplomski";
            this.radioButtonDiplomski.Size = new System.Drawing.Size(126, 21);
            this.radioButtonDiplomski.TabIndex = 1;
            this.radioButtonDiplomski.Text = "Diplomski studij";
            this.radioButtonDiplomski.UseVisualStyleBackColor = true;
            // 
            // zavrsniDiplomskiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "zavrsniDiplomskiForm";
            this.Text = "Zavrsni/Diplomski Explorer";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxUloga.ResumeLayout(false);
            this.groupBoxUloga.PerformLayout();
            this.groupBoxSmjer.ResumeLayout(false);
            this.groupBoxSmjer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.GroupBox groupBoxUloga;
        private System.Windows.Forms.TextBox textBoxPasswordReg;
        private System.Windows.Forms.TextBox textBoxUsernameReg;
        private System.Windows.Forms.TextBox textBoxPrezimeReg;
        private System.Windows.Forms.TextBox textBoxImeReg;
        private System.Windows.Forms.Label labelPasswordReg;
        private System.Windows.Forms.Label labelUsernameReg;
        private System.Windows.Forms.Label labelPrezimeReg;
        private System.Windows.Forms.Label labelImeReg;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.RadioButton radioButtonProfesor;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.GroupBox groupBoxSmjer;
        private System.Windows.Forms.RadioButton radioButtonDiplomski;
        private System.Windows.Forms.RadioButton radioButtonStrucni;
    }
}

