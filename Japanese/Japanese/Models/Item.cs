﻿using System;
using SQLite;
using System.Collections.Generic;
using SQLiteNetExtensions.Attributes;

namespace Japanese.Models
{
    
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public byte Jplt { get; set; }
        public string TextJapanese { get; set; }
        public string ShortText { get; set; }
        public string TextFormation { get; set; }
        public string TextExplanation { get; set; }
        public int ExamlesTextId { get; set; }
        public bool isFavorite { get; set; }
    }
}