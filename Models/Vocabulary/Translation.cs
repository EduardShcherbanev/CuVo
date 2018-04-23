using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CuVo.Models.Vocabulary
{
    public class Translation
    {
        public int WordFromId { get; set; }
        public int WordToId { get; set; }
        public Word WordFrom { get; set; }
        public Word WordTo { get; set; }
    }
}
