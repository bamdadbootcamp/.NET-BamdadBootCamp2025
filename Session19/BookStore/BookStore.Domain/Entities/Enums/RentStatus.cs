namespace BookStore.Domain.Entities.Enums;

public enum RentStatus
{
    Rented,
    Returned,
    ReturnedWithFine,
    AlertToCustomer // Background worker - Cron Job => Hangfire / Quartz
}
