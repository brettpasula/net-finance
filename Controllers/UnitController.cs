using Microsoft.AspNetCore.Mvc;
using Sitchensis.Data;
using Sitchensis.Data.Object;

namespace Sitchensis.Controllers;

[ApiController]
[Route("[controller]")]
public class UnitController : ControllerBase, IEntityController<Unit>
{
    [HttpGet]
    public IEnumerable<Unit> Get()
    {
        var db = new DatabaseContext();
        return db.Units;
    }

    [HttpGet("{id}")]
    public Unit Get(int id)
    {
        var db = new DatabaseContext();
        return db.Units.Where(unit => unit.ID == id).Single();
    }

    [HttpPost]
    public void Post([FromBody] Unit unit)
    {
        var db = new DatabaseContext();
        if (unit.ID == 0)
        {
            db.Add(unit);
            db.SaveChanges();
        }
        else
        {
            db.Update(unit);
            db.SaveChanges();
        }
    }

    [HttpDelete]
    public void Delete(int id)
    {
        var db = new DatabaseContext();
        var unitToRemove = db.Units.Where(unit => unit.ID == id).Single();
        db.Remove(unitToRemove);
        db.SaveChanges();
    }
}