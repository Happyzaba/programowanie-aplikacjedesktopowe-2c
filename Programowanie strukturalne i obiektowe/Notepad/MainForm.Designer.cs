namespace Notepad
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
            menuStripMainMenu = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            nowyToolStripMenuItem = new ToolStripMenuItem();
            otwórzToolStripMenuItem = new ToolStripMenuItem();
            zapiszToolStripMenuItem = new ToolStripMenuItem();
            zapiszJakoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            zamknijToolStripMenuItem = new ToolStripMenuItem();
            edycjaToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            widokToolStripMenuItem = new ToolStripMenuItem();
            pomocToolStripMenuItem = new ToolStripMenuItem();
            textBoxNotepad = new TextBox();
            statusStripInfo = new StatusStrip();
            menuStripMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            menuStripMainMenu.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem, edycjaToolStripMenuItem, formatToolStripMenuItem, widokToolStripMenuItem, pomocToolStripMenuItem });
            menuStripMainMenu.Location = new Point(0, 0);
            menuStripMainMenu.Name = "menuStripMainMenu";
            menuStripMainMenu.Size = new Size(745, 24);
            menuStripMainMenu.TabIndex = 0;
            menuStripMainMenu.Text = "menuStrip";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nowyToolStripMenuItem, otwórzToolStripMenuItem, zapiszToolStripMenuItem, zapiszJakoToolStripMenuItem, toolStripMenuItem1, zamknijToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(38, 20);
            plikToolStripMenuItem.Text = "&Plik";
            // 
            // nowyToolStripMenuItem
            // 
            nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            nowyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            nowyToolStripMenuItem.Size = new Size(204, 22);
            nowyToolStripMenuItem.Text = "Nowy";
            nowyToolStripMenuItem.Click += nowyToolStripMenuItem_Click;
            // 
            // otwórzToolStripMenuItem
            // 
            otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            otwórzToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            otwórzToolStripMenuItem.Size = new Size(204, 22);
            otwórzToolStripMenuItem.Text = "Otwórz";
            // 
            // zapiszToolStripMenuItem
            // 
            zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            zapiszToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            zapiszToolStripMenuItem.Size = new Size(204, 22);
            zapiszToolStripMenuItem.Text = "Zapi&sz";
            // 
            // zapiszJakoToolStripMenuItem
            // 
            zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            zapiszJakoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            zapiszJakoToolStripMenuItem.Size = new Size(204, 22);
            zapiszJakoToolStripMenuItem.Text = "Zapisz jako";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(201, 6);
            // 
            // zamknijToolStripMenuItem
            // 
            zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            zamknijToolStripMenuItem.Size = new Size(204, 22);
            zamknijToolStripMenuItem.Text = "Zamknij";
            zamknijToolStripMenuItem.Click += zamknijToolStripMenuItem_Click;
            // 
            // edycjaToolStripMenuItem
            // 
            edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            edycjaToolStripMenuItem.Size = new Size(53, 20);
            edycjaToolStripMenuItem.Text = "&Edycja";
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "For&mat";
            // 
            // widokToolStripMenuItem
            // 
            widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            widokToolStripMenuItem.Size = new Size(53, 20);
            widokToolStripMenuItem.Text = "&Widok";
            // 
            // pomocToolStripMenuItem
            // 
            pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            pomocToolStripMenuItem.Size = new Size(57, 20);
            pomocToolStripMenuItem.Text = "Pomo&c";
            // 
            // textBoxNotepad
            // 
            textBoxNotepad.Dock = DockStyle.Fill;
            textBoxNotepad.Location = new Point(0, 24);
            textBoxNotepad.Multiline = true;
            textBoxNotepad.Name = "textBoxNotepad";
            textBoxNotepad.Size = new Size(745, 452);
            textBoxNotepad.TabIndex = 1;
            // 
            // statusStripInfo
            // 
            statusStripInfo.Location = new Point(0, 454);
            statusStripInfo.Name = "statusStripInfo";
            statusStripInfo.Size = new Size(745, 22);
            statusStripInfo.TabIndex = 2;
            statusStripInfo.Text = "statusStripInfo";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 476);
            Controls.Add(statusStripInfo);
            Controls.Add(textBoxNotepad);
            Controls.Add(menuStripMainMenu);
            MainMenuStrip = menuStripMainMenu;
            Name = "MainForm";
            Text = "Notatnik";
            menuStripMainMenu.ResumeLayout(false);
            menuStripMainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMainMenu;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem nowyToolStripMenuItem;
        private ToolStripMenuItem otwórzToolStripMenuItem;
        private ToolStripMenuItem zapiszToolStripMenuItem;
        private ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private ToolStripMenuItem zamknijToolStripMenuItem;
        private ToolStripMenuItem edycjaToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem widokToolStripMenuItem;
        private ToolStripMenuItem pomocToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private TextBox textBoxNotepad;
        private StatusStrip statusStripInfo;
    }
}