﻿using System;
using System.Windows.Forms;

namespace Remote_Control_PC {
    public static class Program {

        [STAThread]
        public static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmptyForm());
        }
    }
}
