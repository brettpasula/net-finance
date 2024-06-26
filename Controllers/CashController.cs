﻿using Microsoft.AspNetCore.Mvc;
using Sitchensis.Data;
using Sitchensis.Data.Object;

namespace Sitchensis.Controllers;

[ApiController]
[Route("[controller]")]
public class CashController : ControllerBase, IEntityController<Cash>
{
    [HttpGet]
    public IEnumerable<Cash> Get()
    {
        var db = new DatabaseContext();
        return db.CashAccounts;
    }

    [HttpGet("{id}")]
    public Cash Get(int id)
    {
        var db = new DatabaseContext();
        return db.CashAccounts.Single(cashAccount => cashAccount.ID == id);
    }

    [HttpPost]
    public void Post([FromBody] Cash cashAccount)
    {
        var db = new DatabaseContext();
        if (cashAccount.ID == 0)
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
