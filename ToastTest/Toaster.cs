using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace ToastTest
{
    class Toaster
    {
        static SerialPort comPort = new SerialPort();

        private float mTempSetPoint = 0;
        private float mLastActualTemp = 0;
        private int mSamplingFrequency = 500;

        // Hardware control methods 
        public void SetTemperature(float degrees) { mTempSetPoint = degrees; }

        // PID setting methods
        public void SetKp(int Kp) { SerialWrite("P " + Kp.ToString()); }
        public void SetKi(int Ki) { SerialWrite("I " + Ki.ToString()); }
        public void SetKd(int Kd) { SerialWrite("D " + Kd.ToString()); }

        // Status checking methods
        public float GetSetTemperature() { return mTempSetPoint; }
        public float GetActualTemperature() { return mLastActualTemp; }
        public bool IsConnected() { return comPort.IsOpen;  }
        public void SetSamplingRate(int intervalMs) { mSamplingFrequency = intervalMs; }

        public void Initialize(string comPortName)
        {
            comPort = new SerialPort(comPortName, 9600, Parity.None, 8, StopBits.One);
            comPort.ReadTimeout = 500;
            comPort.WriteTimeout = 500;
            comPort.Open();

            Thread readThread = new Thread(Read);
            readThread.Start();

            /*
            readThread.Join();
            comPort.Close();
            */
        }

        public void Disconnect()
        {
            if(comPort.IsOpen)
            {
                comPort.Close();
            }
        }

        public void Read()
        {
            while (comPort.IsOpen)
            {
                try
                {
                    SerialWrite("RANDOM");
                    string message = comPort.ReadLine();
                    Console.WriteLine(message);
                    mLastActualTemp = Int32.Parse(message);
                    Thread.Sleep(mSamplingFrequency);
                }
                catch (Exception) { Console.WriteLine("Timeout!");  return; }
            }
        }

        // Display Port values and prompt user to enter a port.
        public static string SetPortName(string defaultPortName)
        {
            string portName;

            Console.WriteLine("Available Ports:");
            foreach (string s in SerialPort.GetPortNames())
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Enter COM port value (Default: {0}): ", defaultPortName);
            portName = Console.ReadLine();

            if (portName == "" || !(portName.ToLower()).StartsWith("com"))
            {
                portName = defaultPortName;
            }
            return portName;
        }
        // Display BaudRate values and prompt user to enter a value.
        public static int SetPortBaudRate(int defaultPortBaudRate)
        {
            string baudRate;

            Console.Write("Baud Rate(default:{0}): ", defaultPortBaudRate);
            baudRate = Console.ReadLine();

            if (baudRate == "")
            {
                baudRate = defaultPortBaudRate.ToString();
            }

            return int.Parse(baudRate);
        }

        // Display PortParity values and prompt user to enter a value.
        public static Parity SetPortParity(Parity defaultPortParity)
        {
            string parity;

            Console.WriteLine("Available Parity options:");
            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Enter Parity value (Default: {0}):", defaultPortParity.ToString(), true);
            parity = Console.ReadLine();

            if (parity == "")
            {
                parity = defaultPortParity.ToString();
            }

            return (Parity)Enum.Parse(typeof(Parity), parity, true);
        }
        // Display DataBits values and prompt user to enter a value.
        public static int SetPortDataBits(int defaultPortDataBits)
        {
            string dataBits;

            Console.Write("Enter DataBits value (Default: {0}): ", defaultPortDataBits);
            dataBits = Console.ReadLine();

            if (dataBits == "")
            {
                dataBits = defaultPortDataBits.ToString();
            }

            return int.Parse(dataBits.ToUpperInvariant());
        }

        // Display StopBits values and prompt user to enter a value.
        public static StopBits SetPortStopBits(StopBits defaultPortStopBits)
        {
            string stopBits;

            Console.WriteLine("Available StopBits options:");
            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Enter StopBits value (None is not supported and \n" +
             "raises an ArgumentOutOfRangeException. \n (Default: {0}):", defaultPortStopBits.ToString());
            stopBits = Console.ReadLine();

            if (stopBits == "")
            {
                stopBits = defaultPortStopBits.ToString();
            }

            return (StopBits)Enum.Parse(typeof(StopBits), stopBits, true);
        }
        public static Handshake SetPortHandshake(Handshake defaultPortHandshake)
        {
            string handshake;

            Console.WriteLine("Available Handshake options:");
            foreach (string s in Enum.GetNames(typeof(Handshake)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Enter Handshake value (Default: {0}):", defaultPortHandshake.ToString());
            handshake = Console.ReadLine();

            if (handshake == "")
            {
                handshake = defaultPortHandshake.ToString();
            }

            return (Handshake)Enum.Parse(typeof(Handshake), handshake, true);
        }

        public void SerialWrite(String data)
        {
            comPort.WriteLine(data);
            Thread.Sleep(50);
        }
    }
}
