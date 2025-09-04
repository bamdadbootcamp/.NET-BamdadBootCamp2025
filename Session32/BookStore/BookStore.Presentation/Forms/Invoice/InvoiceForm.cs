using BookStore.BL.Dto;
using BookStore.BL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Presentation.Forms.Invoice
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var book1 = Domain.Entities.Book.Create("1984", 100000, 200, "1234567890123");
            //var book2 = Domain.Entities.Book.Create("tantan", 200000, 200, "1234567890123");
            //var book3 = Domain.Entities.Book.Create("c#", 300000, 200, "1234567890123");
            //var book4 = Domain.Entities.Book.Create("english", 400000, 200, "1234567890123");


            //List<AddInvoiceDto> addInvoiceDtos = new List<AddInvoiceDto>();
            //addInvoiceDtos.Add(new AddInvoiceDto()
            //{
            //    Book = book1,
            //    Quantity = 1,
            //});
            //addInvoiceDtos.Add(new AddInvoiceDto()
            //{
            //    Book = book2,
            //    Quantity = 1,
            //});
            //addInvoiceDtos.Add(new AddInvoiceDto()
            //{
            //    Book = book3,
            //    Quantity = 3,
            //});
            //addInvoiceDtos.Add(new AddInvoiceDto()
            //{
            //    Book = book4,
            //    Quantity = 2,
            //});
            //SaleInvoiceService.NewInvoice(addInvoiceDtos);

            //dataGridView1.DataSource = SaleInvoiceService.GetAll();

        }
    }
}
