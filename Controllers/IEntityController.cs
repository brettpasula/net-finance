using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApi;

public interface IEntityController<T>
{
    public string Get();
    public string Get(int id);
    public void Post([FromBody] T entity);
    public void Delete(int id);
}
