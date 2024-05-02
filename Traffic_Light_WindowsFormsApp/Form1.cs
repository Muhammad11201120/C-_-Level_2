using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Light_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userControl11_RedLightOn( object sender, UserControl1.TrafficLightEventArgs e )
        {
            // MessageBox.Show( e.CurrentColor.ToString() );
        }

        private void userControl11_GreenLightOn( object sender, UserControl1.TrafficLightEventArgs e )
        {
            // MessageBox.Show( e.CurrentColor.ToString() );
        }

        private void userControl11_YellowLightOn( object sender, UserControl1.TrafficLightEventArgs e )
        {
            //MessageBox.Show( e.CurrentColor.ToString() );
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            userControl11.Start();
        }
    }
}
