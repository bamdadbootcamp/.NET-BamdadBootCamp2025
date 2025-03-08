namespace Practice
{
    internal class Program
    {
        public static int NumberReadLine(string showText)
        {
            int num = 0;
            do
            {
                Console.WriteLine(showText);
                bool isValid = int.TryParse(Console.ReadLine(), out num);
                if (isValid)
                    break;
            } while (true);
            return num;
        }

        public static int[] NumberDivisions(int number)
        {
            int[] divisions = new int[0];

            for (int i = number; i >= 1; i--)
            {
                if (number % i == 0)
                {
                    Array.Resize(ref divisions, divisions.Length + 1);
                    divisions[divisions.Length - 1] = i;
                }
            }
            return divisions;
        }

        public static int FindBMM(int num1, int num2)
        {
            if (num2 > num1)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            int[] num1divisions = NumberDivisions(num1);
            int[] num2divisions = NumberDivisions(num2);

            int result = 1;
            for (int i = 0; i < num1divisions.Length; i++)
            {
                for (int j = 0; j < num2divisions.Length; j++)
                {
                    if (num1divisions[i] == num2divisions[j])
                    {
                        result = num2divisions[j];
                        return result;
                    }
                }
            }

            return result;
        }

        static void Main(string[] args)
        {

            do
            {
                Console.Clear();

                int num1 = NumberReadLine("Please enter first number:");
                int num2 = NumberReadLine("Please enter second number:");
              
                int bmm = FindBMM(num1, num2);
                Console.WriteLine($"BMM is {bmm}");


                int kmm = (num1 * num2) / bmm;
                Console.WriteLine($"KMM is {kmm}");

                Console.WriteLine("If you want to restart press R");
                string input = Console.ReadLine();
                if (input.ToLower() != "r")
                    break;
            } while (true);
        }
    }
}
