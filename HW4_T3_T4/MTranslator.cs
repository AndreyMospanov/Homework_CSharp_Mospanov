using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morze
{
    public class MTranslator
    {
        private Dictionary<string, string> RusMor;
        private Dictionary<string, string> MorRus;

        public MTranslator()
        {
            RusMor = new Dictionary<string, string>();
            MorRus = new Dictionary<string, string>();
            this.InitDicts();
        }

        public void InitDicts()
        {
            RusMor.Add("а", ".-");
            RusMor.Add("б", "-...");
            RusMor.Add("в", ".--");
            RusMor.Add("г", "--.");
            RusMor.Add("д", "-..");
            RusMor.Add("е", ".");            
            RusMor.Add("ж", "...-");
            RusMor.Add("з", "--..");
            RusMor.Add("и", "..");
            RusMor.Add("й", ".---");
            RusMor.Add("к", "-.-");
            RusMor.Add("л", ".-..");
            RusMor.Add("м", "--");
            RusMor.Add("н", "-.");
            RusMor.Add("о", "---");
            RusMor.Add("п", ".--.");
            RusMor.Add("р", ".-.");
            RusMor.Add("с", "...");
            RusMor.Add("т", "-");
            RusMor.Add("у", "..-");
            RusMor.Add("ф", "..-.");
            RusMor.Add("х", "....");
            RusMor.Add("ц", "-.-.");
            RusMor.Add("ч", "---.");
            RusMor.Add("ш", "----");
            RusMor.Add("щ", "--.-");
            RusMor.Add("ъ", ".--.-.");
            RusMor.Add("ы", "-.--");
            RusMor.Add("ь", "-..-");
            RusMor.Add("э", "..-..");
            RusMor.Add("ю", "..--");
            RusMor.Add("я", ".-.-");


            foreach (string key in RusMor.Keys)
            {
                MorRus.Add(RusMor[key], key);
            }
        }

        public string Translate(bool RussianToMorze, string word)
        {
            StringBuilder translated = new StringBuilder();
            string[] morzeLetters;
            if(RussianToMorze)
            {
                foreach (char c in word)
                {
                    translated.Append(RusMor[c.ToString()]);
                    translated.Append(' ');
                }
                return translated.ToString();
            }
            else
            {
                morzeLetters = word.Split(' ');
                for (int i = 0; i < morzeLetters.Length; i++)
                {
                    translated.Append(MorRus[morzeLetters[i]]);
                }
                return translated.ToString();
            }
        }
    }
}
