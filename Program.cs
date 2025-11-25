using System;
using System.Windows.Forms;
using labs3.Forms;

namespace labs3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}