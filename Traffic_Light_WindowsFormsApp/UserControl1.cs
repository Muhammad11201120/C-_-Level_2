using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traffic_Light_WindowsFormsApp.Properties;

namespace Traffic_Light_WindowsFormsApp
{
    public partial class UserControl1 : UserControl
    {
        public enum TrafficLightColor
        {
            Red,
            Yellow,
            Green
        }
        private TrafficLightColor _CurrentColor = TrafficLightColor.Red;
        public TrafficLightColor CurrentColor
        {
            get
            {
                return _CurrentColor;
            }
            set
            {
                _CurrentColor = value;
                switch ( _CurrentColor )
                {
                    case TrafficLightColor.Red:
                        pictureBox1.Image = Resources.Red;
                        panel1.BackColor = Color.Red;
                        lblCounter.BackColor = Color.Red;
                        break;
                    case TrafficLightColor.Yellow:
                        pictureBox1.Image = Resources.Orange;
                        panel1.BackColor = Color.Orange;
                        lblCounter.BackColor = Color.Orange;
                        break;
                    case TrafficLightColor.Green:
                        pictureBox1.Image = Resources.Green;
                        panel1.BackColor = Color.Green;
                        lblCounter.BackColor = Color.Green;
                        break;
                    default:
                        pictureBox1.Image = Resources.Red;
                        panel1.BackColor = Color.Red;
                        lblCounter.BackColor = Color.Red;
                        break;
                }
            }
        }

        private int _RedTime = 10;
        private int _GreenTime = 10;
        private int _OrangeTime = 3;

        public int RedTime
        {
            get
            {
                return _RedTime;
            }
            set
            {
                _RedTime = value;

            }
        }
        public int OrangeTime
        {
            get
            {
                return _OrangeTime;
            }
            set
            {
                _OrangeTime = value;
            }
        }
        public int GreenTime
        {
            get
            {
                return _GreenTime;
            }
            set
            {
                _GreenTime = value;
            }
        }

        private int _CurrentCountDownValue;

        public int GetCurentTime()
        {
            switch ( _CurrentColor )
            {
                case TrafficLightColor.Red:
                    return RedTime;
                case TrafficLightColor.Yellow:
                    return OrangeTime;
                case TrafficLightColor.Green:
                    return GreenTime;
                default:
                    return RedTime;
            }
        }
        public void Start()
        {
            _CurrentCountDownValue = GetCurentTime();
            timer1.Start();
        }
        public class TrafficLightEventArgs : EventArgs
        {
            public TrafficLightColor CurrentColor { get; }
            public int LightDuration { get; }
            public TrafficLightEventArgs( TrafficLightColor currentColor, int lightDuration )
            {
                CurrentColor = currentColor;
                LightDuration = lightDuration;
            }
        }
        // Events
        public event EventHandler<TrafficLightEventArgs> RedLightOn;
        protected virtual void OnRedLightOn( TrafficLightEventArgs e )
        {
            RedLightOn?.Invoke( this, e );
        }
        public event EventHandler<TrafficLightEventArgs> YellowLightOn;
        protected virtual void OnYellowLightOn( TrafficLightEventArgs e )
        {
            YellowLightOn?.Invoke( this, e );
        }
        public event EventHandler<TrafficLightEventArgs> GreenLightOn;
        protected virtual void OnGreenLightOn( TrafficLightEventArgs e )
        {
            GreenLightOn?.Invoke( this, e );
        }
        public event EventHandler<TrafficLightEventArgs> RedLightOff;
        protected virtual void OnRedLightOff( TrafficLightEventArgs e )
        {
            RedLightOff?.Invoke( this, e );
        }
        public event EventHandler<TrafficLightEventArgs> YellowLightOff;
        protected virtual void OnYellowLightOff( TrafficLightEventArgs e )
        {
            YellowLightOff?.Invoke( this, e );
        }
        public event EventHandler<TrafficLightEventArgs> GreenLightOff;
        protected virtual void OnGreenLightOff( TrafficLightEventArgs e )
        {
            GreenLightOff?.Invoke( this, e );
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void timer1_Tick( object sender, EventArgs e )
        {
            lblCounter.Text = _CurrentCountDownValue.ToString();
            if ( _CurrentCountDownValue == 0 )
            {
                _ChangeLight();
            }
            else
            {
                --_CurrentCountDownValue;
            }
        }
        private TrafficLightColor _LightAfterOrangeGreenOrRed;
        private void _ChangeLight()
        {
            switch ( _CurrentColor )
            {
                case TrafficLightColor.Red:
                    _LightAfterOrangeGreenOrRed = TrafficLightColor.Green;
                    CurrentColor = TrafficLightColor.Yellow;
                    _CurrentCountDownValue = OrangeTime;
                    lblCounter.Text = _CurrentCountDownValue.ToString();
                    OnYellowLightOn( new TrafficLightEventArgs( TrafficLightColor.Yellow, _OrangeTime ) );

                    break;

                case TrafficLightColor.Yellow:
                    if ( _LightAfterOrangeGreenOrRed == TrafficLightColor.Green )
                    {
                        CurrentColor = TrafficLightColor.Green;
                        _CurrentCountDownValue = GreenTime;
                        lblCounter.Text = _CurrentCountDownValue.ToString();
                        OnGreenLightOn( new TrafficLightEventArgs( TrafficLightColor.Green, _GreenTime ) );
                    }
                    else
                    {
                        CurrentColor = TrafficLightColor.Red;
                        _CurrentCountDownValue = RedTime;
                        lblCounter.Text = _CurrentCountDownValue.ToString();
                        OnRedLightOn( new TrafficLightEventArgs( TrafficLightColor.Red, _RedTime ) );
                    }

                    break;

                case TrafficLightColor.Green:
                    _LightAfterOrangeGreenOrRed = TrafficLightColor.Red;

                    CurrentColor = TrafficLightColor.Yellow;
                    _CurrentCountDownValue = OrangeTime;
                    lblCounter.Text = _CurrentCountDownValue.ToString();
                    OnRedLightOn( new TrafficLightEventArgs( TrafficLightColor.Red, RedTime ) );

                    break;

                default:
                    pictureBox1.Image = Resources.Red;
                    break;
            }
        }
    }
}
