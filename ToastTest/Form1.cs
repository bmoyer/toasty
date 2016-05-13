﻿using System;
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
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        Toaster toaster = new Toaster();
        

        private void UpdateGUI(Object myObject, EventArgs myEventArgs)
        {
            //chart1.Series["Oven Temp"].Points.AddY(DateTime.Now.Ticks % 20);
            if (toaster.IsConnected())
            {
                chart1.Series["Set Point"].Points.AddY(toaster.GetSetTemperature());
                chart1.Series["Oven Temp"].Points.AddY(toaster.GetActualTemperature());
            }
        }

        public Form1()
        {
            InitializeComponent();
            InitializeCOMPortList();
            InitializeChart();

            myTimer.Tick += new EventHandler(UpdateGUI);
            myTimer.Interval = 500;
            myTimer.Start();
        }

        private void InitializeChart()
        {
            chart1.Series.Clear();

            // Create oven temp
            Series set1 = new Series("Oven Temp");
            set1.BorderWidth = 2;
            set1.BorderDashStyle = ChartDashStyle.Solid;
            set1.ChartType = SeriesChartType.FastLine;
            set1.Color = Color.Purple;
            chart1.Series.Add(set1);
            chart1.Invalidate();

            // Create set point
            Series set2 = new Series("Set Point");
            set2.BorderWidth = 2;
            set2.BorderDashStyle = ChartDashStyle.Solid;
            set2.ChartType = SeriesChartType.FastLine;
            set2.Color = Color.HotPink;
            chart1.Series.Add(set2);
            chart1.Invalidate();
        }

        private void InitializeCOMPortList()
        {
            comPortList.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                comPortList.Items.Add(s);
            }
        }

        private void setTempButton_Click(object sender, EventArgs e)
        {
            toaster.SetTemperature((float)tempNumBox.Value);
            Console.WriteLine("Set Temp: " + toaster.GetSetTemperature());
            foreach (string s in SerialPort.GetPortNames())
            {
                Console.WriteLine(s);
            }
        }

        private void setPidButton_Click(object sender, EventArgs e)
        {
            if(toaster.IsConnected())
            {
                toaster.SetKp((int)kpNumBox.Value);
                toaster.SetKi((int)kiNumBox.Value);
                toaster.SetKd((int)kdNumBox.Value);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if(toaster.IsConnected())
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
            if(!toaster.IsConnected())
            {
                InitializeCOMPortList();
            }
        }

    }
}
