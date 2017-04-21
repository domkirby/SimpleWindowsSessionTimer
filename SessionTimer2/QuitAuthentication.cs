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

namespace SessionTimer2
{
    public partial class QuitAuthentication : Form
    {
        string rightPassword = ReadPassword();
        public QuitAuthentication()
        {
            InitializeComponent();
         }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            string password = adminPass.Text;
            if(password == rightPassword)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Invalid Password");
                this.Close();
            }
        }
    static string ReadPassword()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings["quitpassword"];
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("ERROR: Settings file is broken", "Broked");
                return "0";
            }
        }
        /// <summary>
        /// Enable enter button in password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adminPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == (char)ConsoleKey.Enter )
            {
                quitButton_Click(null, null);
            }
        }
    }
}
