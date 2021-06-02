using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace text_from_photo_slave
{
    class Receiver
    {
        private TcpListener listener = new TcpListener(IPAddress.Any, 80);

        public static string path;
        public static string Message = "Stopped";

        public void StartServer()
        {
            try
            {
                listener.Start();
                Message = "Started";
                while(true)
                {
                    using (var client = listener.AcceptTcpClient())
                    using (var stream = client.GetStream())
                    {
                        byte[] fileNameLenghtBytes = new byte[4];
                        stream.Read(fileNameLenghtBytes, 0, 4);
                        int fileNameLenght = BitConverter.ToInt32(fileNameLenghtBytes, 0);
                        byte[] fileNameBytes = new byte[fileNameLenght];
                        stream.Read(fileNameBytes, 0, fileNameLenght);
                        string fileName = Encoding.ASCII.GetString(fileNameBytes, 0, fileNameLenght);
                        using(var output = File.Create(fileName))
                        {
                            Message = "Saving file..";
                            var buffer = new byte[1024];
                            int bytesRead;
                            while((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                output.Write(buffer, 0, bytesRead);
                            }
                        }
                        Message = "Saving file complete";
                    }
                }
            }
            catch(Exception exc)
            {
                Message = exc.Message;
            }
            finally
            {
                listener.Stop();
            }
        }
    }
}
