using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    public partial class ClientForm : Form
    {
        private Client client;

        private IPAddress iPAddress;
        private int PORT_NUM;




        public ClientForm()
        {
            InitializeComponent();

            client = new Client();

            client.DataReceived += onDataReceived;
            client.Error += OnError;

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            iPAddress = IPAddress.Parse(txtServerIP.Text);
            PORT_NUM = Convert.ToInt32(txtPortNr.Text);
            client.Connect(iPAddress, PORT_NUM);
        }
        private void OnError(object? sender, string message)
        {
            MessageBox.Show(message);
        }

        private void onDataReceived(object? sender, string message)
        {
            Invoke((MethodInvoker)delegate
            {
                txtDataFromServer.Text += "Client: " + message + Environment.NewLine;
            });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            client.SendData(txtDataToServer.Text);

        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Notify the server that the client is disconnecting
            
            client.SendData("disconnect");

         
        }
    }
}