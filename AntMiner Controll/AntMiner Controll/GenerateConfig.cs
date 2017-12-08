using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace AntMiner_Controll
{

    class GenerateConfig
    {
   

        public string URL1;
            public string URL2;
            public string URL3;

            public string Worker1;
            public string Worker2;
            public string Worker3;

            public string PW1;
            public string PW2;
            public string PW3;

            public string Fan;
            public decimal Fanspeed;

        public GenerateConfig(string uRL1, string uRL2, string uRL3, string worker1, string worker2, string worker3, string pW1, string pW2, string pW3,string fan, decimal fanspeed)
        {
            URL1 = uRL1;
            URL2 = uRL2;
            URL3 = uRL3;
            Worker1 = worker1;
            Worker2 = worker2;
            Worker3 = worker3;
            PW1 = pW1;
            PW2 = pW2;
            PW3 = pW3;

            Fan = fan;
            Fanspeed = fanspeed;

        }

        public string GetConfig()
        {



            string str = Properties.Resources.Config;

            str = str.Replace("#URL1#", this.URL1);
            str = str.Replace("#URL2#", this.URL2);
            str = str.Replace("#URL3#", this.URL3);

            str = str.Replace("#USER1#", this.Worker1);
            str = str.Replace("#USER2#", this.Worker2);
            str = str.Replace("#USER3#", this.Worker3);

            str = str.Replace("#PW1#", this.PW1);
            str = str.Replace("#PW2#", this.PW2);
            str = str.Replace("#PW3#", this.PW3);

            str = str.Replace("#FAN#", this.Fan);
            str = str.Replace("#FANSPEED#", Convert.ToString(this.Fanspeed));

            Console.WriteLine(str);
            return str;

        }


    }
}
