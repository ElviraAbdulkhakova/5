using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using triangle = WindowsFormsApplication1.Program.Triangle;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {
            using (System.IO.StreamWriter file = 
                new System.IO.StreamWriter(triangle.path_to_log, true))
                file.WriteLine(DateTime.Now.ToString() + " Application Start");  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //call Form1
            Application.Run(new Form1());
            
        }
        public static class Triangle
        {
            //a ,b, c - the side of triangle
            public static int a {get; set;}
            public static int b { get; set; }
            public static int c { get; set; }
            public static double perimetr { get; set; }
            public static double area { get; set; }

            public static bool is_perimetr = false;

            public static bool is_area = false;

            //path to Logfile
            public static string path_to_log = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)+"\\Log.txt";


        }
    }
}
