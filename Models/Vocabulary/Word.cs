using System;
using System.Collections.Generic;
using System.Text;
using CuVo.Models.User;

namespace CuVo.Models.Vocabulary
{
    public class Word
    {
        public int Id { get; set; }
        public string Spelling { get; set; }
        public int PartOfSpeechId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }
        public int LevelId { get; set; }
        public PartOfSpeech PartOfSpeech { get; set; }
        public Language Language { get; set; }
        public Level Level { get; set; }
    }
}
