using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
	class Program
	{
        private static IPAddress remoteIPAddr = IPAddress.Parse("127.0.0.1");
        private static int remotePort = 5000;

        static void Main(string[] args)
        {
            Console.Title = "Server";

            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                while (true)
				{
                    SendData(DateTime.Now.ToString());

                    Console.Clear();
					Console.WriteLine(DateTime.Now.ToString());

                    Thread.Sleep(1000);
				}
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void SendData(string datagramm)
        {
            var udpClient = new UdpClient();
            var ipEnd = new IPEndPoint(remoteIPAddr, remotePort);

            try
            {
                byte[] bytes = Encoding.Unicode.GetBytes(datagramm);

                udpClient.Send(bytes, bytes.Length, ipEnd);
            }
            catch (SocketException sockEx)
            {
                Console.WriteLine($"Ошибка сокета: {sockEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            finally
            {
                udpClient.Close();
            }
        }
    }
}
