using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Controls_WindowsFormsApp
{
    public partial class CustomControl1 : TextBox
    {
        public CustomControl1()
        {
            InitializeComponent();
        }

        protected override void OnPaint( PaintEventArgs pe )
        {
            base.OnPaint( pe );
        }
        public bool IsRequired { get; set; }
        public enum InputTypeEnum
        {
            TextInput,
            NumericInput,
        }
        public InputTypeEnum MyProperty { get; set; } = InputTypeEnum.TextInput;
        private bool IsNumeric()
        {
            string str = this.Text.Trim();
            foreach ( char ch in str )
            {
                if ( !char.IsDigit( ch ) && ch != '.' )
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsValid()
        {
            if ( IsRequired && string.IsNullOrEmpty( this.Text.Trim() ) )
            {
                return false;
            }
            if ( MyProperty == InputTypeEnum.NumericInput && !IsNumeric() )
            {
                return false;
            }
            return true;
        }
    }
}
