using System;

namespace Exercicio02
{
    [Serializable]
    public class Vocabulary
    {
        public string _id { get; set; }
        public string text { get; set; }
        public int? total { get; set; }
        public int? type { get; set; }
        public int? label { get; set; }
    }
}
