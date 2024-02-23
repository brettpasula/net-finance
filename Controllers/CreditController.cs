using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CreditController : ControllerBase, IEntityController<Credit>
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
    public void Post([FromBody] Credit creditAccount)
    {
        throw new NotImplementedException();
    }

    [HttpDelete]
    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}