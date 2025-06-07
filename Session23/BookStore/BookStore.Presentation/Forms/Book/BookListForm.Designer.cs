namespace BookStore.Presentation.Forms.Book
{
    partial class BookListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookListForm));
            bookGridView = new DataGridView();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            addBookButton = new Button();
            ((System.ComponentModel.ISupportInitialize)bookGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bookGridView
            // 
            bookGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bookGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookGridView.Dock = DockStyle.Fill;
            bookGridView.Location = new Point(0, 0);
            bookGridView.MultiSelect = false;
            bookGridView.Name = "bookGridView";
            bookGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bookGridView.Size = new Size(1064, 669);
            bookGridView.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(addBookButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 620);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 49);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Location = new Point(750, 7);
            button3.Name = "button3";
            button3.Size = new Size(96, 34);
            button3.TabIndex = 0;
            button3.Text = "حذف کتاب";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(852, 7);
            button2.Name = "button2";
            button2.Size = new Size(96, 34);
            button2.TabIndex = 0;
            button2.Text = "ویرایش کتاب";
            button2.UseVisualStyleBackColor = true;
            // 
            // addBookButton
            // 
            addBookButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addBookButton.Image = (Image)resources.GetObject("addBookButton.Image");
            addBookButton.ImageAlign = ContentAlignment.MiddleLeft;
            addBookButton.Location = new Point(954, 7);
            addBookButton.Name = "addBookButton";
            addBookButton.Size = new Size(104, 34);
            addBookButton.TabIndex = 0;
            addBookButton.Text = "ثبت کتاب جدید";
            addBookButton.TextAlign = ContentAlignment.MiddleRight;
            addBookButton.UseVisualStyleBackColor = true;
            addBookButton.Click += addBookButton_Click;
            // 
            // BookListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 669);
            Controls.Add(panel1);
            Controls.Add(bookGridView);
            Name = "BookListForm";
            RightToLeft = RightToLeft.Yes;
            Text = "لیست کتاب ها";
            Load += BookList_Load;
            ((System.ComponentModel.ISupportInitialize)bookGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView bookGridView;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button addBookButton;
    }
}