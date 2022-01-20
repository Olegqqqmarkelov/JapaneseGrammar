using System.Collections.Generic;
using System.Threading.Tasks;
using Japanese.Models;
using Japanese;
using SQLite;

namespace Japanese.Data
{
    public class Database
    {
        public SQLiteAsyncConnection database;

        public Database(string connectionString)
        {
            database = new SQLiteAsyncConnection(connectionString);

            database.CreateTableAsync<ExamleModel>().Wait();
            database.CreateTableAsync<SettingModel>().Wait();
            database.CreateTableAsync<TextExplanationModel>().Wait();
            database.CreateTableAsync<TextFormatiom>().Wait();
            database.CreateTableAsync<TextShortModel>().Wait();
            database.CreateTableAsync<TextTranslateModel>().Wait();
            database.CreateTableAsync<Item>().Wait();

            //DelleteAll();
            //CreateTable();
        }


        public async Task<List<ExamleModel>> GetExamleModel(int Id)
        {
            return await database.Table<ExamleModel>().
                        Where(i => i.ItemID == Id).
                        ToListAsync();
        }
        
        public async Task<int> DelleteAll()
        {
            await database.DeleteAllAsync<ExamleModel>();
            return await database.DeleteAllAsync<Item>();
        }

        public async Task<List<Item>> GetAllItemAsync(int number)
        {
            return await database.Table<Item>().
                                Where(i => i.Jplt == number).
                                ToListAsync();
        }

        public Task<Item> GetItemAsync(int id)
        {
            return database.Table<Item>().
                                Where(i => i.ID == id).
                                FirstOrDefaultAsync();
        }

        public Task<int> SaveAsync(Item item, ExamleModel examle, TextShortModel textShort
                                    ,TextFormatiom textFormatiom, TextTranslateModel textTranslate
                                    ,TextExplanationModel textExplanation)
        {
            database.InsertAsync(item);
            database.InsertAsync(examle);
            database.InsertAsync(textShort);
            database.InsertAsync(textFormatiom);
            database.InsertAsync(textTranslate);
            return database.InsertAsync(textExplanation);
        }


    }
}
