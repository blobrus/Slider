using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;  // For hotkeys

namespace Slider
{
    public partial class SliderForm : Form
    {
        // Importing RegisterHotKey Method
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        public SliderForm()
        {
            InitializeComponent();

            //Registering hotkeys
            int startHotKey = 1;
            int stopHotKey = 2;
            int resetHotKey = 3;

            int startKeyCode = (int)Keys.F9;
            int stopKeyCode = (int)Keys.F10;
            int resetKeyCode = (int)Keys.F11;

            Boolean startRegistered = RegisterHotKey(this.Handle, startHotKey, 0x0000, startKeyCode);
            Boolean stopRegistered = RegisterHotKey(this.Handle, stopHotKey, 0x0000, stopKeyCode);
            Boolean resetRegistered = RegisterHotKey(this.Handle, resetHotKey, 0x0000, resetKeyCode);


            if (startRegistered)
            {
                Console.WriteLine("Start successfully registered");
            }
            if (stopRegistered)
            {
                Console.WriteLine("Stop successfully registered");
            }
            if (resetRegistered)
            {
                Console.WriteLine("Reset successfully registered");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();

                switch (id)
                {
                    case 1:
                        MessageBox.Show("F9 pressed!");
                        break;
                    case 2:
                        MessageBox.Show("F10 pressed!");
                        break;
                    case 3:
                        MessageBox.Show("F11 pressed!");
                        break;
                }
            }

            base.WndProc(ref m);
        }
    }
}
