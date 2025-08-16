namespace BankManagement.Application.DTO.BankAccount;

public class UpdateBankAccount
{
    public long Id { get; set; }
    public string AccountNumber { get; set; }
    public long CustomerId { get; set; }
}
