﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regal_spice
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        public static decimal total = 0;
        public static DateTime orderTime;
        public static string comments;
        public static List<Dish> orderedItems = new List<Dish>();
        public static string orderNum;
        public static decimal stringNum = 0;
        public static decimal sumTot = 0;
        public static decimal changeReq = 0;

        static Program()
        {
            Program.total = Properties.Settings.Default.totalRev;
        }


        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new startupForm());
        }
    }
}
