using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using log4net;

namespace LogSample
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            ILog log = Log.getLogger();

            log.Info("===== Program Start");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            log.Info("===== Program End");
        }
    }
}
