namespace Bamdad.WinForm.Forms
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
            firstNameTextBox = new TextBox();
            label1 = new Label();
            lastNameTextBox = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(108, 99);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.ReadOnly = true;
            firstNameTextBox.Size = new Size(210, 23);
            firstNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 102);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "First Name:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(108, 145);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.ReadOnly = true;
            lastNameTextBox.Size = new Size(210, 23);
            lastNameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 148);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // button1
            // 
            button1.Location = new Point(108, 197);
            button1.Name = "button1";
            button1.Size = new Size(210, 38);
            button1.TabIndex = 2;
            button1.Text = "Open Information Entry Form";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(137, 29);
            label3.Name = "label3";
            label3.Size = new Size(129, 37);
            label3.TabIndex = 3;
            label3.Text = "فرم اصلی";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 389);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Name = "MainForm";
            Text = "فرم اصلی";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextBox;
        private Label label1;
        private TextBox lastNameTextBox;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}