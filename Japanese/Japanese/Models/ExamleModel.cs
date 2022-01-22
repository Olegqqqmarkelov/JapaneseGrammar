using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Japanese.Models
{
    public class ExamleModel
    {
        public int ID { get; set; }
        public string TextRomace { get; set; }
        public string TextKana { get; set; }
        public string TextJapanese { get; set; }

        public int ItemID { get; set; }
    }
}
