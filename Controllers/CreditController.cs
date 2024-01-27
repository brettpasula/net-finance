using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CreditController : ControllerBase, IEntityController<ICredit>
{
    [HttpGet]
    public IEnumerable<ICredit> Get()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public ICredit Get(int id) { 
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