using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Net;

namespace AppliFrais
{
    class Module
    {
        public static bool PingTeste(string adresseIP)
        {
            try
            {
                Ping pingSender = new Ping(); ;
                PingOptions options;
                pingSender = new Ping();
                options = new PingOptions();
                options.DontFragment = true;

                String data = new String('a', 32);
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 120;

                IPHostEntry entry = Dns.GetHostEntry(adresseIP);
                PingReply reply = pingSender.Send(entry.AddressList[0], timeout, buffer, options);
                //PingReply reply = pingSender.Send(adresseIP);

                return reply.Status == IPStatus.Success;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool IsValidIP(string address)
        {
            IPAddress ip;
            if (address.Length >= 11 && IPAddress.TryParse(address, out ip) == true)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
