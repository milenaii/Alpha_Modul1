using System;

namespace ParseURL
{
    class StUpParseURL
    {
        static void Main()
        {
            string address = Console.ReadLine();

            int endProt = address.IndexOf("://");
            string protocol = address.Substring(0, endProt);

            int endServ = address.IndexOf("/", endProt + 3);
            string server = address.Substring(endProt + 3, endServ - endProt - 3);

            string resource = address.Substring(endServ, address.Length - endServ);

            Console.WriteLine("[protocol] = "+ protocol + "\n[server] = "+ server + "\n[resource] = " + resource);
            
        }
    }
}
