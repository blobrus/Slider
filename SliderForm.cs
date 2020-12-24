using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;  // For hotkeys

namespace Slider
{
    public partial class SliderForm : Form
    {
        Solve solveThread = new Solve();
        // Importing RegisterHotKey Method
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        public SliderForm()
        {
            InitializeComponent();

            //Registering hotkeys
            int startHotKey = 1;
            int stopHotKey = 2;
            int clearHotKey = 3;

            int startKeyCode = (int)Keys.F9;
            int stopKeyCode = (int)Keys.F10;
            int clearKeyCode = (int)Keys.F11;

            Boolean startRegistered = RegisterHotKey(this.Handle, startHotKey, 0x0000, startKeyCode);
            Boolean stopRegistered = RegisterHotKey(this.Handle, stopHotKey, 0x0000, stopKeyCode);
            Boolean clearRegistered = RegisterHotKey(this.Handle, clearHotKey, 0x0000, clearKeyCode);


            if (startRegistered)
            {
                Console.WriteLine("Start successfully registered");
            }
            if (stopRegistered)
            {
                Console.WriteLine("Stop successfully registered");
            }
            if (clearRegistered)
            {
                Console.WriteLine("Clear successfully registered");
            }

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("F9 pressed!");
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();

                switch (id)
                {
                    case 1:
                        GlobalVariables.isRunning = true;
                        SolverData sd = new SolverData(StepText.Text);
                        Solve s = new Solve();
                        Thread thr = new Thread(s.StartSolving);
                        thr.Start(sd);
                        break;
                    case 2:
                        GlobalVariables.isRunning = false;
                        break;
                    case 3:
                        StepText.Clear();
                        break;
                }
            }

            base.WndProc(ref m);
        }
    }
}
