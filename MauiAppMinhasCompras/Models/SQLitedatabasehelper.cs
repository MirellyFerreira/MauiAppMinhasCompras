using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppMinhasCompras.Models
{
    public class SQLitedatabasehelper
    {
        readonly SQLitedatabasehelper _conn;

        public SQLitedatabasehelper(string path)
        {
            _conn = new SQLitedatabasehelper(path);
            _conn.CreateTableAsync<Produto>().Wait();
        }
        public Task <int> Insert(Produto p)
        {

        }
    }
}
