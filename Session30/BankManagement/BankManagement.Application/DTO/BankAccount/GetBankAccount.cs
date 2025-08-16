namespace BankManagement.Application.DTO.BankAccount;

public class GetBankAccount
{
    public long Id { get; set; }
    public string AccountNumber { get; set; }
    public long CustomerId { get; set; }
    public DateTime CreatedAt { get; set; }
}
