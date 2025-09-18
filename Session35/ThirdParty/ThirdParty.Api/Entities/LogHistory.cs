using ThirdParty.Api.Base;
using ThirdParty.Api.Enums;

namespace ThirdParty.Api.Entities;

public class LogHistory : BaseEntity
{
    public OperationActions Operation { get; private set; }
    public string RequestedIpAddress { get; private set; }
    public string? RequestedBodyJson { get; private set; }
    
    public Guid? CompanyId { get; set; }
    public Company? Company { get; set; }
    public OperationResult OperationResult { get; private set; }

    public static LogHistory Create(OperationActions operation,
        string requestedIpAddress,
        string requestedBodyJson,
        OperationResult operationResult)
    {
        return new LogHistory
        {
            Operation = operation,
            RequestedIpAddress = requestedIpAddress,
            RequestedBodyJson = requestedBodyJson,
            OperationResult = operationResult
        };
    }
}