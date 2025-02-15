


////int num1 = 10;

////Console.WriteLine(num1);

////num1 = 20;

////Console.WriteLine(num1);

//////int num2 = num1;


//int num1 = 20;
//int num2 = 6;

//int sum = num1 + num2;
//int multiple = num1 * num2;
//int devide = num1 / num2;
//int mines = num1 - num2;
//int division = num1 % num2;
//int num1PlusOne = num1++;
//int num1MinesOne = num1--;

//string welcomeText = "Hello Bamdad";

//Console.WriteLine(welcomeText);


//string t1 = "10";
//string t2 = "20";

//string t3 = t1 + t2;
//Console.WriteLine(t1 + t2);


//string text = 10;

//char myChar = 'g';

//// boolean
//bool myBoolean1 = false;
//bool myBoolean2 = true;


//// GARBAGE COLLECTOR

//bool condition1 = 10 > 3;
//bool condition2 = 10 >= 3;
//bool condition3 = 10 < 3;
//bool condition4 = 10 <= 3;
//bool condition5 = 10 == 11;
//bool condition6 = 10 != 11;

//int num1 = 10;
//int num2 = 20;

//bool cond = num1 == num2;



//    if ( bool:CONDITION )


//bool myCondition = 20 > 11;

////if (myCondition == false)
//if (!myCondition)
//{
//    Console.WriteLine("OK");
//}
//else
//{

//}


//string inputText = Console.ReadLine();
//Console.WriteLine(inputText);

//Console.WriteLine("Welcome");
//Console.WriteLine("Please enter your age");

//string inputText = Console.ReadLine();
//int age = int.Parse(inputText);


//bool condition = age >= 18;

//if (condition)
//{
//    Console.WriteLine("Welcome");
//}
//else
//{
//    Console.WriteLine("Sorry, Bye");
//}


//int averageScore = 19;
//int mathScore = 17;

//bool condition1 = averageScore >= 18;
//bool condition2 = mathScore >= 16;
//bool condition3 = true;  
//bool condition4 = true;


//bool test = condition1 && condition2 && condition3 && condition4;


//bool ANDcond = condition1 && condition2;
//bool ORcond = condition1 || condition2;

//int num1;
//string mytext;
//Console.WriteLine(num1);

//bool? mycondition;

//if (mycondition)
//{

//}

// EXCEPTIONS
// 1- Compile Time Exception
// 2- Run Time Exception

//Console.WriteLine("Please select game level");
//Console.WriteLine("[1]: Easy");
//Console.WriteLine("[2]: Medium");
//Console.WriteLine("[3]: Hard");

////string inputText = Console.ReadLine();
////int level = int.Parse(inputText);

//int level = int.Parse(Console.ReadLine());

//if (level == 1)
//{
//    Console.WriteLine("1");
//}
//else if (level == 2)
//{
//    Console.WriteLine("2");
//}
//else if (level == 3)
//{
//    Console.WriteLine("3");
//}
//else
//{
//    Console.WriteLine("Wrong Number");
//}

//decimal myvar = ;

//decimal price = 100000.00m / 3;


//decimal price2 = 10.2m;

//decimal salary = 100_000_000_000;

//Console.WriteLine();


//DateTime birt = DateTime.Parse("1996-05-18 06:18:32");

//DateTime now = DateTime.Now;

//TimeSpan duration = now - navidBirthday;

//DateOnly dateOnly = DateOnly.FromDateTime(now);
//TimeOnly timeOnly = TimeOnly.FromDateTime(now);

//TimeSpan 
//DateTime now1 = DateTime.Now;
//DateTime now2 = DateTime.Now;

//                DateTime DateTime
//                TimeOnly TimeOnly
//                DateOnly DateOnly
//                DateTime TimeOnly => ERROR
//TimeSpan duration = now1 - now2;

//DateTime minValue = DateTime.MinValue;
//DateTime maxValue = DateTime.MaxValue;

//DateTime date = DateTime.Now;

////date = date.AddDays(100); 



//Console.WriteLine(date.DayOfWeek);
//Console.WriteLine(date.Minute);
//Console.WriteLine(date.DayOfYear);
//Console.WriteLine(date.Date);

//string num = "10";
//var num1 = 100000000000;

//Console.WriteLine(num1.GetType());

string text = "A";

switch (text)
{
    case "A":
        Console.WriteLine("");
        break;
    case "B":
        Console.WriteLine("B");
        break;
    case "C":
        Console.WriteLine("C");
        break;
    default:
        Console.WriteLine("Default");
        break;
}
// ---------------------------------------------------
if (text == "A")
{
    Console.WriteLine("A");
}
else if (text == "B")
{
    Console.WriteLine("B");
}
else if (text == "C")
{
    Console.WriteLine("C");
}
else
{
    Console.WriteLine("Default");
}
