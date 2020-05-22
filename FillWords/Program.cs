using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillWords
{
    static class Program
    {
        public static MainMenuForm MainMenuForm
        {
            get => default;
            set
            {
            }
        }

        internal static Properties.Settings Settings
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());
        }
    }
}
