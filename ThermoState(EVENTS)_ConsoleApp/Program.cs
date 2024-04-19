using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermoState_EVENTS__ConsoleApp
{
    public class TemperatureChangedEventArgs : EventArgs
    {
        public double NewTemp { get; }
        public double OldTemp { get; }
        public double Deference { get; }
        public TemperatureChangedEventArgs( double currentTemp, double oldTemp )
        {
            NewTemp = currentTemp;
            OldTemp = oldTemp;
            Deference = currentTemp - oldTemp;
        }
    }
    public class ThermoState
    {

        private double _CurrentTemp;
        private double _OldTemp;
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;
        public void SetTemp( double newTemp )
        {
            if ( newTemp != _CurrentTemp )
            {
                _OldTemp = _CurrentTemp;
                _CurrentTemp = newTemp;
                OnTemperatureChanged( new TemperatureChangedEventArgs( _CurrentTemp, _OldTemp ) );
            }
        }
        protected virtual void OnTemperatureChanged( TemperatureChangedEventArgs e )
        {
            TemperatureChanged?.Invoke( this, e );
        }

    }

    public class Display
    {
        public void Subscribe( ThermoState thermo )
        {
            thermo.TemperatureChanged += HandleTemperatureChanged;
        }
        public void HandleTemperatureChanged( object sender, TemperatureChangedEventArgs e )
        {
            Console.WriteLine( $"Temperature changed from {e.OldTemp} to {e.NewTemp}." );
            Console.WriteLine( $"Deference is {e.Deference}" );
        }
        internal class Program
        {
            static void Main()
            {
                ThermoState thermo = new ThermoState();
                Display display = new Display();
                display.Subscribe( thermo );
                thermo.SetTemp( 20 );
                thermo.SetTemp( 25 );
                thermo.SetTemp( 30 );
                Console.ReadLine();
            }

        }
    }
}