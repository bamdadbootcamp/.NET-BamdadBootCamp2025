using BankManagement.Application.DTO.BankAccount;
using BankManagement.Application.DTO.Customer;
using Microsoft.AspNetCore.Mvc;

namespace BankManagement.WebApi.Controllers;

[ApiController]
public class BankAccountController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        return Ok();
    }

    [HttpGet("{id:long}")]
    public async Task<IActionResult> Get(long Id, CancellationToken cancellationToken)
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateBankAccount dto, CancellationToken cancellationToken)
    {
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Put([FromBody] UpdateBankAccount dto, CancellationToken cancellationToken)
    {
        return Ok();
    }

    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Delete(long Id, CancellationToken cancellationToken)
    {
        return Ok();
    }
}
