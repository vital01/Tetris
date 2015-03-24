using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    public static class Network
    {
        private static TcpListener Server { get; set; }
        private static TcpClient Client { get; set; }

        public static void StartServer()
        {
            Server = new TcpListener(IPAddress.Any, 8080);
            Animator.FlickerLabel(MainForm.Instance.openGameLabel, 100, 10, new Action
                (delegate()
                {
                    try
                    {
                        Server.Start();
                        MainForm.ShowNetworkGame();
                        AcceptClients();
                    }
                    catch (SocketException)
                    {
                        MainForm.ShowError("Game is already running!");
                    }
                }));
            SoundPlayer.PlaySound(SoundPlayer.Sounds.Select_0);
        }

        public static void AcceptClients()
        {
            bool accepted = false;
            while (true)
            {
                TcpClient client = Server.AcceptTcpClient();
                if (accepted)
                {
                    client.Client.Send(Encoding.UTF8.GetBytes("-"));
                }
                else
                {
                    accepted = true;
                    client.Client.Send(Encoding.UTF8.GetBytes("+"));
                }
            }
        }

        public static void ConnectToServer(string ipString)
        {
            Client = new TcpClient();
            Animator.FlickerLabel(MainForm.Instance.joinGameLabel, 100, 10, new Action
                (delegate()
                {
                    IPAddress ipAddress;
                    if (IPAddress.TryParse(ipString, out ipAddress))
                    {
                        try
                        {
                            if (Client.ConnectAsync(ipAddress, 8080).Wait(2000))
                            {
                                RecievePermission();
                            }
                            else
                            {
                                MainForm.ShowError("Game is not opened yet!");
                            }
                        }
                        catch (AggregateException)
                        {
                            MainForm.ShowError("Game is not opened yet!");
                        }
                    }
                    else
                    {
                        MainForm.ShowError("Invalid IP address!");
                    }
                }));
            SoundPlayer.PlaySound(SoundPlayer.Sounds.Select_0);           
        }

        public static void RecievePermission()
        {
            byte[] buffer = new byte[1];
            Client.Client.Receive(buffer);
            if (Encoding.UTF8.GetString(buffer) == "-")
            {
                MainForm.ShowError("Game is already running!");
                Client.Close();
            }
            else
            {
                MainForm.ShowNetworkGame();
            }
        }
    }
}
