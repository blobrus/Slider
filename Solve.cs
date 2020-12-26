using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Slider
{
    public class Solve
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        public Solve()
        {

        }

        public void StartSolving(object data)
        {          
            SolverData sd = (SolverData)data;
            string[] commandsList = Commands(sd.Instructions);
            var rand = new Random();
            Process p = Process.GetProcessesByName("rs2client").FirstOrDefault();


            foreach (string command in commandsList)
            {
                int sleepDelay = rand.Next(100, 110);

                if (!GlobalVariables.isRunning)
                {
                    return;
                }
                if (p != null)
                {
                    IntPtr h = p.MainWindowHandle;
                    SetForegroundWindow(h);

                    if (command.Contains("up"))
                    {
                        SendKeys.SendWait("{UP}");
                        Thread.Sleep(sleepDelay);
                    }
                    else if (command.Contains("left"))
                    {
                        SendKeys.SendWait("{Left}");
                        Thread.Sleep(sleepDelay);
                    }
                    else if (command.Contains("right"))
                    {
                        SendKeys.SendWait("{RIGHT}");
                        Thread.Sleep(sleepDelay);
                    }
                    else if (command.Contains("down"))
                    {
                        SendKeys.SendWait("{DOWN}");
                        Thread.Sleep(sleepDelay);
                    }

                }                
            }

            GlobalVariables.isRunning = false;

            return;
        }

        private static string[] Commands(string instructions)
        {
            string inst = instructions;
            string delete = "";

            inst = Regex.Replace(inst, "[0-9]+", delete);
            inst = Regex.Replace(inst, @"\.", delete);
            inst = Regex.Replace(inst, "n", "n ");
            inst = Regex.Replace(inst, "t", "t ");
            inst = Regex.Replace(inst, "p", "p ");

            string[] commands = inst.Split(' ');
            return commands;
        }
    }
}
