using Bamdad.WinForm.Inheritance;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();


            Motorcycle motorcycle1 = new Motorcycle();
            motorcycle1.compa
            Car car1 = new Car();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            InformationEntryForm entryForm = new InformationEntryForm();

            var result = entryForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // NOT SAFE
                firstNameTextBox.Text = entryForm.FirstName.Text;

                // SAFE
                lastNameTextBox.Text = entryForm.LastNameText;  
            }


        }
    }
}
