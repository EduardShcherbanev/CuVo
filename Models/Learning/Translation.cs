namespace CuVo.Models.Learning
{
    public class Translation
    {
        public int UserWordFromId { get; set; }
        public int UserWordToId { get; set; }
        public UserWord UserWordFrom { get; set; }
        public UserWord UserWordTo { get; set; }
    }
}
