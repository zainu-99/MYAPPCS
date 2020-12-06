using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAPPCS.Helper
{
    class GetComputerInfo
    {
#pragma warning disable CS0618 // Type or member is obsolete
        public static string GetIPAddress() => System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList[0].ToString();
#pragma warning restore CS0618 // Type or member is obsolete
        public static String GetHostName() => System.Net.Dns.GetHostName();
    }
}
