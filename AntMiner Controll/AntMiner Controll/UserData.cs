using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AntMiner_Controll  
{
    class UserData 

    {
        public static void SaveData(string path, string uRL1, string uRL2, string uRL3, string worker1, string worker2, string worker3, string pW1, string pW2, string pW3, string fan, decimal fanspeed,string iplist,string defcred, string username, string password)
        {

            
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<item><name>miner-config</name></item>");

        
            XmlElement url1 = doc.CreateElement("URL1");
            XmlElement url2 = doc.CreateElement("URL2");
            XmlElement url3 = doc.CreateElement("URL3");

            XmlElement Worker1 = doc.CreateElement("worker1");
            XmlElement Worker2 = doc.CreateElement("worker2");
            XmlElement Worker3 = doc.CreateElement("worker3");

            XmlElement pass1 = doc.CreateElement("pass1");
            XmlElement pass2 = doc.CreateElement("pass2");
            XmlElement pass3 = doc.CreateElement("pass3");


            XmlElement Fan = doc.CreateElement("fan");
            XmlElement Fanspeed = doc.CreateElement("fanspeed");
            XmlElement IPlist = doc.CreateElement("IPlist");

            XmlElement Defcred = doc.CreateElement("defcred");
            XmlElement Username = doc.CreateElement("username");
            XmlElement Password = doc.CreateElement("password");


            url1.InnerText = uRL1;
            url2.InnerText = uRL2;
            url3.InnerText = uRL3;

            Worker1.InnerText = worker1;
            Worker2.InnerText = worker2;
            Worker3.InnerText = worker3;

            pass1.InnerText = pW1;
            pass2.InnerText = pW2;
            pass3.InnerText = pW3;

            Fan.InnerText = fan;
            Fanspeed.InnerText = Convert.ToString(fanspeed);
            IPlist.InnerText = iplist;

            Defcred.InnerText = defcred;
            Username.InnerText = username;
            Password.InnerText = password;



            doc.DocumentElement.AppendChild(url1);
            doc.DocumentElement.AppendChild(url2);
            doc.DocumentElement.AppendChild(url3);

            doc.DocumentElement.AppendChild(Worker1);
            doc.DocumentElement.AppendChild(Worker2);
            doc.DocumentElement.AppendChild(Worker3);

            doc.DocumentElement.AppendChild(pass1);
            doc.DocumentElement.AppendChild(pass2);
            doc.DocumentElement.AppendChild(pass3);


            doc.DocumentElement.AppendChild(Fan);
            doc.DocumentElement.AppendChild(Fanspeed);
            doc.DocumentElement.AppendChild(IPlist);

            doc.DocumentElement.AppendChild(Defcred);
            doc.DocumentElement.AppendChild(Username);
            doc.DocumentElement.AppendChild(Password);


            doc.PreserveWhitespace = true;
            doc.Save(path);
            Form1.gui.WriteLog("Backup saved: " + path);
        }
       
        public static void LoadData(string path)
        {
           
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            Form1.gui.Pool1URLText.Text = doc.GetElementsByTagName("URL1")[0].InnerText;
            Form1.gui.Pool2URLText.Text = doc.GetElementsByTagName("URL2")[0].InnerText;
            Form1.gui.Pool3URLText.Text = doc.GetElementsByTagName("URL3")[0].InnerText;

            Form1.gui.Pool1WorkerText.Text = doc.GetElementsByTagName("worker1")[0].InnerText;
            Form1.gui.Pool2WorkerText.Text = doc.GetElementsByTagName("worker2")[0].InnerText;
            Form1.gui.Pool3WorkerText.Text = doc.GetElementsByTagName("worker3")[0].InnerText;


            Form1.gui.Pool1PWText.Text = doc.GetElementsByTagName("pass1")[0].InnerText;
            Form1.gui.Pool2PWText.Text = doc.GetElementsByTagName("pass2")[0].InnerText;
            Form1.gui.Pool3PWText.Text = doc.GetElementsByTagName("pass3")[0].InnerText;

            bool Fan = Convert.ToBoolean(doc.GetElementsByTagName("fan")[0].InnerText);
            int Fanspeed = Convert.ToInt16(doc.GetElementsByTagName("fanspeed")[0].InnerText);

            if (Fan)
            {
                Form1.gui.FanChkbox.Enabled = true;
                Form1.gui.FanSpeedNum.Enabled = true;
                Form1.gui.FanSpeedNum.Value = Fanspeed;
                Form1.gui.FanChkbox.Checked = true;
            }

            bool DefCred = Convert.ToBoolean(doc.GetElementsByTagName("defcred")[0].InnerText);

            if (!DefCred)
            {
                Form1.gui.UsernameText.Enabled = true;
                Form1.gui.PasswordText.Enabled = true;
                Form1.gui.CredsChkBox.Enabled = true;
                Form1.gui.CredsChkBox.Checked = false;
           
                Form1.gui.UsernameText.Text = doc.GetElementsByTagName("username")[0].InnerText;
                Form1.gui.PasswordText.Text = doc.GetElementsByTagName("password")[0].InnerText;

            }
            


            string IP = doc.GetElementsByTagName("IPlist")[0].InnerText;

            Form1.gui.MinerListBox.Items.Clear();

            string[] words = IP.Split('|');
            foreach (string word in words)
            {
                Form1.gui.MinerListBox.Items.Add(word);
            }

            Form1.gui.WriteLog("Backup Loaded from: " + path);
        }

    }
}
