using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Market
{
    internal class Zakaz
    {
        
        public Dictionary<string, string> zak = new Dictionary<string, string>()
        {
            ["Процессор"] = " ",
            ["Видеокарта"] = " ",
            ["ОЗУ"] = " ",
            ["Материнская плата"] = " ",
            ["БП"] = " ",
            ["Корпус"] = " ",
            ["Куллер"] = " "
        };

        public List<string> m = new List<string>() { "Процессор", "Видеокарта", "ОЗУ", "Материнская плата", "БП", "Корпус", "Куллер" };
        public void Vivid()
        {
            Console.Clear();
            int cl = 0;
            foreach (var kvp in m)
            {
                Console.WriteLine("  "+kvp);
                Console.SetCursorPosition(28, m.IndexOf(kvp));
                Console.WriteLine("| "+ zak[kvp]);
                cl++;
            }
            Console.WriteLine("################################################################");
            string j = ("Итого:                                               " + this.Summa() + " руб.");
            if (j.Count() > 63)
            {
                Console.WriteLine("Итого:                                              " + this.Summa() + " руб.");
            }
            else
                Console.WriteLine(j);
        }
        
        public int Summa()
        {   
            Harki h = new Harki();
            int s = 0;
            for (int i = 0; i < m.Count; i++)
            {
                if (zak[m[i]] != " ")
                {
                    s = s + h.l[i][zak[m[i]].Remove(22)]; 
                }   
            }
            return s;
        }
    }
}
