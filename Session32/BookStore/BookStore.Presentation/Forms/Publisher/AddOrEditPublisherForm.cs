namespace BookStore.Presentation.Forms.Publisher
{
    public partial class AddOrEditPublisherForm : Form
    {
        public AddOrEditPublisherForm()
        {
            InitializeComponent();
        }


        public string PublisherTitle
        {
            get { return titleTextBox.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
