
using System;
using System.Windows.Forms;
using WinSCP;

namespace AntMiner_Controll
{
     class Communication
    {
        
        public static void WriteConfig(string HostName, string UserName, string Password,string file)

        {
            try
            {
              
                // Setup session options
                SessionOptions sessionOptions = new SessionOptions
                {
                    Protocol = Protocol.Scp,
                    HostName = HostName,
                    UserName = UserName,
                    Password = Password,
                    GiveUpSecurityAndAcceptAnySshHostKey = true

                };



                using (Session session = new WinSCP.Session())


                {
                    Form1 FormHandle = new Form1();
                 
                    // Connect
                    session.Open(sessionOptions);



                    // Upload files
                    TransferOptions transferOptions = new TransferOptions();
                    transferOptions.TransferMode = TransferMode.Binary;

                    TransferOperationResult transferResult;
                    transferResult =
                        session.PutFiles(file, "/config/cgminer.conf", true, transferOptions);

                    // Throw on any error
                    transferResult.Check();

                    // Print results
                    foreach (TransferEventArgs transfer in transferResult.Transfers)
                    
                    {

                        Form1.gui.UpdateTextBox( "Upload of " + transfer.FileName + " succeeded");
                    }




                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
                MessageBox.Show("ERROR: " + e, "AntMiner Controller", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }
        }


    }
}
