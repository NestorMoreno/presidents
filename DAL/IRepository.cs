using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace DAL
{
    public interface IRepository<T> where T: EntityBase
    {
        List<T> GetAll();
    }
}
