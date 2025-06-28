namespace WebProject.Api.Repository;

public interface IRepository
{
    Guid UniqueKey { get; }
    void Add(User user);
    User GetUser(int id);
    List<User> GetAll();
    void Update(User user);
    void Delete(int id);
}
