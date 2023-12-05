using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CreditController : ControllerBase
{
    [HttpGet]
    public IEnumerable<ICreditAccount> Get()
    {
        var sampleCreditAccounts = Enumerable.Range(1, 5).Select(i => new CreditAccount(
            id: i * 12345957,
            name: "Credit Account " + i,
            bank: "Bank " + i,
            creditLimit: i * 1000.25,
            creditAvailable: (i * 1000.25) - (i * 100)));
        return sampleCreditAccounts;
    }

    [HttpGet("{id}")]
    public ICreditAccount Get(int id) { 
        return CreditAccountAccess.Get(id);
    }

    [HttpPut]
    public void Put([FromBody] ICreditAccount creditAccount)
    {
        // 
    }
}