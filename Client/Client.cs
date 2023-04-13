using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Client
    {
        private IPAddress iPAddress;
        private int portNum;
        private EndPoint endPoint;
        private Socket server;
        private byte[] data;
        private int bytesReceived;
        public event EventHandler<string> DataReceived;
        public event EventHandler<string> Error;


        /// <summary>
        /// Establishes a connection to a remote host using the provided IP address and port number.
        /// </summary>
        /// <param name="iPAddress">The IP address of the remote host to connect to.</param>
        /// <param name="portNum">The port number to use for the connection.</param>
        public void Connect(IPAddress iPAddress, int portNum)
        {
            endPoint = new IPEndPoint(iPAddress, portNum);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Connect(endPoint);
            Thread receiveThread = new Thread(ReceiveData);
            receiveThread.Start();
        }

        /// <summary>
        /// Receives data from the server in a loop and raises the DataReceived event for each received message.
        /// If an error occurs during the data receive process, the Error event is raised with an exception message.
        /// </summary>
        private void ReceiveData()
        {
            while (true)
            {
                try
                {
                    if (server.Available > 0)
                    {
                        // Receive data from server
                        data = new byte[server.Available];
                        bytesReceived = server.Receive(data);
                        string message = Encoding.ASCII.GetString(data, 0, bytesReceived);

                        // Raise DataReceived event with received message
                        OnDataReceived(message);
                    }
                }
                catch (Exception ex)
                {
                    // Raise Error event with exception message
                    OnError(ex.Message);
                    break;
                }
            }
        }

        /// <summary>
        /// An event that is raised when an error occurs in the client.
        /// </summary>
        private void OnError(string message)
        {
            Error?.Invoke(this, message);
        }

        /// <summary>
        /// An event that is raised when data is received from the server.
        /// </summary>
        private void OnDataReceived(string message)
        {
            DataReceived?.Invoke(this, message);
        }

        /// <summary>
        /// Sends a string message to the server using the Send method of the Socket class.
        /// If an error occurs during the data send process, the Error event is raised with an exception message.
        /// </summary>
        /// <param name="message">The string message to send to the server.</param>
        public void SendData(string message)
        {
            try
            {
                // Convert message to byte array and send to server
                byte[] data = Encoding.ASCII.GetBytes(message);
                server.Send(data);
            }
            catch (Exception ex)
            {
                // Raise Error event with exception message
                Error?.Invoke(this, ex.Message);
            }
        }

        /// <summary>
        /// Stops the client and disconnects from the server.
        /// </summary>
        public void Stop()
        {
            server?.Close();
            
        }
    }

}
