using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    internal class Harki
    {
        public List<Dictionary<string, int>> l = new List<Dictionary<string, int>>()
        {
            //Процессоры
            new Dictionary<string, int>()
            {
                ["Ryzen 5 5500          "] = 12000,
                ["Ryzen 5 5600          "] = 15000,
                ["Ryzen 7 5700          "] = 18000,
                ["Ryzen 7 5800          "] = 21000,
                ["Ryzen 9 5900          "] = 24000
            },
            //Видеокарты
            new Dictionary<string, int>()
            {
                ["RTX 3050              "] = 12000,
                ["RTX 3060              "] = 24000,
                ["RTX 3070              "] = 36000,
                ["RTX 3080              "] = 48000,
                ["RTX 3090              "] = 60000
            },
            //ОЗУ
            new Dictionary<string, int>()
            {
                ["8 GB 3200Mhz          "] = 6000,
                ["16 GB 3200Mhz         "] = 12000,
                ["32 GB 3200Mhz         "] = 24000,
                ["64 GB 3200Mhz         "] = 48000,
                ["128 GB 3200Mhz        "] = 96000
            },
            //Матеиринские платы
            new Dictionary<string, int>()
            {
                ["MSI B550-A PRO        "] = 12000,
                ["MSI B550 GAMING PRO   "] = 14000,
                ["MSI B550 TOMAHAWK WIFI"] = 16000,
                ["GIGABITE X570         "] = 20000,
            },
            //БП
            new Dictionary<string, int>()
            {
                ["Be quite 700w         "] = 12000,
                ["Seasonic 700w         "] = 14000,
                ["KSAS 1000w            "] = 16000
            },
            //Корпуса
            new Dictionary<string, int>()
            {
                ["ZALMAN i3             "] = 4500,
                ["Deepcool Matrexx Mesh "] = 5000,
                ["Lian Li LANCOOL       "] = 12000
            },
            //Куллеры
            new Dictionary<string, int>()
            {
                ["DEEPCOOL GAMMAX 300   "] = 1000,
                ["DEEPCOOL AK620        "] = 7000,
                ["DEEPCOOL GAMMAX 400   "] = 2300
            }
        };

        public List<string> m = new List<string>() {"Процессор", "Видеокарта", "ОЗУ", "Материнская плата", "БП", "Корпус", "Куллер"};
        public int HAR_Menu(int pos)
        {
            Console.Clear();
            Console.WriteLine(m[pos]);
            int ck = 1;
            foreach (var item in l[pos])
            {
                Console.Write("  " + ck + ". " + item.Key);
                Console.SetCursorPosition(30, ck);
                Console.WriteLine(item.Value + " руб.");
                ck ++;
            }
            return l[pos].Count();
        }

        public string Znch(int pos, int pol)
        {
            int k = 0;
            foreach (var item in l[pos])
            {
                k++;
                if (k == pol)
                {
                    return item.Key;
                }
            }
            return "ХЗ";
        }
        public int Price(int pos, int pol)
        {
            int k = 0;
            foreach (var item in l[pos])
            {
                k++;
                if (k == pol)
                {
                    return item.Value;
                }
            }
            return 0;
        }

    }
            
}

