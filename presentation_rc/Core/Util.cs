using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace NozzhaPRC.Core
{
    /// <summary>
    /// Contains some utility methods
    /// </summary>
    class Util
    {
        /// <summary>
        /// Finds an active IP address of Wi-Fi network adapter
        /// </summary>
        /// <see cref="http://stackoverflow.com/a/10060249/4112200"/>
        /// <returns>Active IP address or null if non</returns>
        public static IPAddress getWiFiLocalIP()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType != NetworkInterfaceType.Wireless80211)
                    continue;

                foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                {
                    if (ip.Address.AddressFamily != AddressFamily.InterNetwork)
                        continue;

                    if (!IsActiveLocalIpAddress(ip.Address.ToString()))
                        continue;

                    return ip.Address;
                }
            }

            return null;
        }

        /// <summary>
        /// Checks if the provided host or ip is active and points to localhost
        /// </summary>
        /// <see cref="http://www.csharp-examples.net/local-ip/"/>
        /// <param name="host">Hostname or IP address</param>
        /// <returns>true if the provided IP or host is active and points to localhost, false otherwise</returns>
        public static bool IsActiveLocalIpAddress(string host)
        {
            try
            {
                // get host IP addresses
                IPAddress[] hostIPs = Dns.GetHostAddresses(host);
                // get local IP addresses
                IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());

                // test if any host IP equals to any local IP or to localhost
                foreach (IPAddress hostIP in hostIPs)
                {
                    // is localhost
                    if (IPAddress.IsLoopback(hostIP))
                        return true;

                    // is local address
                    foreach (IPAddress localIP in localIPs)
                    {
                        if (hostIP.Equals(localIP))
                            return true;
                    }
                }
            }
            catch { }
            return false;
        }
    }
}
