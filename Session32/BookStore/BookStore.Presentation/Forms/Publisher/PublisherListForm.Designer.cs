namespace BookStore.Presentation.Forms.Publisher
{
    partial class PublisherListForm
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 386);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 64);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(449, 15);
            button3.Name = "button3";
            button3.Size = new Size(109, 37);
            button3.TabIndex = 0;
            button3.Text = "حذف";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(564, 15);
            button2.Name = "button2";
            button2.Size = new Size(109, 37);
            button2.TabIndex = 0;
            button2.Text = "ویرایش";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(679, 15);
            button1.Name = "button1";
            button1.Size = new Size(109, 37);
            button1.TabIndex = 0;
            button1.Text = "جدید";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 62);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 324);
            dataGridView1.TabIndex = 3;
            // 
            // PublisherListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PublisherListForm";
            RightToLeft = RightToLeft.Yes;
            Text = "PublisherListForm";
            Load += PublisherListForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private DataGridView dataGridView1;
    }
}