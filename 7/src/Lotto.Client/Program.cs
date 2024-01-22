using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Windows.Forms;
using Lotto.Data;

namespace Lotto.Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RemotingConfiguration.Configure("Lotto.Client.exe.config");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LottoView());
        }
    }
}
