using BankManagement.Domain.Base;

namespace BankManagement.Domain.Entities;

public class Customer : BaseEntity
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string NationalId { get; private set; }
    public ICollection<BankAccount> BankAccounts { get; set; }
    private Customer()
    {
    }
    public static Customer Create(string firstName, string lastName, string nationalId)
    {
        return new Customer
        {
            FirstName = firstName,
            LastName = lastName,
            NationalId = nationalId
        };
    }
}
