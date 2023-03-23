using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLoginDBFirst.Forms;
using UserLoginDBFirst.Models;

namespace UserLoginDBFirst
{
    public static class Database
    {
        static KullaniciDbContext _db = new KullaniciDbContext();

        public static KullaniciDbContext Db(this Form form)
        {
            return _db;
        }
        
    }
}
