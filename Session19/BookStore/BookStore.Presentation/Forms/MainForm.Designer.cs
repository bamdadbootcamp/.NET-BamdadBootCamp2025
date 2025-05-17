namespace BookStore.Presentation
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            کتابهاToolStripMenuItem = new ToolStripMenuItem();
            bookListToolStripMenuItem = new ToolStripMenuItem();
            ثبتکتابجدیدToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { کتابهاToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(620, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // کتابهاToolStripMenuItem
            // 
            کتابهاToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookListToolStripMenuItem, ثبتکتابجدیدToolStripMenuItem });
            کتابهاToolStripMenuItem.Name = "کتابهاToolStripMenuItem";
            کتابهاToolStripMenuItem.Size = new Size(57, 20);
            کتابهاToolStripMenuItem.Text = "کتاب ها";
            // 
            // bookListToolStripMenuItem
            // 
            bookListToolStripMenuItem.Name = "bookListToolStripMenuItem";
            bookListToolStripMenuItem.Size = new Size(146, 22);
            bookListToolStripMenuItem.Text = "لیست کتاب ها";
            bookListToolStripMenuItem.Click += bookListToolStripMenuItem_Click;
            // 
            // ثبتکتابجدیدToolStripMenuItem
            // 
            ثبتکتابجدیدToolStripMenuItem.Name = "ثبتکتابجدیدToolStripMenuItem";
            ثبتکتابجدیدToolStripMenuItem.Size = new Size(146, 22);
            ثبتکتابجدیدToolStripMenuItem.Text = "ثبت کتاب جدید";
            // 
            // button1
            // 
            button1.Location = new Point(268, 170);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 410);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            Text = "کتابخانه بامداد";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem کتابهاToolStripMenuItem;
        private ToolStripMenuItem bookListToolStripMenuItem;
        private ToolStripMenuItem ثبتکتابجدیدToolStripMenuItem;
        private Button button1;
    }
}