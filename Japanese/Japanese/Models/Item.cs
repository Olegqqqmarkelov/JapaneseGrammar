using System;
using SQLite;

using System.Collections.Generic;

namespace Japanese.Models
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public byte Jplt { get; set; }
        public string TextJapanese { get; set; }
        public string ShortText { get; set; }
        public List<TextFormatiom> TextForm { get; set; }
        public string TextExplanation { get; set; }
        public List<ExamleModel> Examles { get; set; }
        public bool isFavorite { get; set; }
    }
}