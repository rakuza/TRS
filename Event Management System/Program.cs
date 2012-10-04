using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Event_Management_System
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

            StreamReader sr = new StreamReader(Path.GetDirectoryName(Application.ExecutablePath)+"\\init.txt");
            if (int.Parse(sr.ReadLine().ToString()) == 1)
            {
                Application.Run(new Prefs());
                sr.Close();
                StreamWriter sw = new StreamWriter(Path.GetDirectoryName(Application.ExecutablePath) + "\\init.txt",false);
                sw.WriteLine("0");
                sw.Close();
            }
            
            Application.Run(new SpashScreen());
            Application.Run(new Main());
            /*
            try
            {
                Application.Run(new Main());
                
            }
            catch (Exception ex)
            {
                BugForm bf = new BugForm();
                bf.Exception = ex;
                Application.Run(bf);
            }
             * */
        }

    }
}
