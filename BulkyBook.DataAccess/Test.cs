using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess
{
    public class Test
    {
        public void TestGet(ApplicationDbContext db)
        {
            var repo = new Repository<Category>(db);

            repo.Add(new Category());
        }
    }
}
