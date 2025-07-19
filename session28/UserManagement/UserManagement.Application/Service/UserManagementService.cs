using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
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

    public async Task<GetUsersDto> GetByIdAsync(long id, CancellationToken cancellationToken)
    {
        //var user = await _dbContext.Users.FindAsync(cancellationToken, id);
        var user = await _dbContext.Users.SingleOrDefaultAsync(s => s.Id == id, cancellationToken);

        if (user == null) throw new Exception("User not found");

        return new GetUsersDto
        {
            Id = id,
            Address = user.Address,
            Email = user.Email,
            LastLoginDateTime = user.LastLoginDateTime,
            Phonenumber = user.Phonenumber,
            Status = user.Status,
            Username = user.Username
        };

    }

    public async Task<List<GetUsersDto>> GetUsersAsync(CancellationToken cancellationToken)
    {
        var usersDto = await _dbContext.Users
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
            .ToListAsync(cancellationToken);

        return usersDto;
    }

    //public List<GetUsersDto> GetUsers()
    //{
    //    var usersDto = _dbContext.Users
    //        .Select(s => new GetUsersDto
    //        {
    //            Id = s.Id,
    //            Username = s.Username,
    //            Email = s.Email,
    //            Address = s.Address,
    //            LastLoginDateTime = s.LastLoginDateTime,
    //            Phonenumber = s.Phonenumber,
    //            Status = s.Status,
    //        })
    //        .ToList();

    //    return usersDto;
    //}


    public async Task SignUpAsync(CreateUserDto dto, CancellationToken cancellationToken)
    {
        var user = User.Create(dto.Username, dto.Password,
            dto.Email, dto.PhoneNumber, dto.Address);

        await _dbContext.Users.AddAsync(user, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
