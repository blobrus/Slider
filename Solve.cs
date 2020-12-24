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

        public void StartSolving(object data)
        {          
            SolverData sd = (SolverData)data;
            MessageBox.Show($"{sd.Instructions}");
            GlobalVariables.isRunning = false;

            return;
        }
    }
}
