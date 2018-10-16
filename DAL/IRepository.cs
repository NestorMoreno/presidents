using DTO;
using System.Collections.Generic;

namespace DAL
{
    public interface IRepository<T> where T: EntityBase
    {
        List<T> GetAll();
    }
}
