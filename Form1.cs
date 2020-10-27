using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Chatapp
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint eplocal, epRemote;
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setup socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            // Geting Local Ip 
            GetLocalIP();
            

        }

        
        private void start_Click(object sender, EventArgs e)
        {
            //binding Socket
           eplocal = new IPEndPoint(IPAddress.Parse(localipp.Text), Convert.ToInt32(localport.Text));
            sck.Bind(eplocal);
            //sck.Connect(eplocal);
            //connecting to remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(remoteip.Text), Convert.ToInt32(remoteport.Text));
            sck.Connect(epRemote);

            //Listening the specific port
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        private void GetLocalIP()
        {

            IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName()); //it will get the ip of pc
            foreach (IPAddress address in localip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork) //search for the ip in the network
                    localipp.Text = address.ToString(); // Put the ip in text box
            }
            /*   IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            
               
            }
            return "192.168.1.1";
            */

        }

        private void Send_Click(object sender, EventArgs e)
        {
            //Convert string message to byte[]
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(Textmessage.Text);

            //sending the encoded message
            sck.Send(sendingMessage);

            //Adding to the listbox
            listmessage.Items.Add("Me: " + Textmessage.Text);
            Textmessage.Text = "";

        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                //Converting byte[] to string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                //Adding this message into Listbox
                listmessage.Items.Add("Friend: " + receivedMessage);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
