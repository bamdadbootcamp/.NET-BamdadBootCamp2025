namespace BookStore.Presentation.Forms.Publisher
{
    partial class AddOrEditPublisherForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            titleTextBox = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 53);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 42);
            panel2.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(342, 7);
            button2.Name = "button2";
            button2.Size = new Size(115, 32);
            button2.TabIndex = 0;
            button2.Text = "انصراف";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(463, 7);
            button1.Name = "button1";
            button1.Size = new Size(115, 32);
            button1.TabIndex = 0;
            button1.Text = "ثبت";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(245, 94);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(252, 23);
            titleTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(503, 97);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 2;
            label1.Text = "نام انتشارات:";
            // 
            // AddOrEditPublisherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 182);
            Controls.Add(label1);
            Controls.Add(titleTextBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddOrEditPublisherForm";
            RightToLeft = RightToLeft.Yes;
            Text = "AddOrEditPublisherForm";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox titleTextBox;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}