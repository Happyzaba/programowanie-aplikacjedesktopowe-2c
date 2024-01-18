namespace FirstWinFormsApp
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            buttonHello = new Button();
            textBoxName = new TextBox();
            labelName = new Label();
            checkBoxSchoolSubjectMathematics = new CheckBox();
            checkBoxSchoolSubjectGerman = new CheckBox();
            labelSchoolSubject = new Label();
            label2 = new Label();
            radioButtonPizzaQuestionYes = new RadioButton();
            radioButtonPizzaQuestionNo = new RadioButton();
            labelPizzaQuestion = new Label();
            notifyIcon1 = new NotifyIcon(components);
            comboBoxFavouriteMeal = new ComboBox();
            labelFavouriteMeal = new Label();
            labelCurentTimeDescription = new Label();
            labelCurentTime = new Label();
            buttonRefreshTime = new Button();
            timerRefreshTime = new System.Windows.Forms.Timer(components);
            labelMouseClick = new Label();
            numericUpDownFirstNumber = new NumericUpDown();
            numericUpDownSecondNumber = new NumericUpDown();
            buttonAdd = new Button();
            buttonSub = new Button();
            buttonMul = new Button();
            buttonDiv = new Button();
            labelResult = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondNumber).BeginInit();
            SuspendLayout();
            // 
            // buttonHello
            // 
            buttonHello.BackColor = Color.Transparent;
            buttonHello.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHello.ForeColor = SystemColors.ControlText;
            buttonHello.Location = new Point(20, 507);
            buttonHello.Name = "buttonHello";
            buttonHello.Size = new Size(247, 96);
            buttonHello.TabIndex = 1;
            buttonHello.Text = "Hello";
            buttonHello.UseVisualStyleBackColor = false;
            buttonHello.Click += buttonHello_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 47);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(338, 23);
            textBoxName.TabIndex = 0;
            textBoxName.Text = "Jan";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.FromArgb(192, 192, 0);
            labelName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.Maroon;
            labelName.Location = new Point(12, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(159, 25);
            labelName.TabIndex = 2;
            labelName.Text = "Podaj swoje imię:";
            // 
            // checkBoxSchoolSubjectMathematics
            // 
            checkBoxSchoolSubjectMathematics.AutoSize = true;
            checkBoxSchoolSubjectMathematics.Location = new Point(23, 107);
            checkBoxSchoolSubjectMathematics.Name = "checkBoxSchoolSubjectMathematics";
            checkBoxSchoolSubjectMathematics.Size = new Size(92, 19);
            checkBoxSchoolSubjectMathematics.TabIndex = 2;
            checkBoxSchoolSubjectMathematics.Text = "matematyka";
            checkBoxSchoolSubjectMathematics.UseVisualStyleBackColor = true;
            // 
            // checkBoxSchoolSubjectGerman
            // 
            checkBoxSchoolSubjectGerman.AutoSize = true;
            checkBoxSchoolSubjectGerman.Location = new Point(23, 132);
            checkBoxSchoolSubjectGerman.Name = "checkBoxSchoolSubjectGerman";
            checkBoxSchoolSubjectGerman.Size = new Size(106, 19);
            checkBoxSchoolSubjectGerman.TabIndex = 4;
            checkBoxSchoolSubjectGerman.Text = "język niemiecki";
            checkBoxSchoolSubjectGerman.UseVisualStyleBackColor = true;
            // 
            // labelSchoolSubject
            // 
            labelSchoolSubject.AutoSize = true;
            labelSchoolSubject.Location = new Point(23, 89);
            labelSchoolSubject.Name = "labelSchoolSubject";
            labelSchoolSubject.Size = new Size(163, 15);
            labelSchoolSubject.TabIndex = 5;
            labelSchoolSubject.Text = "Jaki lubisz przedmiot szkolny?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 428);
            label2.Name = "label2";
            label2.Size = new Size(278, 64);
            label2.TabIndex = 6;
            label2.Text = "labelFavouriteMeal\r\ncomboBoxFavouriteMeal";
            // 
            // radioButtonPizzaQuestionYes
            // 
            radioButtonPizzaQuestionYes.AutoSize = true;
            radioButtonPizzaQuestionYes.Checked = true;
            radioButtonPizzaQuestionYes.Location = new Point(224, 107);
            radioButtonPizzaQuestionYes.Name = "radioButtonPizzaQuestionYes";
            radioButtonPizzaQuestionYes.Size = new Size(42, 19);
            radioButtonPizzaQuestionYes.TabIndex = 3;
            radioButtonPizzaQuestionYes.TabStop = true;
            radioButtonPizzaQuestionYes.Text = "Tak";
            radioButtonPizzaQuestionYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonPizzaQuestionNo
            // 
            radioButtonPizzaQuestionNo.AutoSize = true;
            radioButtonPizzaQuestionNo.Location = new Point(224, 131);
            radioButtonPizzaQuestionNo.Name = "radioButtonPizzaQuestionNo";
            radioButtonPizzaQuestionNo.Size = new Size(43, 19);
            radioButtonPizzaQuestionNo.TabIndex = 5;
            radioButtonPizzaQuestionNo.TabStop = true;
            radioButtonPizzaQuestionNo.Text = "Nie";
            radioButtonPizzaQuestionNo.UseVisualStyleBackColor = true;
            // 
            // labelPizzaQuestion
            // 
            labelPizzaQuestion.AutoSize = true;
            labelPizzaQuestion.Location = new Point(224, 89);
            labelPizzaQuestion.Name = "labelPizzaQuestion";
            labelPizzaQuestion.Size = new Size(103, 15);
            labelPizzaQuestion.TabIndex = 9;
            labelPizzaQuestion.Text = "Pizza z ananasem?";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // comboBoxFavouriteMeal
            // 
            comboBoxFavouriteMeal.BackColor = Color.White;
            comboBoxFavouriteMeal.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFavouriteMeal.FormattingEnabled = true;
            comboBoxFavouriteMeal.Items.AddRange(new object[] { "Rosół", "Kebab", "Pizza z ananasem", "Schabowy", "Ramen" });
            comboBoxFavouriteMeal.Location = new Point(12, 205);
            comboBoxFavouriteMeal.Name = "comboBoxFavouriteMeal";
            comboBoxFavouriteMeal.Size = new Size(442, 23);
            comboBoxFavouriteMeal.TabIndex = 10;
            // 
            // labelFavouriteMeal
            // 
            labelFavouriteMeal.AutoSize = true;
            labelFavouriteMeal.Location = new Point(12, 176);
            labelFavouriteMeal.Name = "labelFavouriteMeal";
            labelFavouriteMeal.Size = new Size(90, 15);
            labelFavouriteMeal.TabIndex = 11;
            labelFavouriteMeal.Text = "Ulubione danie:";
            // 
            // labelCurentTimeDescription
            // 
            labelCurentTimeDescription.AutoSize = true;
            labelCurentTimeDescription.Location = new Point(47, 249);
            labelCurentTimeDescription.Name = "labelCurentTimeDescription";
            labelCurentTimeDescription.Size = new Size(82, 15);
            labelCurentTimeDescription.TabIndex = 12;
            labelCurentTimeDescription.Text = "Aktualny czas:";
            // 
            // labelCurentTime
            // 
            labelCurentTime.AutoSize = true;
            labelCurentTime.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelCurentTime.ForeColor = Color.Black;
            labelCurentTime.Location = new Point(47, 293);
            labelCurentTime.Name = "labelCurentTime";
            labelCurentTime.Size = new Size(96, 37);
            labelCurentTime.TabIndex = 13;
            labelCurentTime.Text = "label1";
            // 
            // buttonRefreshTime
            // 
            buttonRefreshTime.Location = new Point(47, 354);
            buttonRefreshTime.Name = "buttonRefreshTime";
            buttonRefreshTime.Size = new Size(171, 55);
            buttonRefreshTime.TabIndex = 14;
            buttonRefreshTime.Text = "Odswiez czas";
            buttonRefreshTime.UseVisualStyleBackColor = true;
            buttonRefreshTime.Click += buttonRefreshTime_Click;
            // 
            // timerRefreshTime
            // 
            timerRefreshTime.Enabled = true;
            timerRefreshTime.Interval = 1000;
            timerRefreshTime.Tick += timerRefreshTime_Tick;
            // 
            // labelMouseClick
            // 
            labelMouseClick.AutoSize = true;
            labelMouseClick.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMouseClick.Location = new Point(336, 293);
            labelMouseClick.Name = "labelMouseClick";
            labelMouseClick.Size = new Size(167, 21);
            labelMouseClick.TabIndex = 15;
            labelMouseClick.Text = "Nie kliknieto jeszcze";
            labelMouseClick.MouseClick += labelMouseClick_MouseClick;
            // 
            // numericUpDownFirstNumber
            // 
            numericUpDownFirstNumber.Location = new Point(371, 440);
            numericUpDownFirstNumber.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownFirstNumber.Name = "numericUpDownFirstNumber";
            numericUpDownFirstNumber.Size = new Size(120, 23);
            numericUpDownFirstNumber.TabIndex = 16;
            // 
            // numericUpDownSecondNumber
            // 
            numericUpDownSecondNumber.Location = new Point(520, 440);
            numericUpDownSecondNumber.Name = "numericUpDownSecondNumber";
            numericUpDownSecondNumber.Size = new Size(120, 23);
            numericUpDownSecondNumber.TabIndex = 17;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(345, 491);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(57, 24);
            buttonAdd.TabIndex = 18;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(434, 491);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(57, 24);
            buttonSub.TabIndex = 19;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            // 
            // buttonMul
            // 
            buttonMul.Location = new Point(520, 491);
            buttonMul.Name = "buttonMul";
            buttonMul.Size = new Size(57, 24);
            buttonMul.TabIndex = 20;
            buttonMul.Text = "*";
            buttonMul.UseVisualStyleBackColor = true;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(594, 491);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(57, 24);
            buttonDiv.TabIndex = 21;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(371, 538);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(43, 15);
            labelResult.TabIndex = 22;
            labelResult.Text = "Wynik:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 648);
            Controls.Add(labelResult);
            Controls.Add(buttonDiv);
            Controls.Add(buttonMul);
            Controls.Add(buttonSub);
            Controls.Add(buttonAdd);
            Controls.Add(numericUpDownSecondNumber);
            Controls.Add(numericUpDownFirstNumber);
            Controls.Add(labelMouseClick);
            Controls.Add(buttonRefreshTime);
            Controls.Add(labelCurentTime);
            Controls.Add(labelCurentTimeDescription);
            Controls.Add(labelFavouriteMeal);
            Controls.Add(comboBoxFavouriteMeal);
            Controls.Add(labelPizzaQuestion);
            Controls.Add(radioButtonPizzaQuestionNo);
            Controls.Add(radioButtonPizzaQuestionYes);
            Controls.Add(label2);
            Controls.Add(labelSchoolSubject);
            Controls.Add(checkBoxSchoolSubjectGerman);
            Controls.Add(checkBoxSchoolSubjectMathematics);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(buttonHello);
            Name = "MainForm";
            Text = "Pierwsza aplikacja desktopowa";
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonHello;
        private TextBox textBoxName;
        private Label labelName;
        private CheckBox checkBoxSchoolSubjectMathematics;
        private CheckBox checkBoxSchoolSubjectGerman;
        private Label labelSchoolSubject;
        private Label label2;
        private RadioButton radioButtonPizzaQuestionYes;
        private RadioButton radioButtonPizzaQuestionNo;
        private Label labelPizzaQuestion;
        private NotifyIcon notifyIcon1;
        private ComboBox comboBoxFavouriteMeal;
        private Label labelFavouriteMeal;
        private Label labelCurentTimeDescription;
        private Label labelCurentTime;
        private Button buttonRefreshTime;
        private System.Windows.Forms.Timer timerRefreshTime;
        private Label labelMouseClick;
        private NumericUpDown numericUpDownFirstNumber;
        private NumericUpDown numericUpDownSecondNumber;
        private Button buttonAdd;
        private Button buttonSub;
        private Button buttonMul;
        private Button buttonDiv;
        private Label labelResult;
    }
}