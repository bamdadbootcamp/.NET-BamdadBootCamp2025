using BookStore.BL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Presentation.Forms.Book
{
    public partial class BookListForm : Form
    {
        public BookListForm()
        {
            InitializeComponent();
            _data = new BL.Entities.Book[0];
        }

        private BL.Entities.Book[] _data;
        private void BookList_Load(object sender, EventArgs e)
        {
            //BL.Entities.Book[] books = new BL.Entities.Book[3];

            //BL.Entities.Book book1 = new(
            //        "clean arch",
            //        234000000,
            //        300,
            //        "4257247",
            //        DateOnly.FromDateTime(DateTime.Now)
            //        );
            //books[0] = book1;

            //BL.Entities.Book book2 = new(
            //        "C# in nutshell",
            //        10000000,
            //        200,
            //        "2352",
            //        DateOnly.FromDateTime(DateTime.Now)
            //        );
            //books[1] = book2;

            //BL.Entities.Book book3 = new(
            //        "صد سال تنهایی",
            //        23500000,
            //        700,
            //        "28945671",
            //        DateOnly.FromDateTime(DateTime.Now)
            //        );
            //book3.RentPricePerDay = 10000;

            //books[2] = book3;

            //bookGridView.DataSource = books;
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            AddOrEditBookForm addOrEditBookForm = new AddOrEditBookForm();  
            DialogResult dialogResult = addOrEditBookForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                BL.Entities.Book book = new(
                    addOrEditBookForm.NameValue,
                    addOrEditBookForm.PriceValue,
                    addOrEditBookForm.PageCountValue,
                    addOrEditBookForm.IsbnValue,
                    addOrEditBookForm.PublishDateTimeValue
                    )
                {
                    RentPricePerDay = addOrEditBookForm.RentPriceValue,
                    FinePricePerDay = addOrEditBookForm.FinePriceValue,
                };

                Array.Resize(ref _data, _data.Length + 1);
                _data[_data.Length - 1] = book;
                bookGridView.DataSource = _data;
            }
            
        }
    }
}
