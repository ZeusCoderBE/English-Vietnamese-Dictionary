using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise3
{
    public class Word
    {
        private string word;//tiếng Anh
        private string type;//từ loại
        private string mean;//tiếng việt
        private string ipa;//phiên âm
        private string synonyms;//từ đồng nghĩa
        public string Word1 { get => word; set => word = value; }
        public string Ipa { get => ipa; set => ipa = value; }
        public string Type { get => type; set => type = value; }
        public string Mean { get => mean; set => mean = value; }
        public string Synonyms { get => synonyms; set => synonyms = value; }
        public Word(string word, string ipa, string type, string mean,string synonyms)
        {
            this.word = word;
            this.ipa = ipa;
            this.type = type;
            this.mean = mean;
            this.synonyms=synonyms;
        }
        public Word()
        {

        }

    }
}
