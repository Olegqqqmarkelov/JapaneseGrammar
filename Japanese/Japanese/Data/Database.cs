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
            database.CreateTableAsync<Item>().Wait();

            //CreateTable();
        }

        public void CreateTable()
        {

            ExamleModel example = new ExamleModel()
            {
                TextRomace = "asdsadsa",
                TextJapanese = "asdasdsa",
                TextTranslate = "asdasdas"
            };

            Item item1 = new Item()
            {
                Jplt = 1,
                TextJapanese = "12",
                ShortText = "asdas",
                TextFormation =  "фівіфлргфіл",
                ExamlesText = new List<ExamleModel>(){
                        new ExamleModel()
                        {
                            TextRomace = "asdsadsa",
                            TextJapanese = "asdasdsa",
                            TextTranslate = "asdasdas",
                        },
                        new ExamleModel()
                        {
                            TextRomace = "asdsadsa",
                            TextJapanese = "asdasdsa",
                            TextTranslate = "asdasdas",
                        },
                        new ExamleModel()
                        {
                            TextRomace = "asdsadsa",
                            TextJapanese = "asdasdsa",
                            TextTranslate = "asdasdas",
                        },
                    },
                TextExplanation = "aksdkhka usgufkask fgkagfk gaskgfkagfagkflas flaglfiadsadsad lsgfaasdsadas",
                isFavorite = false
            };

            SavePersonAsync(
                item1
            );
        }

        public async Task<List<ExamleModel>> GetExamleModel(int Id)
        {
            return await database.Table<ExamleModel>().
                Where(i => i.ItemID == Id).
                ToListAsync();
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

        public Task<int> SavePersonAsync(Item item)
        {
            return database.InsertAsync(item);
        }


    }
}
