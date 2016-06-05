using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO.Ports;

namespace ToastTest
{
    public partial class Form1 : Form
    {
        static System.Windows.Forms.Timer updateGuiTimer = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer countdownTimer = new System.Windows.Forms.Timer();
        Toaster toaster = new Toaster();

        const String OVEN_TEMP_SERIES = "Oven Temp";
        const String SETPOINT_TEMP_SERIES = "Set Point";

        int mTimerSecondsLeft = 0;

        private void UpdateGUI(Object myObject, EventArgs myEventArgs)
        {
            if (toaster.IsConnected())
            {
                setTempDisplay.Text = toaster.GetSetTemperature().ToString();
                actualTempDisplay.Text = toaster.GetActualTemperature().ToString();
                chart1.Series[SETPOINT_TEMP_SERIES].Points.AddY(toaster.GetSetTemperature());
                chart1.Series[OVEN_TEMP_SERIES].Points.AddY(toaster.GetActualTemperature());
            }
        }

        private void UpdateCountdownTimer(Object myObject, EventArgs myEventArgs)
        {
            if (mTimerSecondsLeft <= 0)
            {
                countdownTimer.Stop();
            }
            else
            {
                mTimerSecondsLeft -= 1;
                timerButton.Text = Math.Floor((double)(mTimerSecondsLeft / 60)).ToString().PadLeft(2, '0') + ":" +
                (mTimerSecondsLeft % 60).ToString().PadLeft(2, '0');
            }
        }

        public Form1()
        {
            InitializeComponent();
            InitializeCOMPortList();
            InitializeChart();

            updateGuiTimer.Tick += new EventHandler(UpdateGUI);
            updateGuiTimer.Interval = 500;
            updateGuiTimer.Start();

            countdownTimer.Tick += new EventHandler(UpdateCountdownTimer);
            countdownTimer.Interval = 1000;
        }

        private void InitializeChart()
        {
            chart1.Series.Clear();

            // Create oven temp
            Series set1 = new Series(OVEN_TEMP_SERIES);
            set1.BorderWidth = 2;
            set1.BorderDashStyle = ChartDashStyle.Solid;
            set1.ChartType = SeriesChartType.FastLine;
            set1.Color = Color.Purple;
            chart1.Series.Add(set1);
            chart1.Invalidate();

            // Create set point
            Series set2 = new Series(SETPOINT_TEMP_SERIES);
            set2.BorderWidth = 2;
            set2.BorderDashStyle = ChartDashStyle.Solid;
            set2.ChartType = SeriesChartType.FastLine;
            set2.Color = Color.HotPink;
            chart1.Series.Add(set2);
            chart1.Invalidate();

            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.MouseWheel += new System.Windows.Forms.MouseEventHandler(chart1_MouseWheel);

            chart1.MouseEnter += chart1_MouseEnter;
            chart1.MouseLeave += chart1_MouseLeave;
        }

        void chart1_MouseLeave(object sender, EventArgs e)
        {
            if (chart1.Focused)
                chart1.Parent.Focus();
        }

        void chart1_MouseEnter(object sender, EventArgs e)
        {
            if (!chart1.Focused)
                chart1.Focus();
        }


        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Delta < 0)
                {
                    chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                    chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset();
                }

                if (e.Delta > 0)
                {
                    double xMin = chart1.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = chart1.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                    double yMin = chart1.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                    double yMax = chart1.ChartAreas[0].AxisY.ScaleView.ViewMaximum;

                    double posXStart = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    double posXFinish = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    double posYStart = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    double posYFinish = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    chart1.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    chart1.ChartAreas[0].AxisY.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }            
        }

        private void InitializeCOMPortList()
        {
            comPortList.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                comPortList.Items.Add(s);
            }
        }

        private void ClearChart()
        {
            chart1.Series[OVEN_TEMP_SERIES].Points.Clear();
            chart1.Series[SETPOINT_TEMP_SERIES].Points.Clear();
        }

        private void setTempButton_Click(object sender, EventArgs e)
        {
            if (toaster.IsConnected())
            {
                toaster.SetTemperature((float)tempNumBox.Value);
            }
        }

        private void setPidButton_Click(object sender, EventArgs e)
        {
            if (toaster.IsConnected())
            {
                toaster.SetKp((int)kpNumBox.Value);
                toaster.SetKi((int)kiNumBox.Value);
                toaster.SetKd((int)kdNumBox.Value);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (toaster.IsConnected())
            {
                toaster.Disconnect();
                comPortList.Enabled = true;
                connectButton.Text = "Connect";
            }
            else
            {
                if (comPortList.SelectedIndex != -1)
                {
                    toaster.Initialize(comPortList.SelectedItem.ToString());
                    if (toaster.IsConnected()) { connectButton.Text = "Disconnect"; comPortList.Enabled = false; }
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (!toaster.IsConnected())
            {
                InitializeCOMPortList();
            }
        }

        private void clearPlotButton_Click(object sender, EventArgs e)
        {
            ClearChart();
        }

        private void setSamplingRateButton_Click(object sender, EventArgs e)
        {
            updateGuiTimer.Interval = (int)samplingRateNumBox.Value;
            toaster.SetSamplingRate((int)samplingRateNumBox.Value / 2);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            toaster.Disconnect();
        }

        private void timerButton_Click(object sender, EventArgs e)
        {
            if (countdownTimer.Enabled)
            {
                countdownTimer.Stop();
                timerButton.Text = "00:00";
            }
            else
            {
                promptUserStartTimer();
            }
        }

        private void promptUserStartTimer()
        {
            TimerSetupForm t = new TimerSetupForm();
            if (t.ShowDialog(this) == DialogResult.OK)
            {
                mTimerSecondsLeft = t.SecondsOnTimer;
                countdownTimer.Start();
            }
        }
    }
}
