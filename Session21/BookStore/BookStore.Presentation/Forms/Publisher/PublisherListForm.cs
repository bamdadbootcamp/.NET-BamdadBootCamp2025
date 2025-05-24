using BookStore.BL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Presentation.Forms.Publisher
{
    public partial class PublisherListForm : Form
    {
        public PublisherListForm()
        {
            InitializeComponent();
        }
        public void RefreshData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = PublisherService.GetAll();

            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Title"].HeaderText = "نام";
            dataGridView1.Columns["CreatedOn"].Visible = false;
            dataGridView1.Columns["LastModifiedDate"].Visible = false;
            dataGridView1.Columns["IsArchived"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOrEditPublisherForm publisherForm = new AddOrEditPublisherForm();
            var dialogResult = publisherForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                PublisherService.Create(publisherForm.PublisherTitle);
                RefreshData();
            }
        }

        private void PublisherListForm_Load(object sender, EventArgs e)
        {
            RefreshData();
            
        }
    }
}
