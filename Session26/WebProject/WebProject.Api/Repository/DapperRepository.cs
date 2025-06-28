
namespace WebProject.Api.Repository;

public class DapperRepository : IRepository
{
    public Guid UniqueKey { get; } = Guid.NewGuid();
    public void Add(User user)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<User> GetAll()
    {
        throw new NotImplementedException();
    }

    public User GetUser(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(User user)
    {
        throw new NotImplementedException();
    }
}
