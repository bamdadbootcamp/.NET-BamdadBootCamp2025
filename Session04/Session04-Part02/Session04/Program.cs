using System.ComponentModel;

namespace Session04
{
    internal class Program
    {

        
        public static int Sum(int num1, int num2, int num3) // Signature
        {
            int result = num1 + num2 + num3;
            return result;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());


            int mammad = Sum(input1, input2, input3);

            Console.WriteLine(mammad);


        }
    }
}

// متد ها درون کلاس نوشته میشوند
// چنانچه قطعه کدی را بنویسیم که میتواند در آینده و یا در محل 
// های دیگر کد نویسی اجرا شوند بهتر است درون متد نوشته شوند
// یکبار بنویسو جاهای دیگه استفاده کن :)

// اجزای متد
// 1- signature
// 2- body

// تعریف متد
// سطح دسترسی مشخص شود
// نوع خروجی تعیین شود
// نام متد
// ورودی ها مشخص شود
// بدنه حاوی دستوراتی است که میخواهیم اجرا شود

// [AM] static [Return Data Type]/void  [Name]  ( <Parameters> )
// {
//      BODY
//        در متدی که خروجی دارد حتما باید به دستور
//        return
 //       ختم شود
 //       return در جلوی 
 //        مقدار خروجی باید نوشته شود
// }
// به ورودی های متد parameter
// میگویند