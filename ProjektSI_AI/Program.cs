using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektSI_AI
{
    static class Program
    {
        private static int liczba_zajec = 0;
        public static string[] nazwa_zajecia = new string[100];
        private static int[] chas_rospoczecia = new int[100];
        private static int[] chas_zakonczenia = new int[100];

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static public void Add (string nazwa, int cr, int cz)
        {
            liczba_zajec++;
            nazwa_zajecia[liczba_zajec] = nazwa;
            chas_rospoczecia[liczba_zajec] = cr;
            chas_zakonczenia[liczba_zajec] = cz;
        }
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
