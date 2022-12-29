using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccsharp
{


    internal class Corona
    {
        private (int, string, int, int, int, int) value;

        public int code { get; set; }
        public string name { get; set; }
        public int active { get; set; }
        public int recoverd { get; set; }
        public int death { get; set; }
        public int total { get; set; }

        public Corona(int code, string name, int active, int recoverd, int death, int total)        {
            this.code = code;
            this.name = name;
            this.active = active;
            this.recoverd = recoverd;
            this.death = death;
            this.total = total;
        }

        public Corona()
        {
            this.value = value;
        }

        public string info()
        {
            return $"Code:{code},  Name:{name} Active:{active} Recoverd:{recoverd} Dead:{death} Total:{total}";
        }

    }

    internal class CoronaDashboard
    {
        public List<Corona> coronaList = new List<Corona>();
        public void addCoronaData(Corona corona)
        {
            coronaList.Add(corona);
           // Console.WriteLine("Data added.");

        }

        public void listCoronaData()
        {

            foreach (Corona item in coronaList)
            {
                Console.WriteLine(item.info());
                Console.WriteLine("\n");
            }

        }
        public void updateCoronaData(Corona corona)
        {
            foreach (Corona item in coronaList)
            {
                if (item.code == corona.code)
                {
                    coronaList[coronaList.IndexOf(item)] = corona;
                    break;
                }
                if (item.code == corona.code)
                {
                    coronaList[coronaList.IndexOf(item)] = corona;
                    break;
                }
            }
        }

       public  void deleteCoronaData(Corona corona)
        {
            foreach (Corona item in coronaList)
            {
                if (item.code == corona.code)
                {
                    coronaList.RemoveAt(coronaList.IndexOf(item));
                    break;
                }
            }
        }

        public void displayTopState()
        {

            double temp = 0;
            double dR = 0;
            string state = "";
            foreach (Corona item in coronaList)
            {

                temp = (item.death / item.total) * 100;
                if (temp > dR)
                {
                    dR = temp;
                    state = item.name;
                }
            }
            Console.WriteLine("\n\n\nTop death rate is " + dR + " from the state: " + state);
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

            corona2.active += 260;
            corona2.total += 260;
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



