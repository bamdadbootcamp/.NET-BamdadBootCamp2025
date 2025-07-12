using UserManagement.Application.DTOs;
using UserManagement.Application.Service.Contract;
using UserManagement.DAL;
using UserManagement.Domain.Entities;

namespace UserManagement.Application.Service;

public class UserManagementService : IUserManagementService
{
    private readonly ApplicationDbContext _dbContext;

    public UserManagementService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<GetUsersDto> GetUsers()
    {
        var usersDto = _dbContext.Users
            .Select(s => new GetUsersDto
            {
                Id = s.Id,
                Username = s.Username,
                Email = s.Email,
                Address = s.Address,
                LastLoginDateTime = s.LastLoginDateTime,
                Phonenumber = s.Phonenumber,
                Status = s.Status,
            })
            .ToList();

        return usersDto;
    }

    public void SignUp(CreateUserDto dto)
    {
        var user = User.Create(dto.Username, dto.Password,
            dto.Email, dto.PhoneNumber, dto.Address);

        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
    }
}
