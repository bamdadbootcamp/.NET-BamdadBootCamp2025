namespace BookStore.BL.Entities.Core;

public interface IInterface
{
    // Property
    string Name { get; set; }

    // Method
    string SayGoodBye();
}

public abstract class AbstractClass
{

    public abstract string SayHello();
}
public class Child : AbstractClass, IInterface
    //                Inheritance    Implement
{
    public string Name { get; set; }

    public string SayGoodBye()
    {
        return "Good bye ";
    }

    public override string SayHello()
    {
        return "Say hello";
    }
}
