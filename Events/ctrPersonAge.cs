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
    public partial class ctrPersonAge : UserControl
    {
        public event Action<int> OnAgeChanged;
        protected virtual void AgeChanged( int age )
        {
            Action<int> handler = OnAgeChanged;
            if ( handler != null )
            {
                handler( age ); // rase the event with the parameter
            }
        }
        public ctrPersonAge()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            AgeChanged( int.Parse( textBox1.Text ) );
        }
    }
}
