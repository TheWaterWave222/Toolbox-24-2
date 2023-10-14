using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;

namespace Toolbox_24_UI.Scripts.Windows_Activator
{
    public partial class WinActUI : Form
    { 
        public WinActUI()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pro
            if (comboBox1.Text == "Pro")
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    Process.Start(@".\WinAct\Pro\act7.bat");
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    Process.Start(@".\WinAct\Pro\act8.bat");
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    Process.Start(@".\WinAct\Pro\act81.bat");
                }
                else if (comboBox2.SelectedIndex == 3 || comboBox2.SelectedIndex == 4)
                {
                    Process.Start(@".\WinAct\Pro\act1011.bat");
                }
            }

            // Enterprise
            if (comboBox1.Text == "Enterprise")
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    Process.Start(@".\WinAct\Enterprise\act7.bat");
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    Process.Start(@".\WinAct\Enterprise\act8.bat");
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    Process.Start(@".\WinAct\Enterprise\act81.bat");
                }
                else if (comboBox2.SelectedIndex == 3 || comboBox2.SelectedIndex == 4)
                {
                    Process.Start(@".\WinAct\Enterprise\act1011.bat");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
