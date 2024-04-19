using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventWithArgs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrCalculator1_OnCalculatorComplete( object sender, ctrCalculator.CalculatorEventArgs e )
        {
            MessageBox.Show( $"The result is: {e.Result} number1 is: {e.Number1}, number2 is: {e.Number2}" );
        }
    }
}
