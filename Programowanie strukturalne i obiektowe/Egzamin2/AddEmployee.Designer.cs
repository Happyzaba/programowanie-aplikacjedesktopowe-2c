namespace Egzamin2
{
    partial class FormAddEmployee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxInfo = new GroupBox();
            comboBoxPosition = new ComboBox();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            labelPosition = new Label();
            labelSurname = new Label();
            labelName = new Label();
            groupBoxPassword = new GroupBox();
            checkBoxSpecialCharacters = new CheckBox();
            checkBoxNumbers = new CheckBox();
            checkBoxSmallAndBig = new CheckBox();
            textBoxHowMuch = new TextBox();
            labelHowMuch = new Label();
            buttonPassword = new Button();
            buttonConfirm = new Button();
            groupBoxInfo.SuspendLayout();
            groupBoxPassword.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(comboBoxPosition);
            groupBoxInfo.Controls.Add(textBoxSurname);
            groupBoxInfo.Controls.Add(textBoxName);
            groupBoxInfo.Controls.Add(labelPosition);
            groupBoxInfo.Controls.Add(labelSurname);
            groupBoxInfo.Controls.Add(labelName);
            groupBoxInfo.Location = new Point(61, 84);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(281, 211);
            groupBoxInfo.TabIndex = 0;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Dane pracownika";
            // 
            // comboBoxPosition
            // 
            comboBoxPosition.FormattingEnabled = true;
            comboBoxPosition.Items.AddRange(new object[] { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" });
            comboBoxPosition.Location = new Point(156, 119);
            comboBoxPosition.Name = "comboBoxPosition";
            comboBoxPosition.Size = new Size(93, 23);
            comboBoxPosition.TabIndex = 5;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(156, 76);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(93, 23);
            textBoxSurname.TabIndex = 4;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(156, 30);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(93, 23);
            textBoxName.TabIndex = 3;
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.Location = new Point(33, 119);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(67, 15);
            labelPosition.TabIndex = 2;
            labelPosition.Text = "Stanowisko";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(33, 73);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(57, 15);
            labelSurname.TabIndex = 1;
            labelSurname.Text = "Nazwisko";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(33, 30);
            labelName.Name = "labelName";
            labelName.Size = new Size(30, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Imie";
            // 
            // groupBoxPassword
            // 
            groupBoxPassword.Controls.Add(checkBoxSpecialCharacters);
            groupBoxPassword.Controls.Add(checkBoxNumbers);
            groupBoxPassword.Controls.Add(checkBoxSmallAndBig);
            groupBoxPassword.Controls.Add(textBoxHowMuch);
            groupBoxPassword.Controls.Add(labelHowMuch);
            groupBoxPassword.Controls.Add(buttonPassword);
            groupBoxPassword.Location = new Point(446, 84);
            groupBoxPassword.Name = "groupBoxPassword";
            groupBoxPassword.Size = new Size(296, 211);
            groupBoxPassword.TabIndex = 1;
            groupBoxPassword.TabStop = false;
            groupBoxPassword.Text = "Generowanie hasła";
            // 
            // checkBoxSpecialCharacters
            // 
            checkBoxSpecialCharacters.AutoSize = true;
            checkBoxSpecialCharacters.Location = new Point(46, 126);
            checkBoxSpecialCharacters.Name = "checkBoxSpecialCharacters";
            checkBoxSpecialCharacters.Size = new Size(108, 19);
            checkBoxSpecialCharacters.TabIndex = 5;
            checkBoxSpecialCharacters.Text = "Znaki Specjalne";
            checkBoxSpecialCharacters.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumbers
            // 
            checkBoxNumbers.AutoSize = true;
            checkBoxNumbers.Location = new Point(46, 101);
            checkBoxNumbers.Name = "checkBoxNumbers";
            checkBoxNumbers.Size = new Size(54, 19);
            checkBoxNumbers.TabIndex = 4;
            checkBoxNumbers.Text = "Cyfry";
            checkBoxNumbers.UseVisualStyleBackColor = true;
            // 
            // checkBoxSmallAndBig
            // 
            checkBoxSmallAndBig.AutoSize = true;
            checkBoxSmallAndBig.Checked = true;
            checkBoxSmallAndBig.CheckState = CheckState.Checked;
            checkBoxSmallAndBig.Location = new Point(46, 76);
            checkBoxSmallAndBig.Name = "checkBoxSmallAndBig";
            checkBoxSmallAndBig.Size = new Size(126, 19);
            checkBoxSmallAndBig.TabIndex = 3;
            checkBoxSmallAndBig.Text = "Małe i wielkie litery";
            checkBoxSmallAndBig.UseVisualStyleBackColor = true;
            // 
            // textBoxHowMuch
            // 
            textBoxHowMuch.Location = new Point(165, 41);
            textBoxHowMuch.Name = "textBoxHowMuch";
            textBoxHowMuch.Size = new Size(91, 23);
            textBoxHowMuch.TabIndex = 2;
            // 
            // labelHowMuch
            // 
            labelHowMuch.AutoSize = true;
            labelHowMuch.Location = new Point(46, 44);
            labelHowMuch.Name = "labelHowMuch";
            labelHowMuch.Size = new Size(67, 15);
            labelHowMuch.TabIndex = 1;
            labelHowMuch.Text = "Ile znakow?";
            // 
            // buttonPassword
            // 
            buttonPassword.BackColor = Color.SteelBlue;
            buttonPassword.ForeColor = Color.White;
            buttonPassword.Location = new Point(86, 167);
            buttonPassword.Name = "buttonPassword";
            buttonPassword.Size = new Size(98, 21);
            buttonPassword.TabIndex = 0;
            buttonPassword.Text = "Generuj hasło";
            buttonPassword.UseVisualStyleBackColor = false;
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.SteelBlue;
            buttonConfirm.ForeColor = Color.White;
            buttonConfirm.Location = new Point(266, 367);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(258, 35);
            buttonConfirm.TabIndex = 2;
            buttonConfirm.Text = "Zatwierdz";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // FormAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonConfirm);
            Controls.Add(groupBoxPassword);
            Controls.Add(groupBoxInfo);
            Name = "FormAddEmployee";
            Text = "Dodaj Pracownika";
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            groupBoxPassword.ResumeLayout(false);
            groupBoxPassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInfo;
        private Label labelPosition;
        private Label labelSurname;
        private Label labelName;
        private GroupBox groupBoxPassword;
        private Button buttonPassword;
        private Button buttonConfirm;
        private ComboBox comboBoxPosition;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private TextBox textBoxHowMuch;
        private Label labelHowMuch;
        private CheckBox checkBoxSmallAndBig;
        private CheckBox checkBoxSpecialCharacters;
        private CheckBox checkBoxNumbers;
    }
}