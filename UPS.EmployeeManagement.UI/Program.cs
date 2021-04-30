using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPS.EmployeeManagement.UI
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

            Log.Logger = new LoggerConfiguration()
                      .WriteTo.File("log.txt")
                      .CreateLogger();

            Application.Run(new EmployeeManagement(Log.Logger));
        }
    }
}
