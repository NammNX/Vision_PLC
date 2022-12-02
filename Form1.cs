using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using HslCommunication.Profinet.Melsec;
using HslCommunication;

namespace DM280
{
    public partial class Form1 : Form
    {
        MelsecFxSerial melsecFx = new MelsecFxSerial();

        #region Khai bao bien

        string MasterCode = "";
        string indata = "";

        #endregion


        #region ham cua giao dien luc minh click
        public Form1() // Ham chi chay 1 lan dau
        {
            InitializeComponent();
            InitComport();
            PLC();
            
            CheckForIllegalCrossThreadCalls = false; 
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DisConnect();
        }

        private void btnTrigger_Click(object sender, EventArgs e)
        {
            Trigger();
            

        }

        #endregion



        void Connect()

        {
            if (!serialPort1.IsOpen)
                serialPort1.Open();
            Console.WriteLine(serialPort1.IsOpen);
        }
        void DisConnect()

        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
            Console.WriteLine(serialPort1.IsOpen);
        }
        void Trigger()

        {
            serialPort1.WriteLine("+");
            Thread.Sleep(1000);
            serialPort1.WriteLine("-");
        }
        void InitComport()
        {
            serialPort1.DataReceived += SerialPort1_DataReceived;
            
        }

        // hàm trả dữ liệu về
        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) 
        {
            SerialPort sp = (SerialPort)sender;
            indata = sp.ReadExisting();
            Console.WriteLine("Data Received:" + indata);
             

            txtData.Text = indata;

            Compare();
            

            
        }


        private void txtMasterCode_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnMasterCode_Click(object sender, EventArgs e)
        {
            MasterCode = txtMasterCode.Text;

            if (checkBoxCRLF.Checked)
                MasterCode += "\r\n"; // MasterCode = MasterCode + "\r\n";

           
        }
        void Compare()
        {
            if(indata==MasterCode)
            {
                Console.WriteLine("OK");
                lbOKNG.Text = "OK";
                ActivePLC(true);
                Thread.Sleep(1000);
                ActivePLC(false);

            }
            else
            {
                ActivePLC(false);
                Console.WriteLine("NG");
                lbOKNG.Text = "NG";
               
            }

        }
        void PLC()
        {
            melsecFx.SerialPortInni(sp =>
            {
                sp.PortName = "COM4";
                sp.BaudRate = 38400;
                sp.DataBits = 7;
                sp.StopBits = System.IO.Ports.StopBits.One;
                sp.Parity = System.IO.Ports.Parity.Even;
            });
        }

        private void btnConnectPLC_Click(object sender, EventArgs e)
        {
            melsecFx.Open();
            bool b = melsecFx.IsOpen();
            Console.WriteLine($"isopen = {b}");
            if (b == true)
            {
                lbStatus.Text = "PLC Connected";
            }
            else 
            { 
                lbStatus.Text = "PLC Connect Fail"; 
            }


        }

        private void btnDisConnectPLC_Click(object sender, EventArgs e)
        {
            melsecFx.Close();
            lbStatus.Text = "PLC Disconnect";
            bool b = melsecFx.IsOpen();
            Console.WriteLine($"isopen = {b}");
        }
        void ActivePLC(bool b)
        {
            melsecFx.Write("M10", b);
           
        }
    }
}
