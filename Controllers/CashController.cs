using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApi;

[ApiController]
[Route("[controller]")]
public class CashController : ControllerBase, IEntityController<ICash>
{
    [HttpGet]
    public string Get()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public string Get(int id)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public void Post([FromBody] ICash cashAccount)
    {
        throw new NotImplementedException();
    }

    [HttpDelete]
    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}
