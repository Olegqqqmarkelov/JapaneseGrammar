using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Japanese.Models
{
    public class SettingModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public byte Language { get; set; }
        public bool Kana { get; set; }
    }
}
