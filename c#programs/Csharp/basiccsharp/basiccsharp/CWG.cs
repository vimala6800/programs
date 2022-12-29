using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccsharp
{
    internal class CWG
    {
        public int code { get; set; }
        public string name { get; set; }
        public int year { get; set; }
        public int gold { get; set; }
        public int silver { get; set; }
        public int bronze { get; set; }
        public int total { get; set; }

        public CWG(int code, string name, int year, int gold, int silver, int bronze, int total)
        {
            this.code = code;
            this.name = name;
            this.year = year;
            this.gold = gold;
            this.silver = silver;
            this.bronze = bronze;
            this.total = total;
        }

        public string info()
        {
            return $" Code : {code} Name : {name} Gold : {gold} Silver: {silver} Bronze: {bronze} Total: {total}";
        }

        public static void demo()
        {
            var cwg = new List<CWG>();
            cwg.Add(new CWG(1, "Australia", 2022, 67, 57, 54, 178));
            cwg.Add(new CWG(2, "England", 2022, 57, 66, 53, 176));
            cwg.Add(new CWG(3, "Canada", 2022, 26, 32, 34, 92));
            cwg.Add(new CWG(4, "India", 2022, 22, 16, 23, 61));
            cwg.Add(new CWG(5, "New Zealand", 2022, 20, 12, 17, 49));
            Console.WriteLine("Display data of all countries");
            foreach (var cwglist in cwg)
            {
                Console.WriteLine(cwglist.info());
            }

            int grandtotal = 0;

            foreach (var cwglist in cwg)
            {
                grandtotal = grandtotal + cwglist.total;
            }

            Console.WriteLine(" medals won by all countries" + grandtotal);
            Console.WriteLine("Change India's medal");

            foreach (var cwglist in cwg)
            {
                if (cwglist.name.Equals("India"))
                {
                    cwglist.gold = cwglist.gold + 2;
                    cwglist.total = cwglist.total + 2;
                    break;
                }
            }

            Console.WriteLine("Display after changing India's medal");
            foreach (var cwglist in cwg)
            {
                Console.WriteLine(cwglist.info());
            }

            Console.WriteLine("Delete Australia data");
            int indexOfAustralia = -1;
            foreach (var cwglist in cwg)
            {
                if (cwglist.name.Equals("Australia"))
                {
                    indexOfAustralia = cwg.IndexOf(cwglist);
                    break;
                }
            }
            cwg.RemoveAt(indexOfAustralia);

            Console.WriteLine("Display after deleting Austalia's data");
            foreach (var cwglist in cwg)
            {
                Console.WriteLine(cwglist.info());
            }

        }

        internal class CoronaTest
        {
            public static void test()
            {
                Corona corona1 = new Corona(1, "Maharashtra", 7082, 7953080, 148280, 8108442);
                Corona corona2 = new Corona(2, "Kerala", 10803, 6685335, 70898, 6767036);
                Corona corona3 = new Corona(3, "Karnataka", 4330, 4012333, 40256, 4056919);
                Corona corona4 = new Corona(4, "Tamil Nadu", 4924, 3529404, 38038, 3572366);
                Corona corona5 = new Corona(5, "Andhra Pradesh", 475, 2322258, 14733, 2337466);

                CoronaDashboard cd = new CoronaDashboard();

                cd.addCoronaData(corona1);
                cd.addCoronaData(corona2);
                cd.addCoronaData(corona3);
                cd.addCoronaData(corona4);
                cd.addCoronaData(corona5);

                cd.listCoronaData();

                corona2.active += 100;

                cd.updateCoronaData(corona2);

                Console.WriteLine("\n Data after using updateCoronaData() - active cases in Kerala updated");
                cd.listCoronaData();

                cd.deleteCoronaData(corona5);

                Console.WriteLine("\n Andhra Pradesh data deleted");
                cd.listCoronaData();

                cd.displayTopState();


            }
        }

    }
}


