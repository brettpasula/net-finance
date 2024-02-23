using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace NetCoreWebApi;

[ApiController]
[Route("[controller]")]
public class CashController : ControllerBase, IEntityController<Cash>
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
    public void Post([FromBody] Cash cashAccount)
    {
        using var db = new DatabaseContext();
        if (cashAccount.ID.HasValue)
        {
            db.Add(cashAccount);
            db.SaveChanges();
        }
        else
        {
            db.Update(cashAccount);
            db.SaveChanges();
        }
    }

    [HttpDelete]
    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}
