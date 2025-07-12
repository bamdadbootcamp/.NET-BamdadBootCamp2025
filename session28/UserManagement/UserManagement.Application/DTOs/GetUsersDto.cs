using UserManagement.Domain.Enums;

namespace UserManagement.Application.DTOs
{
    public class GetUsersDto
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Address { get; set; }
        public DateTime? LastLoginDateTime { get; set; }
        public UserStatus Status { get; set; }
    }
}
