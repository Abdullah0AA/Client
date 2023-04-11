using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    public partial class ClientForm : Form
    {

        private IPEndPoint endPoint;
        private IPAddress iPAddress;
        private int PORT_NUM;
        private Socket server;
        private byte[] data;
        private int bytesReceived;


        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {


        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            PORT_NUM = Convert.ToInt32(txtPortNr.Text);
            iPAddress = IPAddress.Parse(txtServerIP.Text);
            endPoint = new IPEndPoint(iPAddress, PORT_NUM);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Connect(endPoint);

            // Start receiving data from server
            Thread receiveThread = new Thread(ReceiveData);
            receiveThread.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            byte[] data = Encoding.ASCII.GetBytes(txtDataToServer.Text);
            server.Send(data);

        }

        private void ReceiveData()
        {
            while (true)
            {
                try
                {
                    // Receive data from server
                    data = new byte[1024];
                    bytesReceived = server.Receive(data);
                    string message = Encoding.ASCII.GetString(data, 0, bytesReceived);

                    // Update UI with received message
                    Invoke((MethodInvoker)delegate
                    {
                        txtDataFromServer.AppendText("Server: " + message + Environment.NewLine);
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    break;
                }
            }
        }
    }
}