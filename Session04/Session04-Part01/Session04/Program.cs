

//for (int i = 1; i < 100; i++) // SIGNATURE
//{
//    // BODY

//    Console.WriteLine(i);
//}


//int i = 0;
//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i < 10);



//while (CONDITION)
//{
//    BODY
//         }


//Console.WriteLine("First name:");
//string firstName = Console.ReadLine();

//Console.WriteLine("Last name:");
//string lastName = Console.ReadLine();

//// Welcome Mr. Mehrdad Shojaei

////string welcomeText1 = "Welcome Mr." + firstName + " " + lastName;

////string welcomeText2 = $"Welcome Mr. {firstName} {lastName}";

//string welcomeText3 = string.Format("Welcome Mr. {0} {1}", firstName, lastName);

//Console.WriteLine(welcomeText3);

//int num1 = 0;
//int num2 = 0;

//do
//{
//    Console.Clear();

//    Console.WriteLine("your first number must be less than second one");

//    Console.WriteLine("Enter first number:");
//    num1 = int.Parse(Console.ReadLine());

//    Console.WriteLine("Enter second: number:");
//    num2 = int.Parse(Console.ReadLine());

//    if (num1 < num2)
//    {
//        break;
//    }

//} while (true); // num1 > num2
//Console.Clear();

//int skipNumber = 0;
//do
//{
//    Console.Clear();
//    Console.WriteLine("Enter a skip number:");
//    Console.WriteLine($"Skip number must be between {num1} and {num2}");
//    skipNumber = int.Parse(Console.ReadLine());

//    if (skipNumber > num1 && skipNumber < num2)
//        break;

//    //} while (skipNumber < num1 || skipNumber > num2);
//} while (true);

//for (int i = num1; i <= num2; i++)
//{
//    if (i == skipNumber)
//        continue;
//    Console.WriteLine(i);
//}

//انواع تبدیل ها
// 1- Implicit تبدیل ضمنی
// در این نوع تبدیل شما نیاز به نوشتن کد خاصی ندارید ومیتوانید
// مقادیر 2 نوع متغیر را بدون عمل تبدیل در دیگری قرار دهید
// این تبدیل توسط خود دات نت انجام شدع و تنها زمانی قابل انجام
// است که از داده های هم جنس استفاده کنیم و مقدار کوچیکتر
// به بزرگتر ریخته شود

//int num1 = 10;
//long num2 = num1;

//long num1 = 10;
//int num2 = num1;


//2 - Explicit
// برای این تبدیل شما باید از دستورات اسفاده کنید
// 1-Parse
// 2-ToString
// 3-TryParse
// 4-Convert
// 5-Cast

// عمل casting
// برای دیتا های هم جنس ولی با رنج متفاوت
// داخل پرانتز دیتا تایپ مقصد را مینویسیم

//long num1 = 500;
//int num5 = (int)num1;

//مشکل این عمل : شرط سر ریز شدن چک نمیشود 
// رخ میدهد overflow


// Convert

//int num2 = Convert.ToInt32(num1);


//Console.ReadLine();


//آرایه Array

//   <DATA TYPE>[] <Array Name>;
//در زبان سی شارپ شما برای استفاده از یک آرایه
// باید حتما آنرا مقدار دهی اولیه کنید
// Initialize

// در مقدار دهی اولیه شما حتما باید طول آرایه را 
// مشخص کنید. برای اینکار از کلمه کلیدی 
// new
// به شکل زیر اشتفاده میکنیم

//  <DATA TYPE>[] < ARRAY NAME > = new < DATA TYPE > [LENGTH];

//index base آرایه ها 
//  میباشند . یعنی برای دسترسی به هر خانه باید شماره
// index
// آن ذکر شود
// اینکدس از 0 شروع میشود
// numbers[2] = 10;

//int[] numbers = new int[5];

//int[] numbers = new int[5] { 1, 5, 10, 0, -80 };

//numbers[0] = 1;
//numbers[1] = 5;
//numbers[2] = 10;
//numbers[3] = 0;
//numbers[4] = -80;

//numbers[0] = 2;

//int num1 = 10;
//num1 = 20;

//Console.WriteLine(numbers[4]);

//numbers
//        [1][5][10][0][-80]
// index    0    1     2    3     4
//Console.ReadLine();

//int[] numbers = new int[5] { 1, 5, 10, 0, -80 };

//Console.WriteLine(numbers);


//int[] numbers = new int[5] { 1, 5, 10, 0, -80 };


//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}


//string[] names = new string[10];
//names[0] = 10.ToString();

//long num = 10000;

//int[] numbers = new int[5];
//numbers[0] = (int)num;

//TryParse

//int num1 = int.Parse("25");

//int num1 = 0;
//bool isValid = int.TryParse("10k", out num1);

//Console.ReadLine();

//int num = 0;
//do
//{
//    Console.WriteLine("Azizam, Enter a number between 1 and 10");
//    bool isValid = int.TryParse(Console.ReadLine(), out num);
//    if (isValid && num >= 1 && num <= 10)
//        break;
//} while (true);

//Console.WriteLine("enter Y or F");
//string input = Console.ReadLine();

//if (input == "Y" || input == "F")
//    !=

//   < STRING >.ToLower
//if (input.ToLower() is "y" or "f")
//{


//}

//Console.WriteLine(Console.ReadLine().ToLower());
//Console.WriteLine(Console.ReadLine().ToUpper());

//do
//{
//    Console.WriteLine("Hello");

//    Console.WriteLine("Enter Y to repeat");

//    string input = Console.ReadLine();
//    if (input is not "Y" or "y")
//        break;

//} while (true);

//int[] numbers = new int[2] { 10, 20 };

//Array.Resize(ref numbers, numbers.Length + 1);

//Console.ReadLine();

//Console.WriteLine("How many numbers you want to add");
//int length = int.Parse(Console.ReadLine());

//int[] numbers = new int[length];

//Console.WriteLine("Enter numbers");

//for (int i = 0; i < length; i++)
//{
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//Console.ReadLine();


//Console.WriteLine("Enter your numbers");
//Console.WriteLine("For exit press E");
//int[] numbers = new int[0];
//do
//{
//    Console.WriteLine("Enter your number");
//    string inputValue = Console.ReadLine();
//    if (inputValue.ToLower() is "e")
//        break;
//    int num = 0;
//    bool isValid = int.TryParse(inputValue, out num);

//    if (isValid)
//    {
//        Array.Resize(ref numbers, numbers.Length + 1);
//        numbers[numbers.Length - 1] = num;
//    }
//    else
//    {
//        Console.WriteLine("Enter a valid number.");
//    }

//} while (true);


//Console.ReadLine();


