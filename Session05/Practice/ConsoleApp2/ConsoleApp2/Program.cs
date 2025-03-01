using System.Data;

namespace ConsoleApp2
{
    internal class Program
    {
        public static string[] userFirstNames = new string[0];
        public static string[] userLastNames = new string[0];
        public static string[] userNationalCode = new string[0];
        public static string[] userAges = new string[0];

        public static void GetUserData()
        {
            Console.Clear();
            Console.Write("Enter User First Name : ");
            string tempUserFirstName = Console.ReadLine();
            Array.Resize(ref userFirstNames, userFirstNames.Length + 1);
            userFirstNames[userFirstNames.Length - 1] = tempUserFirstName;

            Console.Write("Enter User Last Name : ");
            string tempUserLastName = Console.ReadLine();
            Array.Resize(ref userLastNames, userLastNames.Length + 1);
            userLastNames[userLastNames.Length - 1] = tempUserLastName;

            Console.Write("Enter User National Code : ");
            string tempUserNationalCode = Console.ReadLine();
            Array.Resize(ref userNationalCode, userNationalCode.Length + 1);
            userNationalCode[userNationalCode.Length - 1] = tempUserNationalCode;

            Console.Write("Enter User Age : ");
            string tempUserAge = Console.ReadLine();
            Array.Resize(ref userAges, userAges.Length + 1);
            userAges[userAges.Length - 1] = tempUserAge;

            Console.WriteLine("\nUser Added.");
            Console.WriteLine("Press Any Key To Continue ...");
            Console.ReadLine();
        }

        public static void ShowUserDataByIndex(int index)
        {
            Console.WriteLine($"\nFirstName : {userFirstNames[index]}\nLastName : {userLastNames[index]}\nNationalCode : {userNationalCode[index]}\nAge : {userAges[index]}\n");
        }

        public static void FindUser()
        {
            Console.Clear();
            Console.Write("Enter National Code : ");
            string tempUserNationalCode = Console.ReadLine();
            bool find = false;
            for (int i = 0; i < userFirstNames.Length; i++)
            {
                if (userNationalCode[i] == tempUserNationalCode)
                {
                    find = true;
                    Console.WriteLine("\nUser Founded !\n");
                    ShowUserDataByIndex(i);
                    break;
                }
            }
            if(!find)
            {
                Console.WriteLine("User Not Found ! \n");
            }

            Console.WriteLine("Press Any Key To Continue ...");
            Console.ReadLine();
        }

        public static void ShowAllUsers()
        {
            Console.Clear();
            for (int i = 0; i < userFirstNames.Length; i++)
            {
                ShowUserDataByIndex(i);
            }
            Console.WriteLine("Press Any Key To Continue ...");
            Console.ReadLine();
        }

        public static void UserAction(int action)
        {
            switch (action)
            {
                case 1:
                    GetUserData();
                break;

                case 2:
                    FindUser();
                break;

                case 3:
                    ShowAllUsers();
                break;

                case 4:
                    Environment.Exit(0);
                break;
            }
        }

        static void Main(string[] args)
        {
            int currentAction;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome To User Managment App.");
                Console.WriteLine($"User Count : {userFirstNames.Length}");
                Console.WriteLine();
                Console.Write("Actions List : \n1) Add New User\n2) Search User\n3) Show All Users\n4) Exit Program\n\nEnter Number : ");
                string action = Console.ReadLine();
                if(int.TryParse(action, out currentAction))
                {
                    UserAction(currentAction);
                }
                
            } while (true);
        }
    }
}
