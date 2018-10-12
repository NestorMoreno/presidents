using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IOperations<T>
    {
        T GetByName(string name);
        List<T> GetAll();
    }
}
