﻿namespace GuessNumber.UI
{
    partial class Form1
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
            button1 = new Button();
            guessNumberTextBox = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(135, 34);
            button1.Name = "button1";
            button1.Size = new Size(176, 47);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // guessNumberTextBox
            // 
            guessNumberTextBox.Location = new Point(135, 133);
            guessNumberTextBox.Name = "guessNumberTextBox";
            guessNumberTextBox.Size = new Size(176, 23);
            guessNumberTextBox.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(135, 195);
            button2.Name = "button2";
            button2.Size = new Size(176, 43);
            button2.TabIndex = 2;
            button2.Text = "Check";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 383);
            Controls.Add(button2);
            Controls.Add(guessNumberTextBox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox guessNumberTextBox;
        private Button button2;
    }
}
