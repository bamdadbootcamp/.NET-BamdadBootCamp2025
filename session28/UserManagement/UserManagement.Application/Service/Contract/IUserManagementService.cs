using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Application.Commands.SignUp;
using UserManagement.Application.DTOs;
using UserManagement.Domain.Entities;

namespace UserManagement.Application.Service.Contract;

public interface IUserManagementService
{
    Task SignUpAsync(CreateUserDto dto, CancellationToken cancellationToken = default);
    Task<List<GetUsersDto>> GetUsersAsync(CancellationToken cancellationToken = default);
    Task<GetUsersDto> GetByIdAsync(long id, CancellationToken cancellationToken = default);
}
