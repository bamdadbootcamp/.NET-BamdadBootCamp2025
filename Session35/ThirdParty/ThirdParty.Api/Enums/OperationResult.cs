namespace ThirdParty.Api.Enums;

public enum OperationResult
{
    Block,      // Not in our company data
    Decline,    // Not valid ip requested for company
    Success,    // request accepted with true response
    NotFound    // request accepted with false response
}