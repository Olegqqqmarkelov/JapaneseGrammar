using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Japanese.Models
{
    public class ExamleModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string TextRomace { get; set; }
        public string TextJapanese { get; set; }
        public string TextTranslate { get; set; }

        public int ItemID { get; set; }
    }
}
