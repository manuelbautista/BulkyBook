using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface ITest<T> where T : class
    {
        T GetTest(int id);
    }
}
