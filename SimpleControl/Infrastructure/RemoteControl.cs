using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SimpleControl.Infrastructure
{
    public class RemoteControl : IRemoteControl
    {
        private readonly TcpClient _tcpClient;
        private readonly NetworkStream _networkStream;

        public RemoteControl(string ipAddress, int portNumber)
        {
            try
            {
                _tcpClient = new TcpClient(ipAddress, portNumber);
                _networkStream = this._tcpClient.GetStream();
            }
            catch(SocketException err)
            {
                throw new RemoteControlException($"Błąd połączenia: {err.Message}", err);
            }
            
        }

        private byte[] toBytes(string command)
        {
            command += "\r";
            return System.Text.Encoding.ASCII.GetBytes(command);
        }

        private void send(byte[] data)
        {
            try
            {
                _networkStream.Write(data, 0, data.Length);
            }
            catch(System.IO.IOException err)
            {
                throw new RemoteControlException("Błąd przesyłania danych", err);
            }
        }

        public void Backward()
        {
            send(toBytes("b"));
        }

        public void Forward()
        {
            send(toBytes("f"));
        }

        public void Left()
        {
            send(toBytes("l"));
        }

        public void Right()
        {
            send(toBytes("r"));
        }

        public void Stop()
        {
            send(toBytes("s"));
        }

        public void Dispose()
        {
            _networkStream.Close();
            _tcpClient.Close();
        }
    }
}
