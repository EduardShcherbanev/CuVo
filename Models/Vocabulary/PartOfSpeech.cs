using System;
using System.Collections.Generic;
using System.Text;

namespace CuVo.Models.Vocabulary
{
    public class PartOfSpeech
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
