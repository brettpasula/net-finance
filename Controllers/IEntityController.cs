using Microsoft.AspNetCore.Mvc;

namespace Sitchensis.Controllers;

public interface IEntityController<T>
{
    public IEnumerable<T> Get();
    public T Get(int id);
    public void Post([FromBody] T entity);
    public void Delete(int id);
}
