using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase 
{
    [HttpGet(Name = "GetCreditAccounts")] 
    public IEnumerable<CreditAccount> Get() { 
        return new List<CreditAccount>();
    }

    [HttpPost(Name = "CreateCreditAccount")]
    public void Post() { 
    }
}