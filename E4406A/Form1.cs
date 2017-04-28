using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Net.Sockets;

// places of goodness
// http://csharp.net-informations.com/communications/csharp-client-socket.htm
// http://cp.literature.agilent.com/litweb/pdf/E4406-90303.pdf
// http://www.keysight.com/main/software.jspx?cc=US&lc=eng&ckey=2175637&nid=-33330.977662&id=2175637
// http://www.keysight.com/main/software.jspx?cc=US&lc=eng&nid=-11143.0.00&id=2235963&pageMode=CV
// http://www.matsolutions.com/Portals/0/Product%20documents/Willtek%20(now%20Aeroflex)/9102/9102%20User's%20Guide.pdf


namespace E4406A
{
    public partial class Form1 : Form
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void tbFrequency_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                tbStatus.Text = "Client Starting";
                clientSocket.Connect("192.168.0.200", 5023);
                tbStatus.Text = "Client Start";
            }
            catch
            {
                tbStatus.Text = "Client connection Failed!";
            }
        }

        private void sendRequestE4406(string stuff)
        {
            try 
            {
                NetworkStream serverStream = clientSocket.GetStream();
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(tbFrequency.Text);
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                byte[] inStream = new byte[10025];
                serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
                string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                tbCurrentFrequency.Text = returndata;
            }
            catch
            {
                tbOutput.AppendText("failed to send request");
            }
        }

        private void tbFrequency_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            sendRequestE4406("stuff");
        }
    }
}
