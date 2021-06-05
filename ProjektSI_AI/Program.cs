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
        private static bool[] wybrane = new bool[100];
        private static int global_count;
        private static int global_current = -1;

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
        static public void Algorytm (int count)
        {
            global_count = count;
            for (int i = 0; i<=count; i++)
            {
                if ((i % 2) == 1)
                    wybrane[i] = true;
                else
                    wybrane[i] = false;
            }
        }
        static public string Give ()
        {
            global_current++;
            if (global_current > global_count) return "END";
            if (wybrane[global_current] == true)
                return (nazwa_zajecia[global_current] + ' ' + ((int)(chas_rospoczecia[global_current]/60)).ToString() + ':' + ((int)(chas_rospoczecia[global_current] % 60))
                    + '-' + ((int)(chas_zakonczenia[global_current] / 60)).ToString() + ':' + ((int)(chas_zakonczenia[global_current] % 60)));
            else
                return "SKIP";
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