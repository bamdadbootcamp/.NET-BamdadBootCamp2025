namespace Session07
{
    internal class Program
    {
        public enum WeekDays
        {
            Saturday,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
        }
        static void Main(string[] args)
        {

            WeekDays selectedWeekDay = (WeekDays)2;

            //Console.WriteLine("Select a week day");
            //Console.WriteLine("Saturday: [0]");
            //Console.WriteLine("Sunday: [1]");
            //Console.WriteLine("Monday: [2]");
            //Console.WriteLine("Tuesday: [3]");
            //Console.WriteLine("Wednesday: [4]");
            //Console.WriteLine("Thursday: [5]");
            //Console.WriteLine("Friday: [6]");

            //string input = Console.ReadLine();
            //int num = int.Parse(input);

            //WeekDays selectedWeekDay = (WeekDays)num;

            //int selectedDays = (int)WeekDays.Saturday
            //    + (int)WeekDays.Monday
            //    + (int)WeekDays.Wednesday;


            //for (int i = 1; i <= 7; i++)
            //{
            //    int power = (int)Math.Pow(2, i);
            //    int isSelected = selectedDays & power;
            //    if (isSelected > 0)
            //    {
            //        WeekDays selectedDay = (WeekDays)power;
            //        Console.WriteLine(selectedDay);
            //    }

            //}
            //WeekDays[] myWeekDays = new WeekDays[2]
            //{
            //     WeekDays.Saturday,
            //     WeekDays.Sunday,
            //};

            //    DATA TYPE      child   in      ARRAY LIST 
            //foreach (var          item   in   collection)
            //{

            //}

            //foreach(WeekDays  item   in myWeekDays)
            //{
            //    Console.WriteLine(item);
            //}

            string[] nameArray = new string[]
            {
                "Mehrdad",
                "Mehrdad",
                "Masood",
                "Hale"
            };

            for (int i = 0; i < nameArray.Length; i++)
            {
                nameArray[i] = nameArray[i] + "1";
                Console.WriteLine(nameArray[i]);
            }

            foreach (string name in nameArray)
            {
                Console.WriteLine(name);
            }


        }
    }
}
