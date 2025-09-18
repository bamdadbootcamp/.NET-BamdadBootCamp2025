using ThirdParty.Api.Base;

namespace ThirdParty.Api.Entities;

public class Company : BaseEntity
{
    public string Name { get; set; }
    public Guid CompanyKey { get; set; }
    public string IpAddress { get; set; }

    public ICollection<LogHistory> LogHistories { get; set; }
}