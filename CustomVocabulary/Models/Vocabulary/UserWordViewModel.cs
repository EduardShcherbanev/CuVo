using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomVocabulary.Models.Vocabulary
{
    public class UserWordViewModel
    {
        public int UserWordId { get; set; }
        public string Spelling { get; set; }
        public string Description { get; set; }
        public string PartOfSpeech { get; set; }
        public string Language { get; set; }
        public string Level { get; set; }
    }
}