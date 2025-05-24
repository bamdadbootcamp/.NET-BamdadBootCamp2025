using BookStore.BL.Services;

namespace BookStore.Presentation.Forms.Book
{
    public partial class BookListForm : Form
    {
        public BookListForm()
        {
            InitializeComponent();
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            RefreshData();

            


        }

        private void RefreshData()
        {
            bookGridView.DataSource = null;
            bookGridView.DataSource = BookService.GetAll();

            bookGridView.Columns["Id"].Visible = false;
            bookGridView.Columns["Name"].HeaderText = "عنوان کتاب";
            bookGridView.Columns["Price"].HeaderText = "قیمت";
            bookGridView.Columns["ISBN"].HeaderText = "شابک";
            bookGridView.Columns["Publisher"].HeaderText = "انتشارات";
            bookGridView.Columns["RentPricePerDay"].HeaderText = "اجاره بها";
            bookGridView.Columns["FinePricePerDay"].Visible = false;
            bookGridView.Columns["Publisher"].HeaderText = "انتشارات";
            bookGridView.Columns["PageCount"].HeaderText = "تعداد صفحات";
            bookGridView.Columns["PublishDate"].HeaderText = "تاریخ انتشار";
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            AddOrEditBookForm addOrEditBookForm = new AddOrEditBookForm();
            DialogResult dialogResult = addOrEditBookForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                BookService.Create(addOrEditBookForm.NameValue,
                    addOrEditBookForm.PriceValue,
                    addOrEditBookForm.PageCountValue,
                    addOrEditBookForm.IsbnValue,
                    addOrEditBookForm.PublisherId
                    );
                RefreshData();
            }
        }
    }
}
