namespace UlidSession
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guid Sample:");
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine();
            Console.WriteLine("Ulid Sample:");
            Console.WriteLine(Ulid.NewUlid());
            Console.WriteLine(Ulid.NewUlid());
            Console.WriteLine(Ulid.NewUlid());
            Console.WriteLine(Ulid.NewUlid());
            Console.WriteLine(Ulid.NewUlid());
            Console.WriteLine(Ulid.NewUlid());


        }
    }
}
