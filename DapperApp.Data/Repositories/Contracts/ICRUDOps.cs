using System.Collections.Generic;

namespace DapperApp.Data.Repositories.Contracts
{
    public interface ICRUDOps<T>
    {
        bool Create(T entidade);
        bool Update(T entidade);
        bool Delete(int id);
        IEnumerable<T> GetAll();

    }
}
