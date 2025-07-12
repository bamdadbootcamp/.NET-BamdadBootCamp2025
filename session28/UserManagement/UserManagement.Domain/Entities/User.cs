using UserManagement.Domain.Core;
using UserManagement.Domain.Enums;

namespace UserManagement.Domain.Entities;

public class User : BaseEntity
{
    public string Username { get; private set; }
    public string Password { get; private set; }
    public bool IsPasswordChangeRequire { get; private set; }
    public string Email { get; private set; }
    public string Phonenumber { get; private set; }
    public string Address { get; private set; }
    public DateTime? LastLoginDateTime { get; private set; }
    public UserStatus Status { get; private set; }

    public static User Create(string username,
        string password,
        string email,
        string phonenumber,
        string address = null
)
    {
        //if (string.IsNullOrEmpty(username) && username.Length < 4)
        //    throw new Exception("username is required");

        var user = new User()
        {
            Username = username,
            Password = password,
            Email = email,
            Phonenumber = phonenumber,
            Address = address
        };

        return user;
    }

    private User()
    {
        Status = UserStatus.Active;
    }

    public void Update(string email = null,
        string phonenumber = null,
        string address = null)

    {
        if (!string.IsNullOrEmpty(email))
            Email = email;
        if (!string.IsNullOrEmpty(phonenumber))
            Phonenumber = phonenumber;
        if (!string.IsNullOrEmpty(address))
            Address = address;

        LastModifiedDateTime = DateTime.UtcNow;
    }

    public void ChangePassword(string oldPassword, string newPassword, string confirmNewPassword)
    {
        if (oldPassword != Password)
            throw new Exception("Old password is wrong");
        if (newPassword != confirmNewPassword)
            throw new Exception("Password is not match");
        if (newPassword.Length < 8)
            throw new Exception("Password must be more than 8 chars");

        Password = newPassword;
        IsPasswordChangeRequire = false;
        LastModifiedDateTime = DateTime.UtcNow;

    }

    public void Active()
    {
        IsPasswordChangeRequire = true;
        Status = UserStatus.Active;
        LastModifiedDateTime = DateTime.UtcNow;

    }

    public void Inactive()
    {
        IsPasswordChangeRequire = true;
        Status = UserStatus.Inactive;
        LastModifiedDateTime = DateTime.UtcNow;

    }

    public void UpdateLoginDateTime()
    {
        LastLoginDateTime = DateTime.UtcNow;
    }
}

