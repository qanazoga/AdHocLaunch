/*
    qanazoga AdHocLauncher Version 1
    Copyright (C) 2015  qanazoga
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdHocLaunch
{
    static class Initiator
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdHocGui());
        }
    }
}

