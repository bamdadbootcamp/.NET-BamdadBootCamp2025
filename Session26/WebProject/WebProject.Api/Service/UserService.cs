using WebProject.Api.Repository;

namespace WebProject.Api.Service;

public interface IUserService
{
    bool Login(string username, string password);
}

public class UserService : IUserService
{
    private readonly IRepository _repository;

    public UserService(IRepository repository)
    {
        _repository = repository;
    }


    public bool Login(string username, string password)
    {
        var guid = _repository.UniqueKey;

        var user = _repository.GetAll().FirstOrDefault(f => f.Name == username);
        if (user is not null)
        {
            if (user.Password == password)
                return true;
        }
        return false;
    }
}
