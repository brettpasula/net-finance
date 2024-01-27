using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApi;

[ApiController]
[Route("[controller]")]
public class CashController : ControllerBase, IEntityController<ICash>
{
    [HttpGet]
    public IEnumerable<ICash> Get()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public ICash Get(int id)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public void Post([FromBody] ICash cashAccount) { 
        throw new NotImplementedException();
    }

    [HttpDelete]
    public void Delete(int id) { 
        throw new NotImplementedException();
    }
}
