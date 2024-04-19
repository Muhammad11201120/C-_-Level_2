using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrPersonAge1_OnAgeChanged( int obj )
        {
            int Age = obj;
            if ( Age >= 18 )
            {
                MessageBox.Show( "Accepted Age" );
            }
            else
            {
                MessageBox.Show( "Not Accepted Age" );
            }
        }
    }
}
