using BankManagement.Domain.Base;

namespace BankManagement.Domain.Entities;

public class BankAccount : BaseEntity
{
    public string AccountNumber { get; private set; }
    public long CustomerId { get; private set; }
    public Customer Customer { get; private set; }
    private BankAccount()
    {
    }
    public static BankAccount Create(string accountNumber, long CustomerId)
    {
        return new BankAccount
        {
            AccountNumber = accountNumber,
            CustomerId = CustomerId
        };
    }
}
