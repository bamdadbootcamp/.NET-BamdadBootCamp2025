namespace WebProject.Api.Dependency_Injection
{
    public interface ISingletonPattern
    {
        Guid Name { get; }
    }
    public class SingletonPattern : ISingletonPattern
    {
        public Guid Name => Guid.NewGuid();
    }
}
