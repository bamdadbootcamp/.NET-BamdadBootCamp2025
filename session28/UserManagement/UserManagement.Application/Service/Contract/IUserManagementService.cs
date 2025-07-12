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
    void SignUp(CreateUserDto dto);
    List<GetUsersDto> GetUsers();
}
