using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Disskort_Server.Properties;

namespace Disskort_Server
{
    public partial class DisskortServer : Form
    {
        string chat = "-First Message: ";

        private static byte[] buffer = new byte[1024];

        private static List<Socket> clientSockets = new List<Socket>();

        private static Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public DisskortServer()
        {
            InitializeComponent();

            DisskortServer.CheckForIllegalCrossThreadCalls = false;

            if (!Settings.Default.UseVerificationCode)
            {
                InitServer();
            }
        }

        private void InitServer()
        {
            gbLogin.Enabled = false;
            gbStatus.Enabled = true;
            StartServer();
        }

        private void TbPasswordKeyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbPassword.Text == "passwordDisskort")
                {
                    InitServer();
                }
            }
        }

        private void StartServer()
        {
            try
            {
                lbStatus.Items.Clear();

                lbStatus.Items.Add("Starting server...");

                serverSocket.Bind(new IPEndPoint(IPAddress.Any, Settings.Default.Port));

                serverSocket.Listen(30);

                serverSocket.BeginAccept(AcceptCallback, null);

                lbStatus.Items.Add("StartServer started!");
                lbStatus.Items.Add($"Listening on port {Settings.Default.Port} ...");
                lbStatus.Items.Add("");

                btnShutDown.Enabled = true;
            }
            catch (Exception ex)
            {
                lbStatus.Items.Add($"Fatal Error -> {ex.Message}");
            }
        }

        private void AcceptCallback(IAsyncResult result)
        {
            Socket socket = serverSocket.EndAccept(result);

            clientSockets.Add(socket);

            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, socket);

            lbStatus.Items.Add("Client connected!");

            serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private void ReceiveCallback(IAsyncResult result)
        {
            try
            {
                Socket socket = (Socket)result.AsyncState;

                int received = socket.EndReceive(result);

                byte[] dataBuffer = new byte[received];

                Array.Copy(buffer, dataBuffer, received);

                string msg = Encoding.ASCII.GetString(dataBuffer);

                if (msg == "get VERSION")
                {
                    lbStatus.Items.Add($"Client requested VERSION!");
                    socket.Send(Encoding.ASCII.GetBytes(Settings.Default.Version), SocketFlags.None);
                }
                else if (msg == "update")
                {
                    lbStatus.Items.Add($"Client requested update!");

                    socket.Send(Encoding.ASCII.GetBytes(chat));
                }
                else
                {
                    lbStatus.Items.Add($"Client sent message: {msg}");

                    chat += msg + "|";

                    socket.Send(Encoding.ASCII.GetBytes(chat));
                }

                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);

                serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
            }
            catch (Exception)
            {
                lbStatus.Items.Add("Client disconnected!");
            }

            if (Encoding.ASCII.GetBytes(chat).Length > 1000)
            {
                chat = "Chat was cleared by host!|";
            }
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Turn off server? This will disconnect all clients!", "Disskort", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                btnShutDown.Enabled = false;

                Application.Exit();
            }
        }

        private void DisskortServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnShutDown.Enabled)
            {
                if (MessageBox.Show("Turn off server? This will disconnect all clients!", "Disskort", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
