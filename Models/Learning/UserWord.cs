using System;
using System.Collections.Generic;
using System.Text;
using CuVo.Models.User;
using CuVo.Models.Vocabulary;

namespace CuVo.Models.Learning
{
    public class UserWord
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int WordId { get; set; }
        public ApplicationUser User { get; set; }
        public Word Word { get; set; }
    }
}
