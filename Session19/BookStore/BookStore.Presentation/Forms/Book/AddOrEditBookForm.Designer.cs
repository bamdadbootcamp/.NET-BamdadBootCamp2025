namespace BookStore.Presentation.Forms.Book
{
    partial class AddOrEditBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrEditBookForm));
            label1 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            priceTextBox = new TextBox();
            label3 = new Label();
            rentPriceTextBox = new TextBox();
            label4 = new Label();
            FinePriceTextBox = new TextBox();
            label5 = new Label();
            pagesCountTextBox = new TextBox();
            label6 = new Label();
            isbnTextBox = new TextBox();
            label7 = new Label();
            publishDateTimePicker = new DateTimePicker();
            panel1 = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(571, 58);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "نام کتاب:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(424, 55);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(141, 23);
            nameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(571, 88);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "قیمت:";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(424, 85);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(141, 23);
            priceTextBox.TabIndex = 1;
            priceTextBox.KeyPress += priceTextBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 118);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 0;
            label3.Text = "اجاره بها:";
            // 
            // rentPriceTextBox
            // 
            rentPriceTextBox.Location = new Point(424, 115);
            rentPriceTextBox.Name = "rentPriceTextBox";
            rentPriceTextBox.Size = new Size(141, 23);
            rentPriceTextBox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(571, 147);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 0;
            label4.Text = "مبلغ جریمه:";
            // 
            // FinePriceTextBox
            // 
            FinePriceTextBox.Location = new Point(424, 144);
            FinePriceTextBox.Name = "FinePriceTextBox";
            FinePriceTextBox.Size = new Size(141, 23);
            FinePriceTextBox.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(251, 61);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 0;
            label5.Text = "تعداد صفحات:";
            // 
            // pagesCountTextBox
            // 
            pagesCountTextBox.Location = new Point(104, 58);
            pagesCountTextBox.Name = "pagesCountTextBox";
            pagesCountTextBox.Size = new Size(141, 23);
            pagesCountTextBox.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(251, 88);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 0;
            label6.Text = "شابک:";
            // 
            // isbnTextBox
            // 
            isbnTextBox.Location = new Point(104, 85);
            isbnTextBox.Name = "isbnTextBox";
            isbnTextBox.Size = new Size(141, 23);
            isbnTextBox.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(251, 118);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 0;
            label7.Text = "تاریخ نشر:";
            // 
            // publishDateTimePicker
            // 
            publishDateTimePicker.Location = new Point(45, 112);
            publishDateTimePicker.Name = "publishDateTimePicker";
            publishDateTimePicker.Size = new Size(200, 23);
            publishDateTimePicker.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 49);
            panel1.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(496, 12);
            label8.Name = "label8";
            label8.Size = new Size(126, 25);
            label8.TabIndex = 1;
            label8.Text = "ثبت کتاب جدید";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(628, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 34);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 173);
            panel2.Name = "panel2";
            panel2.Size = new Size(668, 54);
            panel2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(12, 7);
            button2.Name = "button2";
            button2.Size = new Size(75, 39);
            button2.TabIndex = 1;
            button2.Text = "انصراف";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(606, 7);
            button1.Name = "button1";
            button1.Size = new Size(54, 39);
            button1.TabIndex = 0;
            button1.Text = "ثبت";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddOrEditBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 227);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(publishDateTimePicker);
            Controls.Add(isbnTextBox);
            Controls.Add(pagesCountTextBox);
            Controls.Add(FinePriceTextBox);
            Controls.Add(rentPriceTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddOrEditBookForm";
            RightToLeft = RightToLeft.Yes;
            Text = "AddOrEditBookForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private TextBox priceTextBox;
        private Label label3;
        private TextBox rentPriceTextBox;
        private Label label4;
        private TextBox FinePriceTextBox;
        private Label label5;
        private TextBox pagesCountTextBox;
        private Label label6;
        private TextBox isbnTextBox;
        private Label label7;
        private DateTimePicker publishDateTimePicker;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Label label8;
        private PictureBox pictureBox1;
    }
}