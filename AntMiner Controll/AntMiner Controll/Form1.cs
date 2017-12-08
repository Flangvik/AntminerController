using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntMiner_Controll
{

    public partial class Form1 : Form


    {
        public static Form1 gui;

        public Form1()
        {
            InitializeComponent();
            gui = this;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckIPValid(IPText.Text))
            {
                MinerListBox.Items.Add(IPText.Text);
            }else
            {
                WriteLog(IPText.Text + " is NOT a valid IPv4 adress");
                
            }
           
        }

        public  void WriteLog(string log)
        {
    

            LogText.AppendText(log + "\n");
        
            
        }


        public void UpdateTextBox(string log)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(UpdateTextBox), new object[] { log });
                return;
            }
            LogText.Text += log + "\n";
            LogText.Update();

        }


        public static bool CheckIPValid(string strIP)
    {
        IPAddress result = null;
        return
            !String.IsNullOrEmpty(strIP) &&
            IPAddress.TryParse(strIP, out result);
    }

        private void ExecBtn_Click(object sender, EventArgs e)
        {

            backgroundWorker1.RunWorkerAsync();

        }
        void AddItems(string[] items)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { this.AddItems(items); });
                return;
            }
            ListViewItem[] range = (items.Select<string, ListViewItem>(item => new ListViewItem(item))).ToArray();
            MinerListBox.Items.AddRange(range);
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void LogText_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            string fan = "false";
            if (FanChkbox.Checked )
            {
                fan = "true";
            }
            if (MinerListBox.Items.Count > 0)
            {

               
                string tempfile = Path.GetTempPath() + "cgminer.conf";
                

                GenerateConfig config = new GenerateConfig(Pool1URLText.Text, Pool2URLText.Text, Pool3URLText.Text, Pool1WorkerText.Text, Pool2WorkerText.Text, Pool3WorkerText.Text, Pool1PWText.Text, Pool2PWText.Text, Pool3PWText.Text, fan,FanSpeedNum.Value);

                System.IO.File.WriteAllText(tempfile, config.GetConfig());
                UpdateTextBox("Generating config " + tempfile);


                // foreach (string IP in MinerListBox.SelectedItem)
                //{
                foreach (string IP in MinerListBox.SelectedItems)
                {
                    Form1.gui.UpdateTextBox("Checking if " + IP + " is alive");
                    Ping ping = new Ping();
                    PingReply pingReply = ping.Send(IP);

                    if (pingReply.Status == IPStatus.Success)
                    {
                        TcpClient tcpClient = new TcpClient();
                        try
                        {
                            tcpClient.Connect(IP, 22);
                            Form1.gui.UpdateTextBox("Connecting to: " + IP);
                            Communication.WriteConfig(IP, UsernameText.Text.Trim(), PasswordText.Text.Trim(), tempfile);

                            Form1.gui.UpdateTextBox("Done -> Restarting miner");
                            using (var client = new SshClient(IP, UsernameText.Text.Trim(), PasswordText.Text.Trim()))
                            {
                                client.Connect();
                                client.RunCommand("/etc/init.d/cgminer.sh restart >/dev/null 2>&1");
                                client.Disconnect();
                            }

                        }
                        catch (Exception)
                        {
                            Form1.gui.UpdateTextBox("SSH service is not running on " +IP);
                        }
                        
                    }
                    else
                    {
                        UpdateTextBox("IP: " + IP + " Seems to be unreachable");
                    }
                }

            
                //}
            }
            else
            {
                UpdateTextBox("You need to select miners to execute on from the list");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (FanChkbox.Checked)
            {
                FanSpeedNum.Enabled = true;
            }else
            {
                FanSpeedNum.Enabled = false;
            }
        }

        private void MinerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string IPList;
        
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPList = "";
            string defcred = "false";
            string fan = "false";
            if (FanChkbox.Checked)
            {
                fan = "true";
            }

            if (CredsChkBox.Checked)
            {
                defcred = "true";
            }


            foreach (string IP in MinerListBox.Items)
            {
                IPList += IP + "|";
            }


            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                UserData.SaveData(saveFileDialog1.FileName, Pool1URLText.Text, Pool2URLText.Text, Pool3URLText.Text, Pool1WorkerText.Text, Pool2WorkerText.Text, Pool3WorkerText.Text, Pool1PWText.Text, Pool2PWText.Text, Pool3PWText.Text, fan, FanSpeedNum.Value, IPList,defcred,UsernameText.Text,PasswordText.Text);

            }

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                UserData.LoadData(openFileDialog1.FileName);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LogText.Clear();
         

        }

        private void CredsChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!CredsChkBox.Checked)
            {
                UsernameText.Enabled = true;
                PasswordText.Enabled = true;

            }else
            {
                UsernameText.Enabled = false;
                PasswordText.Enabled = false;
            }
        }
    }
}
