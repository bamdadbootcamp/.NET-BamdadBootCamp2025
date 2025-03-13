
using Session08.Folder1.Folder2.Folder3.Folder;
using System.Runtime.CompilerServices;

namespace Session08
{
    //public struct Person
    //{
    //    public string FirstName;
    //    public string LastName;
    //}
    internal class Program
    {





        //public static string GetFullName (Person person)
        //{
        //    string fullName = $"{person.FirstName} {person.LastName}";

        //    person.FirstName = "Behnam";

        //    return fullName;
        //}
        //public static int Sum(int num1, int num2)
        //{
        //    int result = num1 + num2;

        //    return result;
        //}


        //public static int Sum(int num1, int num2, int num3)
        //{
        //    return num1 + num2 + num3;
        //}

        //public static int Sum(string num1, string num2)
        //{
        //    return int.Parse(num1) + int.Parse(num2);
        //}

        //public static int Sum(params int[] numbers)
        //{
        //    int result = 0;
        //    foreach (int num in numbers)
        //    {
        //        result += num;
        //    }
        //    return result;
        //}
        //public enum Operation
        //{
        //    Sum,
        //    Mines,
        //    Division,
        //    Multiple
        //}
        //public static int Calculate(Operation operation, params int[] numbers)
        //{
        //    int result = 0;

        //    if (operation == Operation.Sum)
        //    {
        //        foreach (int num in numbers)
        //        {
        //            result += num;
        //        }
        //    }
        //    else if (operation == Operation.Mines)
        //    {
        //        foreach (int num in numbers)
        //        {
        //            result -= num;
        //        }
        //    }
        //    else if (operation == Operation.Multiple)
        //    {
        //        foreach (int num in numbers)
        //        {
        //            result *= num;
        //        }
        //    }
        //    else if (operation == Operation.Division)
        //    {
        //        foreach (int num in numbers)
        //        {
        //            result /= num;
        //        }
        //    }
        //    return result;
        //}

        //public static void WriteWithColor(string text, ConsoleColor color)
        //{
        //    Console.ForegroundColor = color;
        //    Console.Write(text);
        //    Console.ForegroundColor = ConsoleColor.White;
        //}

        static void Main(string[] args)
        {

            Person p1 = new Person("Navid","Tafreshi", DateOnly.Parse("1996-05-18"));
            //p1.FirstName = "Navid"; //  set
            //p1.LastName = "Tafreshi";

            //p1.UpdateFirstName("David");

            //p1.Birthdate = DateOnly.Parse("1996-05-18");


            

            Console.WriteLine(p1.FirstName);  // get
            Console.WriteLine(p1.LastName);  // get
            Console.WriteLine(p1.FullName);  // get
            Console.WriteLine(p1.Age);  // get
            Console.WriteLine(p1.GetAge());  // get

            //Console.WriteLine("Before forgound color");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("After forgound color");

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write("1");
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write("2");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.Write("3");

            //WriteWithColor("1", ConsoleColor.Red);
            //WriteWithColor("2", ConsoleColor.Green);
            //WriteWithColor("3", ConsoleColor.Yellow);

            //Console.WriteLine();
            //Console.WriteLine("Test");

            //Random rnd = new Random();
            //int myRandomNum = rnd.Next(0,10000);
            //Console.WriteLine(myRandomNum);

            //Random rnd = new Random();
            //rnd.NextDouble();

            //int counter = 0;

            //counter++;
            //int[] systemNumber = new int[5];
            //for (int i = 0; i < systemNumber.Length; i++)
            //{
            //    systemNumber[i] = rnd.Next(0, 10);
            //}
            //Console.WriteLine();

            //string input = "123";

            //StringHelper.ToNumber(input);

            //int num = int.Parse(input);


            //Person p1 = new Person()
            //{
            //    FirstName = "Navid",
            //    LastName = "Tafreshi"
            //};

            //string fullName = GetFullName(p1);


            //Console.WriteLine();
            //int num;
            //int.TryParse("123", out num);


            //int[] array;// = { 1, 2, 3 };


            //Array.Resize(ref array, 10);

            //int num1 = 10;
            //int num2 = 20;

            //int result = Sum(num1,ref num2);


            //Console.WriteLine(result);
            //Console.WriteLine(num2);

            //int[] navidNumbers = { 10, 20, 30, };

            //int result = Sum(navidNumbers);

            //Sum(1, 2, 3, 4, 5, 6, 7, 8);


            //Calculate(Operation.Sum, 10, 20, 30);

            //string inputString = "12345";

            //int[] numbers = new int[5];



            //char[] myCharArray = inputString.ToCharArray();

            //for (int i = 0; i < myCharArray.Length; i++)
            //{
            //    numbers[i] = int.Parse(myCharArray[i].ToString());
            //}

            //string text = "hello this is Bamdad";

            //string searchValue = "bamdad";

            //bool isContain = text.ToLower().Contains(searchValue.ToLower());

            ////text.Replace()


            //string sample1 = "ﮎ";
            //string sample2 = "ک";

            //char sample1char = char.Parse(sample1);
            //char sample2char = char.Parse(sample2);

            ////text.Replace("ﮎ", "ک").Replace("", "").Replace();


            //Sum(1, 2, 5);




        }
    }
}
