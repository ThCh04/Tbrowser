using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace Tbrowser
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            TbCont tb = new TbCont();
            tb.Tabs.Add(new EasyTabs.TitleBarTab(tb) { 
            Content=new Form1 { }
            });
            tb.SelectedTabIndex = 0;
            TitleBarTabsApplicationContext appcont = new TitleBarTabsApplicationContext();
            appcont.Start(tb);
            Application.Run(appcont);
        }
    }
}
