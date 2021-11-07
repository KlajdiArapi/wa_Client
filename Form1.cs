using MaterialSkin.Controls;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace wa_Client
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        byte[] bytes;


        private void sendMex()
        {
            // Data buffer for incoming data.  
            bytes = new byte[1024];

            // Connect to a remote device.  
            try
            {
                // Establish the remote endpoint for the socket.  
                // This example uses port 11000 on the local computer.  
                ipAddress = IPAddress.Parse(txtHost.Text);
                remoteEP = new IPEndPoint(ipAddress, 11000);

                // Create a TCP/IP  socket.  
                sckt = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.  
                try
                {
                    sckt.Connect(remoteEP);

                    Chat.Items.Add("Socket connected to: " +
                        sckt.RemoteEndPoint.ToString());

                    // Encode the data string into a byte array.  
                    byte[] msg = Encoding.ASCII.GetBytes(txtMex.Text + "<EOF>");

                    // Send the data through the socket.  
                    int bytesSent = sckt.Send(msg);

                    // Receive the response from the remote device.  
                    int bytesRec = sckt.Receive(bytes);

                    Chat.Items.Add("Echoed message = " +
                        Encoding.ASCII.GetString(bytes, 0, bytesRec));

                    // Release the socket.  
                    sckt.Shutdown(SocketShutdown.Both);
                    sckt.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMex.Text!=null)
            {
                sendMex();
                txtMex.Clear(); 
            }
        }

        IPAddress ipAddress;
        Socket sckt;
        IPEndPoint remoteEP;

        private void txtMex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter && txtMex.Text != "")
            {
                sendMex();
                txtMex.Clear();
            }
        }
    }
}

