﻿using System;
using System.Windows.Forms;

namespace NT106.M21__Nhom09_55
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MailApp());
        }
    }
}