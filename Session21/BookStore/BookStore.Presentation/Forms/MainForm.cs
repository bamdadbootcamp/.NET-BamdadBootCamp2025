﻿using BookStore.Domain.Entities;
using BookStore.Presentation.Forms.Book;
using BookStore.Presentation.Forms.Publisher;
using Common.CollectionExtensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        // step 4 : declare a method for event
        public int OnBookPriceUpdatedEvent(string bookName, decimal newPrice)
        {
            MessageBox.Show($"Update price on {bookName}, New price {newPrice}");

            return 550;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void bookListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookListForm bookListForm = new BookListForm();
            bookListForm.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PublisherListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublisherListForm publisherListForm = new PublisherListForm();
            publisherListForm.Show();
        }
    }
}


