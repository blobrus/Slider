using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Slider
{
    public class Solve
    {
        public Solve()
        {

        }

        public static void startSolving()
        {
            MessageBox.Show("Worked!");
            GlobalVariables.isRunning = false;

            return;
        }
    }
}
