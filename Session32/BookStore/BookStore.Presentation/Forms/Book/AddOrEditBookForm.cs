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

namespace BookStore.Presentation.Forms.Book
{
    public partial class AddOrEditBookForm : Form
    {
        public AddOrEditBookForm()
        {
            InitializeComponent();
        }

        public string NameValue
        {
            get { return nameTextBox.Text; }
        }
        public decimal PriceValue
        {
            get { return decimal.Parse(priceTextBox.Text); }
        }
        public decimal RentPriceValue
        {
            get { return decimal.Parse(rentPriceTextBox.Text); }
        }
        public decimal FinePriceValue
        {
            get { return decimal.Parse(FinePriceTextBox.Text); }
        }
        public int PageCountValue
        {
            get { return int.Parse(pagesCountTextBox.Text); }
        }
        public string IsbnValue
        {
            get { return isbnTextBox.Text; }
        }

        public DateOnly PublishDateTimeValue
        {
            get { return DateOnly.FromDateTime(DateTime.Parse(publishDateTimePicker.Text)); }
        }

        public int PublisherId
        {
            get 
            {
                int id;
                bool result = int.TryParse(publisherComboBox.SelectedValue.ToString(), out id);
                return id;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool isNameValid = false;
            bool isPriceValid = false;
            bool isRentValid = false;
            bool isFinePriceValid = false;
            bool isPageCountValid = false;
            bool isIsbnValid = false;
            bool isPublishDateValid = false;

            if (!string.IsNullOrEmpty(nameTextBox.Text)
                && nameTextBox.Text.Length > 2
                && nameTextBox.Text.Length <= 100)
            {
                isNameValid = true;
            }

            if (!string.IsNullOrEmpty(priceTextBox.Text))
            {
                decimal price = 0;
                bool isValid = decimal.TryParse(priceTextBox.Text, out price);
                if (isValid)
                {
                    isPriceValid = true;
                }
            }

            if (!string.IsNullOrEmpty(rentPriceTextBox.Text))
            {
                decimal price = 0;
                bool isValid = decimal.TryParse(rentPriceTextBox.Text, out price);
                if (isValid)
                {
                    isRentValid = true;
                }
            }
            else
                isRentValid = true;

            if (!string.IsNullOrEmpty(FinePriceTextBox.Text))
            {
                decimal price = 0;
                bool isValid = decimal.TryParse(FinePriceTextBox.Text, out price);
                if (isValid)
                {
                    isFinePriceValid = true;
                }
            }
            else
                isFinePriceValid = true;

            if (!string.IsNullOrEmpty(pagesCountTextBox.Text))
            {
                int price = 0;
                bool isValid = int.TryParse(pagesCountTextBox.Text, out price);
                if (isValid)
                {
                    isPageCountValid = true;
                }
            }

            if (!string.IsNullOrEmpty(isbnTextBox.Text)
                && isbnTextBox.Text.Length == 13)
            {
                isIsbnValid = true;
            }

            if (!string.IsNullOrEmpty(publishDateTimePicker.Text))
            {
                DateOnly value = DateOnly.MinValue;
                bool isValid = DateOnly.TryParse(publishDateTimePicker.Text, out value);
                if (isValid)
                {
                    isPublishDateValid = true;
                }
            }

            

            if (
                isNameValid &&
                isPriceValid &&
                isRentValid &&
                isFinePriceValid &&
                isPageCountValid &&
                isIsbnValid &&
                isPublishDateValid)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("فرم شما شامل خطا های زیر میباشد:");
                if (!isNameValid)
                    builder.AppendLine("نام");
                if (!isPriceValid)
                    builder.AppendLine("قیمت");
                if (!isRentValid)
                    builder.AppendLine("اجاره بها");
                if (!isFinePriceValid)
                    builder.AppendLine("مبلغ جریمه");
                if (!isPageCountValid)
                    builder.AppendLine("تعداد صفحات");
                if (!isIsbnValid)
                    builder.AppendLine("شابک");
                if (!isPublishDateValid)
                    builder.AppendLine("تاریخ نشر");

                MessageBox.Show(builder.ToString(), "خطا", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }


        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void AddOrEditBookForm_Load(object sender, EventArgs e)
        {
            publisherComboBox.DataSource = PublisherService.GetAll();
            
            publisherComboBox.ValueMember = "Id";
            publisherComboBox.DisplayMember = "TItle";

        }
    }
}
