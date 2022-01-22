using System.Collections.Generic;
using System.Threading.Tasks;
using Japanese.Models;
using Japanese;
using Japanese.Mocks;
using SQLite;

namespace Japanese.Data
{
    public class Database
    {
        public SQLiteAsyncConnection database;

        public Database(string connectionString)
        {

            database = new SQLiteAsyncConnection(connectionString);

            DelleteAll();

            database.CreateTableAsync<ExamleModel>().Wait();
            database.CreateTableAsync<SettingModel>().Wait();
            database.CreateTableAsync<TextExplanationModel>().Wait();
            database.CreateTableAsync<TextFormatiom>().Wait();
            database.CreateTableAsync<TextShortModel>().Wait();
            database.CreateTableAsync<TextTranslateModel>().Wait();
            database.CreateTableAsync<Item>().Wait();

            CreateData();
        }

        public void CreateSetting()
        {
            SettingModel settingModel = new SettingModel()
            {
                ID = 100,
                Kana = true,
                Language = 0,

                Name = "0"
            };
            SaveSetting(settingModel);
        }

        public async Task<List<ExamleModel>> GetExamleModel(int Id)
        {
            return await database.Table<ExamleModel>().
                        Where(i => i.ItemID == Id).
                        ToListAsync();
        }

        public async Task<SettingModel> GetSettingModel(int id)
        {
            return await database.Table<SettingModel>().
                        Where(i => i.ID == id).
                        FirstOrDefaultAsync();
        }
        
        public async Task<int> DelleteAll()
        {
            await database.DeleteAllAsync<ExamleModel>();
            await database.DeleteAllAsync<TextExplanationModel>();
            await database.DeleteAllAsync<TextFormatiom>();
            await database.DeleteAllAsync<TextShortModel>();
            await database.DeleteAllAsync<TextTranslateModel>();
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

        public Task<TextExplanationModel> GetTextExplanationModel(int id)
        {
            return database.Table<TextExplanationModel>().
                                Where(i => i.IdItem == id).
                                FirstOrDefaultAsync();
        }

        public Task<TextFormatiom> GetTextFormatiom(int id)
        {
            return database.Table<TextFormatiom>().
                                Where(i => i.IdItem == id).
                                FirstOrDefaultAsync();
        }

        public Task<List<TextShortModel>> GetTextShortModels(int id)
        {
            return database.Table<TextShortModel>().
                                Where(i => i.JlPT == id).
                                ToListAsync();
        }

        public Task<TextShortModel> GetTextShortModel(int id)
        {
            return database.Table<TextShortModel>().
                                Where(i => i.JlPT == id).
                                FirstOrDefaultAsync();
        }

        public Task<List<TextTranslateModel>> GetTextTranslateModels(int id)
        {
            return database.Table<TextTranslateModel>().
                                Where(i => i.IdExample == id).
                                ToListAsync();
        }

        public Task<List<ExamleModel>> GetExamleModels(int id)
        {
            return database.Table<ExamleModel>().
                                Where(i => i.ItemID == id).
                                ToListAsync();
        }

        public Task<int> SaveAsync(Item item, List<ExamleModel> examles, TextShortModel textShort
                                    ,TextFormatiom textFormatiom, List<TextTranslateModel> textTranslates
                                    ,TextExplanationModel textExplanation)
        {
            database.InsertAsync(item);
            foreach (var examle in examles)
            {
                database.InsertAsync(examle);
            }
            database.InsertAsync(textShort);
            database.InsertAsync(textFormatiom);
            foreach (var textTranslate in textTranslates)
            {
                database.InsertAsync(textTranslate);
            }
            return database.InsertAsync(textExplanation);
        }

        public Task<int> SaveSetting(SettingModel setting)
        {
            return database.InsertAsync(setting);
        }

        public void CreateData()
        {
            Item item_1 = new Item()
            {
                ID = 1,
                Jplt = 5,
                TextJapanese = "てください",
                isFavorite = false
            };
            TextShortModel textShort_1 = new TextShortModel()
            {
                TextUa = "зроби будьласка...",
                TextRu = "сделай пожалуйста...",
                TextEngl = "please do...",
                TextPl = "proszę zrób...",

                JlPT = 5,
                IdItem = 1
            };
            TextFormatiom textFormat_1 = new TextFormatiom()
            {
                TextUa = "Дієслово -てформа +ください",
                TextRu = "Глагол -てформа +ください",
                TextEngl = "Verb -てform +ください",
                TextPl = "Czasownik -てforma +ください",

                IdItem = 1
            };
            TextExplanationModel explanation_1 = new TextExplanationModel()
            {
                TextUa = "Це речення використовується, коли оратор хоче запитати, наказати або порадити аудиторію. під час розмови зі старшим не вживайте це речення зі значенням наказу.",
                TextRu = "Это предложение используется, когда говорящий хочет спросить, напутствовать или посоветовать аудитории. при разговоре со старшими не используйте это предложение со значением приказа.",
                TextEngl = "This sentence is used when the speaker wants to ask, enjoin, or advise the audience. when talking to the elder, do not use this sentence with the enjoin meaning.",
                TextPl = "To zdanie jest używane, gdy mówca chce zapytać, nakazać lub doradzić słuchaczom. kiedy rozmawiasz ze starszym, nie używaj tego zdania w znaczeniu enjoin.",

                IdItem = 1
            };

            List<ExamleModel> examleModels_1 = new List<ExamleModel>()
            {
                new ExamleModel()
                {
                    ID = 1,
                    TextRomace = "kayo:bi madeni, shukudai o dashitekudasai.",
                    TextKana = "かようび　までに、しゅかだい　お　だしてください。",
                    TextJapanese = "火曜日までに、宿題を出してください。",

                    ItemID = 1
                },
                new ExamleModel()
                {
                    ID = 2,
                    TextRomace = "chokore-to o kattekitekudasai.",
                    TextKana = "チョコレートおかってきてください。",
                    TextJapanese = "チョコレートを買ってきてください。",

                    ItemID = 1
                },
            };

            List<TextTranslateModel> textTranslate_1 = new List<TextTranslateModel>()
            {
                new TextTranslateModel()
                {
                    TextUa = "Будь ласка, здайте домашнє завдання до вівторка.",
                    TextRu = "Пожалуйста, сдайте домашнее задание до вторника.",
                    TextEngl = "Please hand in your homework by tuesday.",
                    TextPl = "Prosimy o oddanie pracy domowej do wtorku.",

                    IdExample = 1
                },
                new TextTranslateModel()
                {
                    TextUa = "Будь ласка, купіть шоколадку.",
                    TextRu = "Пожалуйста, купите шоколад.",
                    TextEngl = "Please buy some chocolate.",
                    TextPl = "Proszę kupić trochę czekolady.",

                    IdExample = 2
                }
            };

            SaveAsync(item_1, examleModels_1, textShort_1, textFormat_1, textTranslate_1, explanation_1);
        }

    }
}
