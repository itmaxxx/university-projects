using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace UdpChat
{
    class Program
    {
        private static int localPort = 5000;
        private static IPAddress remoteIPAddr = IPAddress.Parse("127.0.0.1");

        static void Main(string[] args)
        {
            Console.Title = "Client";

            try
            {
                ReceiveThreadProc();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void ReceiveThreadProc()
        {
            try
            {
                while (true)
                {
                    var udpClient = new UdpClient(localPort);

                    IPEndPoint ipEnd = null;
                    byte[] responce = udpClient.Receive(ref ipEnd);

                    string strResult = Encoding.Unicode.GetString(responce);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(strResult);

                    udpClient.Close();
                }
            }
            catch (SocketException sockEx)
            {
                Console.WriteLine($"Ошибка сокета: {sockEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
