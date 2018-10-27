using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combinatorFirstRest
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            /*int[] perm = Perm.getFirstPerm(3);
            Console.WriteLine(String.Join(",", perm));
            while(Perm.getNextPerm(ref perm) == true)
            {
                Console.WriteLine(String.Join(",", perm));
            }*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RestForm());
        }
    }
}
