using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
namespace LearnNewWords
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // tword tword = new tword();
            //Thread t = new Thread(tword.ShowListWord);
            //Application.Run(tword);
            Application.Run(new formWord());
        }
    }
}
