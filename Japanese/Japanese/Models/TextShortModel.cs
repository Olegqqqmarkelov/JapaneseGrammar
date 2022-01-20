using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Japanese.Models
{
    public class TextShortModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string TextUa { get; set; }
        public string TextRu { get; set; }
        public string TextEngl { get; set; }
        public string TextPl { get; set; }

        public int IdItem { get; set; }
    }
}
