


// متغیر های عددی
// byte, short, int, long 
//      ushort,uint,ulong     منفی نمیپذیرند


//int num1 = 20;

//Console.WriteLine(num1);

//num1 = num1 + 10; ;

//Console.WriteLine(num1);

// رشته و کاراکتر
// char      string

//string firstName = "Sajad";
//string lastName = "Rezaei";
//byte age = 21;

//// Sajad Rezaei has 21 years old

//string result = firstName + " " + lastName + " has " + age.ToString() + " years old";
////Console.WriteLine(result);



//// <ANY DATA TYPE>   ==TO==> STRING           :    <DATA TYPE>.ToString()
////      STRING       ==TO==> <ANY DATA TYPE>  :   <ANY DATA TYPE>.Parse(<STRING VALUE>)

//string newResult = "{firstName} {lastName} has {age} years old";
//Console.WriteLine(newResult);


//bool cond1 = false;
//bool cond2 = true;
//bool cond3 =          234 >= 234      &&      10 > 6;
////   true              true          &&       true




//Console.WriteLine("Please enter your age");
//string inputText = Console.ReadLine();

//int age = int.Parse(Console.ReadLine());

// IF TERNARY OPERATOR
// <DATA TYPE> varname = <CONDITION 1> ? <VALUE 1> :
//                       <CONDITION 2> ? <VALUE 2> :
//                       <CONDITION 3> ? <VALUE 3> :
//                       <CONDITION 4> ? <VALUE 4> :
//                       <CONDITION 5> ? <VALUE 5> :
//                       <CONDITION 6> ? <VALUE 6> :
//                       <CONDITION N> ? <VALUE N> :
//                       <ELSE VALUE>


//string showText = "";
//if (age >= 18)
//{
//    showText = "Welcome";
//}
//else
//{
//    showText = "Sorry";
//}

//string showText = age >= 18 ? "Welcome" : "Sorry";
//string showText = age >= 18 ? "Welcome" :
//                  age <= 30 && age > 25 ? "Hi" :
//                    "Sorry";

//Console.WriteLine(showText);

//int? num1 = null;





// حلقه ها loops
// حلقه ها برای ما یک عملیات تکرار شونده انجام میدهد
// حلقه ها حتماااااا و حتما باید شرط اتمام داشته باشند
// وگرنه داخل لوپ بی نهایت میشوند Inifinity Loop


// loop : for

// این حلقه به شما یک متغیر میدهد که در هر بار اجرای آن
// مقدار آن تغییر میکند
// به صورت پیشفرض مقدار آن i میباشد
// برای این حلقه نوع 
// Increament 
// آن باید مشخص شود
// شرط اتمام نیز باید مشخص شود


//      loop variable    condition      loop increament/decreament
//  for (int i = 0    ;    i  <  10   ;   i++   )   
//  {
//          //    BODY
//  }

//for (int i = 1; i <= 10;i++)
//{
//    Console.WriteLine($"Number is {i}");
//}
//for (int i = 10; i >= 1; i--)
//{
//    string test = "test";
//    Console.WriteLine($"Number is {i} {test}");
//    if (10 > 20)
//    {
//        int num1 = 10;

//    }
//}
//Console.WriteLine($"Number is {i}");

//for (int i = 0; i < 10; i += 10)
//{

//}

//int num = 10;

//num = num + 5;
//num += 5;

//num = num +- 5;
//num -= 5;

//num = num / -5;
//num /= 5;

//num = num * -5;
//num *= 5;


// 1- for
// 2- do
// 3- while

//do
//{

//Console.WriteLine("Enter q to exit");
//string inputText = Console.ReadLine();


int retryCount = 0;
bool isSuccess = false;
do
{
    Console.Clear();
    Console.WriteLine("Hello KaveNegar");
    Console.WriteLine("T or F");
    string input = Console.ReadLine();
    isSuccess = input == "T" ? true : false;
    //if (isSuccess == false)
    if (!isSuccess)
        retryCount++;

//} while (isSuccess == false && retryCount < 3);
} while (!isSuccess && retryCount < 3);
























Console.ReadLine();