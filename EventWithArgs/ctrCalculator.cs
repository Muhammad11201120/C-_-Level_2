using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventWithArgs
{


    public partial class ctrCalculator : UserControl
    {
        public class CalculatorEventArgs : EventArgs
        {
            public int Number1 { get; }
            public int Number2 { get; }
            public int Result { get; }
            public CalculatorEventArgs( int number1, int number2, int result )
            {
                Number1 = number1;
                Number2 = number2;
                Result = result;
            }
        }
        public event EventHandler<CalculatorEventArgs> OnCalculatorComplete;
        protected virtual void CalculatorComplete( int number1, int number2, int result )
        {
            OnCalculatorComplete?.Invoke( this, new CalculatorEventArgs( number1, number2, result ) );
        }
        public ctrCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            txtResult.Text = ( int.Parse( txtNumberOne.Text ) + int.Parse( txtNumberTwo.Text ) ).ToString();
            CalculatorComplete( int.Parse( txtNumberOne.Text ), int.Parse( txtNumberTwo.Text ), int.Parse( txtResult.Text ) );
        }
    }
}
