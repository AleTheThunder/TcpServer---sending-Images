using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace TcpServer___sending_Images
{
    class Program
    {
        static void Main()
        {
            TcpListener server = null;

            try
            {
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                int port = 8080;
                server = new TcpListener(localAddr, port);
                server.Start();

                Console.WriteLine($"Server gestartet auf {localAddr}:{port}");

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Verbunden mit einem Client");

                    NetworkStream stream = client.GetStream();

                    // Pfade für das Bild einrichten
                    string imagePath = "D:/Schule/MyStack/hehe/bild.jpeg";
                    byte[] imageBytes = File.ReadAllBytes(imagePath);

                    // Bildgröße senden
                    byte[] sizeBytes = BitConverter.GetBytes(imageBytes.Length);
                    stream.Write(sizeBytes, 0, sizeBytes.Length);

                    // Bild senden
                    stream.Write(imageBytes, 0, imageBytes.Length);

                    client.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                server.Stop();
            }
        }
    }
}
