using System;
using System.Collections.Generic;
using System.Text;

namespace Japanese.Models
{
    public class ItemModel
    {
        public Item item { get; set; }
        public TextFormatiom formatiom { get; set; }
        public TextShortModel textShort { get; set; }
        public TextExplanationModel explanation { get; set; }
        public List<ExamleModel> examleModel { get; set; }
        public List<TextTranslateModel> translate { get; set; }
    }
}
