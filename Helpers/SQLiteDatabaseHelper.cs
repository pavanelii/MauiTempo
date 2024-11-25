using MauiTempo.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTempo.Helpers
{
    public class SQLiteDatabaseHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public SQLiteDatabaseHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Tempo>().Wait();
        }

        public Task<int> Insert(Tempo p)
        {
            return _conn.InsertAsync(p);
        }


        public Task<List<Tempo>> GetAll()
        {
            return _conn.Table<Tempo>().OrderByDescending(t => t.HistoryDate).ToListAsync();

        }
    }
}
