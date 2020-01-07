using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            SetColorScheme();
            Microsoft.Win32.SystemEvents.UserPreferenceChanged
            += new Microsoft.Win32.UserPreferenceChangedEventHandler(
            this.UserPreferenceChanged);
        }

        private void customerLabel_Load(object sender, EventArgs e)
        {

        }

        private void SetColorScheme()
        {
            if (SystemInformation.HighContrast)
            {
                companyLabel.BackColor = SystemColors.Window;
                companyLabel.ForeColor = SystemColors.WindowText;
            }
            else
            {
                companyLabel.BackColor = Color.Blue;
                companyLabel.ForeColor = Color.Yellow;
            }
        }

        public void UserPreferenceChanged(object sender,Microsoft.Win32.UserPreferenceChangedEventArgs e)
        {
            SetColorScheme();
        }
    }
}
