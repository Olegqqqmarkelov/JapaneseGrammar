using System.Collections.Generic;
using System.Threading.Tasks;
using Japanese.Models;
using SQLite;

namespace Japanese.Data
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;
        private string v;

        public Database(string v)
        {
            this.v = v;
        }

        public Task<List<Item>> GetAllItemAsync()
        {
            return _database.Table<Item>().ToListAsync();
        }

        public Task<Item> GetItemAsync(int id)
        {
            return _database.Table<Item>().
                                Where(i => i.ID == id).
                                FirstOrDefaultAsync();
        }

        public Task<int> SavePersonAsync(Item item)
        {
            return _database.InsertAsync(item);
        }
    }
}
