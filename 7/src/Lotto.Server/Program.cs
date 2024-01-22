using System;
using System.Runtime.Remoting;

namespace Lotto.Server
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RemotingConfiguration.Configure("Lotto.Server.exe.config");

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}