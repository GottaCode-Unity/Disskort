using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using Disskort.Properties;

namespace Disskort
{
    public partial class DisskortWindow : Form
    {
        private static async Task<string> SendMessage(Socket socket, string message)
        {
            clientSocket.Send(Encoding.ASCII.GetBytes(message));

            await Task.Delay(100);

            byte[] buffer = new byte[1024];
            int rec = socket.Receive(buffer);
            byte[] data = new byte[rec];

            Array.Copy(buffer, data, rec);

            return Encoding.ASCII.GetString(data);
        }

        bool servershutdown = false;

        private static Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public DisskortWindow()
        {
            InitializeComponent();

            DisskortWindow.CheckForIllegalCrossThreadCalls = false;
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbAdminKey.Focus();
            }
        }

        private void tbAdminKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConnect.PerformClick();
            }
        }

        private void tbCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSendCommand.PerformClick();
            }
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (tbName.Text.ToLower().Contains("admin") || tbName.Text.Length > 10 || tbName.Text.Length < 3 || tbName.Text.Contains("|") || tbName.Text.Contains(":"))
            {
                MessageBox.Show("Your name has to have a length between 3 and 10! Illegal letters: | :", "Disskort", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbAdminKey.Text == "passwordDisskort")
            {
                gbAdminLogin.Enabled = false;

                gbAdminConsole.Enabled = true;

                gbChat.Enabled = true;

                timerChatUpdate.Enabled = true;

                await ActivateClient(true);
            }
            else
            {
                gbAdminLogin.Enabled = false;

                gbChat.Enabled = true;

                timerChatUpdate.Enabled = true;

                await ActivateClient(false);
            }
        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }

        async Task ActivateClient(bool admin)
        {
            do
            {
                try
                {
                    lbChat.Items.Clear();

                    lbChat.Items.Add("Trying to connect to server...");

                    lbChat.Update();

                    clientSocket.Connect(Settings.Default.IP, Settings.Default.Port); // für lokalen test habe ich die ip durch IPAddress.Loopback verwendet;
                }
                catch (Exception)
                {
                    lbChat.Items.Add("Failed!");

                    lbChat.Update();

                    Thread.Sleep(1000);
                }
            } while (!clientSocket.Connected);


            if (Settings.Default.WithVersionCheck)
            {
                lbChat.Items.Add("Checking version...");
                lbChat.Update();

                string dataReceived = await SendMessage(clientSocket, "get version");

                if (dataReceived == Settings.Default.Version)
                {
                    lbChat.Items.Add("Version verified!");
                    lbChat.Items.Add("");
                }
                else
                {
                    lbChat.Items.Add("Outdated version!");

                    MessageBox.Show(
                        "Your using an old version of Disskort! Please get the new version on http://disskortchat.wixsite.com/disskort/",
                        "Disskort", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Application.Exit();
                }

            }

            lbChat.Items.Add("Connected!");
            lbChat.Update();
            Thread.Sleep(500);
            lbChat.Items.Clear();
        }

        private async void timerChatUpdate_Tick(object sender, EventArgs e)
        {
            try
            {
                UpdateChat(await SendMessage(clientSocket, "update"));
            }
            catch (Exception)
            {
                if (!servershutdown)
                {
                    servershutdown = true;

                    MessageBox.Show("Server was shut down!", "Disskort");

                    Application.Exit();
                }
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (tbMessage.Text != "" && !tbMessage.Text.Contains("|") && !tbMessage.Text.Contains(":"))
            {
                UpdateChat(await SendMessage(clientSocket, $"{tbName.Text}: {tbMessage.Text}"));

                tbMessage.Text = "";
            }
            else if (tbMessage.Text.Contains("|") || tbMessage.Text.Contains(":"))
            {
                MessageBox.Show("Illegal letters: | :", "Disskort", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateChat(string chat)
        {
            string[] chatToUpdate = chat.Split('|');

            string[] currentChat = new string[lbChat.Items.Count];

            int index = 0;

            foreach (string item in lbChat.Items)
            {
                currentChat[index] = item;

                index++;
            }

            if (chatToUpdate[0] == "Chat was cleared by host!")
            {
                lbChat.Items.Clear();
            }

            for (int i = 1; i < chatToUpdate.Length - 1; i++)
            {
                try
                {
                    string test = currentChat[i];
                }
                catch (Exception)
                {
                    lbChat.Items.Add(chatToUpdate[i]);
                }
            }
        }
    }
}
