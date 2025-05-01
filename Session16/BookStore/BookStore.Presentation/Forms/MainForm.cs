using BookStore.BL.Entities;
using BookStore.Presentation.Forms.Book;
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

            //ArrayList array = new ArrayList();
            ////BOXING
            //array.Add("text1");
            //array.Add(DateTime.Now);
            //array.Add(new InstanceMember());
            //array.Add("text2");
            //array.Add(2);
            //array.Add("Hi");

            ////UNBOXING
            //foreach (var item in array)
            //{
            //    MessageBox.Show(item.ToString());
            //}

            // SAFE

            //List<int> array = new List<int>();
            //array.Add(1);
            //array.Add("");

            // BOXING - UNBOXING   => Collection non generic

            // List<string> list = new List<int>();
            //Dictionary<string , string> dic = new Dictionary<string , string>();

            //dic.Add("key1", "value1");
            //dic.Add("key1", "value2");

            //HashSet<string> set = new HashSet<string>();
            //set.Add("hello");
            //set.Add("hello");



            // non generic => ArrayList
            // generic => List<T> , Dictionary<TKey, TValue> , HashSet<T>


            // کالکشن های صفی

            // FIFO => First Input , First Output
            //Queue<int> queueList = new Queue<int>();
            //queueList.Enqueue(1);
            //queueList.Enqueue(2);
            //queueList.Enqueue(3);
            //queueList.Enqueue(4);


            //MessageBox.Show(queueList.Peek().ToString());

            //MessageBox.Show(queueList.Dequeue().ToString());
            //MessageBox.Show(queueList.Dequeue().ToString());
            //MessageBox.Show(queueList.Dequeue().ToString());
            //MessageBox.Show(queueList.Dequeue().ToString());

            //queueList.Clear();


            // FILO => First Input , Last Output
            //Stack<int> stackList = new Stack<int>();
            //stackList.Push(1);
            //stackList.Push(2);
            //stackList.Push(3);
            //stackList.Push(4);

            //stackList.Peek().ToString();
            //MessageBox.Show(stackList.Pop().ToString());
            //MessageBox.Show(stackList.Pop().ToString());
            //MessageBox.Show(stackList.Pop().ToString());
            //MessageBox.Show(stackList.Pop().ToString());


            //Book book = new Book("", 1000, 10, "", DateOnly.MaxValue);
            //book.BookPriceUpdatedEvent += (a, b) =>
            //{
            //    MessageBox.Show($"Update price on {a}, New price {b}");
            //};



            //book.UpdatePrice(100);

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //List<Book>
            //var list = numbers.Where(w => w > 3);

             //Action<>
            // Func
            // Func<>
            //ProcessNumbers(numbers, (n1, n2) =>
            //{
            //    return n1 * n2;
            //});

            //ProcessNumbers(numbers, (n1, n2) =>
            //{
            //    return n1 * n2;
            //});
            //ProcessNumbers(numbers, (n1, n2) =>
            //{
            //    return n1 + n2;
            //});
            //ProcessNumbers(numbers, (n1, n2) =>
            //{
            //    return (int)Math.Pow(n1, n2);
            //});


            //ProcessNumbers(numbers, Sum);

        }
        public int Sum(int num1 , int num2)
        {

            return num1 + num2;
        }

        public delegate int NumberOperation(int num1, int num2);

        public int ProcessNumbers(List<int> numbers, NumberOperation operation)
        {
            int result = 0;
            foreach (var num in numbers)
            {
                result += operation(result, num);
            }
            return result;
        }

        
    }
}


