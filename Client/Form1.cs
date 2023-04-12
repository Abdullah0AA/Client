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
            PORT_NUM = Convert.ToInt32(txtPortNr.Text);
            iPAddress = IPAddress.Parse(txtServerIP.Text);
            client = new Client(iPAddress, PORT_NUM);

            client.DataReceived += onDataReceived;
            client.Error += OnError;

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client.Connect();
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

    }
}