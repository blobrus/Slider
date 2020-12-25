﻿using System;
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

            if (p != null)
            {
                IntPtr h = p.MainWindowHandle;
                SetForegroundWindow(h);
            }

            foreach (string command in commandsList)
            {
                int sleepDelay = rand.Next(50, 150);

                if (!GlobalVariables.isRunning)
                {
                    return;
                }
                if (p != null)
                {

                    if (command.Contains("up"))
                    {
                        SendKeys.SendWait("{UP}");
                        Task.Delay(sleepDelay).Wait();
                    }
                    else if (command.Contains("left"))
                    {
                        SendKeys.SendWait("{Left}");
                        Task.Delay(sleepDelay).Wait();
                    }
                    else if (command.Contains("right"))
                    {
                        SendKeys.SendWait("{RIGHT}");
                        Task.Delay(sleepDelay).Wait();
                    }
                    else if (command.Contains("down"))
                    {
                        SendKeys.SendWait("{DOWN}");
                        Task.Delay(sleepDelay).Wait();

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
            //Console.WriteLine(inst);

            string[] commands = inst.Split(' ');
            return commands;
        }
    }
}
