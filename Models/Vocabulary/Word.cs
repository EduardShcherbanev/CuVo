using System;
using System.Collections.Generic;
using System.Text;

namespace CuVo.Models.Vocabulary
{
    public class Word
    {
        public int Id { get; set; }
        public string Spelling { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }
        public Language Language { get; set; }
    }
}
