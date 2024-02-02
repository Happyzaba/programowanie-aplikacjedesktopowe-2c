namespace Egzamin
{
    partial class LoginApp
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
            labelRegister = new Label();
            labelMail = new Label();
            labelPassword = new Label();
            textBoxMail = new TextBox();
            textBoxPassword = new TextBox();
            labelRepeat = new Label();
            textBoxRepeat = new TextBox();
            buttonConfirm = new Button();
            labelHello = new Label();
            SuspendLayout();
            // 
            // labelRegister
            // 
            labelRegister.BackColor = Color.LightSeaGreen;
            labelRegister.Dock = DockStyle.Top;
            labelRegister.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegister.ForeColor = Color.Transparent;
            labelRegister.Location = new Point(0, 0);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(401, 40);
            labelRegister.TabIndex = 0;
            labelRegister.Text = "Rejestruj konto";
            labelRegister.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelMail.Location = new Point(5, 40);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(96, 20);
            labelMail.TabIndex = 1;
            labelMail.Text = "Podaj e-mail:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(5, 101);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(88, 20);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Podaj hasło:";
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(5, 63);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(103, 23);
            textBoxMail.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(5, 124);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(102, 23);
            textBoxPassword.TabIndex = 4;
            // 
            // labelRepeat
            // 
            labelRepeat.AutoSize = true;
            labelRepeat.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelRepeat.Location = new Point(5, 166);
            labelRepeat.Name = "labelRepeat";
            labelRepeat.Size = new Size(104, 20);
            labelRepeat.TabIndex = 5;
            labelRepeat.Text = "Powtórz hasło:";
            // 
            // textBoxRepeat
            // 
            textBoxRepeat.Location = new Point(7, 189);
            textBoxRepeat.Name = "textBoxRepeat";
            textBoxRepeat.Size = new Size(102, 23);
            textBoxRepeat.TabIndex = 6;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonConfirm.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirm.Location = new Point(119, 295);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(151, 54);
            buttonConfirm.TabIndex = 7;
            buttonConfirm.Text = "Zatwierdź";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // labelHello
            // 
            labelHello.AutoSize = true;
            labelHello.Location = new Point(140, 352);
            labelHello.Name = "labelHello";
            labelHello.Size = new Size(104, 15);
            labelHello.TabIndex = 8;
            labelHello.Text = "Witaj w programie";
            // 
            // LoginApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 450);
            Controls.Add(labelHello);
            Controls.Add(buttonConfirm);
            Controls.Add(textBoxRepeat);
            Controls.Add(labelRepeat);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxMail);
            Controls.Add(labelPassword);
            Controls.Add(labelMail);
            Controls.Add(labelRegister);
            Name = "LoginApp";
            Text = "Login App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRegister;
        private Label labelMail;
        private Label labelPassword;
        private TextBox textBoxMail;
        private TextBox textBoxPassword;
        private Label labelRepeat;
        private TextBox textBoxRepeat;
        private Button buttonConfirm;
        private Label labelHello;
    }
}