﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PatajeMedia
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Fms.getmain<FrCtl>());
        }

        
    }
}
