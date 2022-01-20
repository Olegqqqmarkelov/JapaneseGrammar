using System;
using System.Collections.Generic;
using System.Text;
using Japanese.Models;
using Japanese.Data;

namespace Japanese.Mocks
{
    public class DataInit
    {
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
            ExamleModel examleModel_1 = new ExamleModel()
            {
                ID = 1,
                TextRomace = "kayo:bi madeni, shukudai o dashitekudasai.",
                TextKana = "かようび　までに、しゅかだい　お　だしてください。",
                TextJapanese = "火曜日までに、宿題を出してください。",

                ItemID = 1
            };
            TextTranslateModel translate_1 = new TextTranslateModel()
            {
                TextUa = "Будь ласка, здайте домашнє завдання до вівторка.",
                TextRu = "Пожалуйста, сдайте домашнее задание до вторника.",
                TextEngl = "Please hand in your homework by tuesday.",
                TextPl = "Prosimy o oddanie pracy domowej do wtorku.",

                IdExample = 1
            };

            ExamleModel examleModel_2 = new ExamleModel()
            {
                ID = 2,
                TextRomace = "chokore-to o kattekitekudasai.",
                TextKana = "チョコレートおかってきてください。",
                TextJapanese = "チョコレートを買ってきてください。",

                ItemID = 1
            };
            TextTranslateModel translate_2 = new TextTranslateModel()
            {
                TextUa = "Будь ласка, купіть шоколадку.",
                TextRu = "Пожалуйста, купите шоколад.",
                TextEngl = "Please buy some chocolate.",
                TextPl = "Proszę kupić trochę czekolady.",

                IdExample = 2
            };

        }
    }
}
