using System.Text.Json;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CreditController : ControllerBase, IEntityController<ICredit>
{
    [HttpGet]
    public string Get()
    {
        var mockCreditAccounts = new List<ICredit>();
        for (int i = 0; i < 5; i++) { 
            var credit = new Credit(
                id: i * 2842,
                name: "Credit Account " + i,
                bank: "Bank of Exceptional Returns",
                creditAvailable: (decimal) (1234.23 * i - (234.98 * i)),
                creditLimit: (decimal) 1234.23 * i,
                lastPaymentDate: DateTime.Now,
                rewardsProgramDetails: "Blah blah blah blah",
                rewardsProgramBalance: 99 * i + "Points",
                statementBalance: 123 * i,
                statementDueDate: DateTime.Now.AddDays(21)
            );
            mockCreditAccounts.Add(credit);
        }
        return JsonSerializer.Serialize(mockCreditAccounts);
    }

    [HttpGet("{id}")]
    public string Get(int id) { 
        throw new NotImplementedException();
    }

    [HttpPost]
    public void Post([FromBody] ICredit creditAccount) { 
        throw new NotImplementedException();
    }

    [HttpDelete]
    public void Delete(int id) { 
        throw new NotImplementedException();
    }
}