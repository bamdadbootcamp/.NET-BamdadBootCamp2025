namespace WebProject.Api.Dependency_Injection;



public interface IClassA
{
    string SayHello();
}

public class ClassA : IClassA
{
    public string SayHello() => "Hello";
}
