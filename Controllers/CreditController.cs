using Microsoft.AspNetCore.Mvc;
using Sitchensis.Data;
using Sitchensis.Data.Object;

namespace Sitchensis.Controllers;

[ApiController]
[Route("[controller]")]
public class CreditController : ControllerBase, IEntityController<Credit>
{
    [HttpGet]
    public IEnumerable<Credit> Get()
    {
        var db = new DatabaseContext();
        return db.CreditAccounts;
    }

    [HttpGet("{id}")]
    public Credit Get(int id)
    {
        var db = new DatabaseContext();
        return db.CreditAccounts.Single(creditAccount => creditAccount.ID == id);
    }

    [HttpPost]
    public void Post([FromBody] Credit creditAccount)
    {
        var db = new DatabaseContext();
        if (creditAccount.ID == 0) { 
            db.Update(creditAccount);
            db.SaveChanges();
        } else { 
            db.Add(creditAccount);
            db.SaveChanges();
        }
    }

    [HttpDelete]
    public void Delete(int id)
    {
        var db = new DatabaseContext();
        var creditAccountToRemove = db.CreditAccounts.Single(creditAccount => creditAccount.ID == id);
        db.Remove(creditAccountToRemove);
        db.SaveChanges();
    }
}