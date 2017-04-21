using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace SessionTimer2
{
    public partial class SessTimer : Form
    {
        //We need to import user32.dll and create a small function to allow us to use Windows API to logoff
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        /// <summary>
        /// Get time limit set by administrator
        /// </summary>
        int timeRemaining = ReadTimerSetting();


        /// <summary>
        /// kick off gui and timer
        /// </summary>

        public SessTimer()
        {
            InitializeComponent();
            labelDynamicTimeLeft.Text = timeRemaining+ " Minutes";
            timer1.Start();
        }
        /// <summary>
        /// timer1 is our minutes timer, it ticks every 60000 milliseconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Check if more than two minutes remain after this tick
            if((timeRemaining - 1) > 2)
            {
                timeRemaining = timeRemaining - 1;
                labelDynamicTimeLeft.Text = timeRemaining + " Minutes";
            }
            //if we're down to two minutes, we'll dump timer 1 and swtich to timer2 which ticks every 1000 milliseconds, and we'll count down by seconds on the GUI from 120
            else
            {
                timer1.Stop();
                timer1.Dispose();
                timeRemaining = 120;
                labelDynamicTimeLeft.Text = timeRemaining + " Seconds";
                timer2.Start();
                //create instance of TwoMinute warning to force a warning dialog to the top of the screen, and fire it
                TwoMinuteWarning twominutes = new TwoMinuteWarning();
                twominutes.ShowDialog();
            }
        }
        //button1 handlees the quit action
        private void button1_Click(object sender, EventArgs e)
        {
            QuitAuthentication qa = new QuitAuthentication();
            qa.ShowDialog();
        }
        /// <summary>
        /// This function will pull the setting minutes from .config
        /// </summary>
        /// <returns>int of minutes set by administrator</returns>
        static int ReadTimerSetting()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings["minutes"] ?? "0";
                int minutes = Int32.Parse(result);
                return minutes;
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("ERROR: Settings file is broken", "Fatal Error");
                return 0;
                //Application.Exit();
            }
        }
        //obsolete
        private void button2_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }
        /// <summary>
        /// seconds timer. will tick down from 120. this timer is started when timeRamining is set to 2 by timer1, and then timer1 is dumped and timer2 takes over timeRemaining
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            //if we have any time left, reduce it by one and update the GUI
            if(timeRemaining > 0)
            {
                timeRemaining = timeRemaining - 1;
                labelDynamicTimeLeft.Text = timeRemaining + " Seconds";
            }
            //If we're out of time, say that on the GUI and fire SystemLogoff();
            else
            {
                labelDynamicTimeLeft.Text = "TIME IS UP";
                SystemLogoff();
            }
        }
        /// <summary>
        /// uses Windows API to log out of Windows (forced)
        /// </summary>
        private void SystemLogoff()
        {
            ExitWindowsEx(4, 0);
        }
        //function created for onload, does not do anything at this time. Can be used to create a dialog to make it more obvious that there is a timer.
        private void SessTimer_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Added to provide an option to logoff immediately. The PAC I inplemented this in has the start menu disabled so this is the only logoff button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to log out now?", "Confirm Logoff", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                SystemLogoff();
            }            
        }
    }

}
