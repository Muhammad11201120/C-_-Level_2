using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    public partial class Form2 : Form
    {
        public delegate void myDelegate( int result );
        public myDelegate myDelegateInstance;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            myDelegateInstance.Invoke( int.Parse( textBox1.Text ) );
            this.Close();
        }
    }
}
