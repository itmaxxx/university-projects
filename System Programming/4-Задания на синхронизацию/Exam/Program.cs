using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    static class Program
    {
        private static Mutex mutex;
        private const string guid = "{2CF50312-D6E9-44CC-9F03-758D9F063DD9}";

        [STAThread]
        static void Main()
        {
            bool createdNew;
            mutex = new Mutex(true, guid, out createdNew);

            if (!createdNew)
			{
                return;
			}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
