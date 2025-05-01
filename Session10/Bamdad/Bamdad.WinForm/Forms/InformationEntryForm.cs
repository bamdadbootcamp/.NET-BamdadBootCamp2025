using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bamdad.WinForm.Forms
{
    public partial class InformationEntryForm : Form
    {
        public InformationEntryForm()
        {
            InitializeComponent();
        }

        public TextBox FirstName
        {
            get { return firstNameTextBox; }
        }
        public string LastNameText
        {
            get { return lastNameTextBox.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text)
                || string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                MessageBox.Show("Sorry, You have to enter information"
                    , caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?"
                    , caption: "Warning", buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Warning);
            
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                //DialogResult = DialogResult.Cancel;
            }
        }
    }
}
