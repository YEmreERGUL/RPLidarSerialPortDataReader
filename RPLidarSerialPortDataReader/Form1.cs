using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPLidarSerialPortDataReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Seri Port İsimleri combobox icerisine eklendi.()
            string[] serialPortListArray = SerialPort.GetPortNames();
            foreach (string serialPort in serialPortListArray)
            {
                comboBoxSeriPortList.Items.Add(serialPort);
            }

            int serialPortCounts = comboBoxSeriPortList.Items.Count;
            if(serialPortCounts > 0) comboBoxSeriPortList.SelectedIndex = 0;

            //Seri Port Baud Rate degerleri combobox icerisine eklendi.
            uint[] baudRates = {9600, 14400, 19200, 38400, 57600, 115200};
            foreach (uint baudRate in baudRates)
            {
                comboBoxSeriPortBaudRateList.Items.Add(baudRate);
            }

            comboBoxSeriPortBaudRateList.SelectedIndex = 5;

            //Seri Port Paritys combobox icerisine eklendi.
            string[] paritys = {"None", "Odd", "Even", "Mark", "Space"};
            foreach(string parity in paritys)
            {
                comboBoxSeriPortParityList.Items.Add(parity);
            }

            comboBoxSeriPortParityList.SelectedIndex = 0;

            //Seri Port Stop bits combobox icerisine eklendi.
            string[] stopBits = {"None", "One", "Two", "OnePointFive"};
            foreach(string stopBit in stopBits)
            {
                comboBoxSeriPortStopBitsList.Items.Add(stopBit);
            }

            comboBoxSeriPortStopBitsList.SelectedIndex = 1;

            //Seri Port Data Bits combobox icerisine eklendi.
            int[] dataBits = {5, 6, 7, 8};
            foreach(int dataBit in dataBits)
            {
                comboBoxSeriPortDataBitsList.Items.Add(dataBit);
            }

            comboBoxSeriPortDataBitsList.SelectedIndex = 3;
        }

        private void buttonSeriPortCon_MouseClick(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                //Combo box disable hale getiriliyor.
                comboBoxSeriPortList.Enabled = true;
                comboBoxSeriPortBaudRateList.Enabled = true;
                comboBoxSeriPortParityList.Enabled = true;
                comboBoxSeriPortStopBitsList.Enabled = true;
                comboBoxSeriPortDataBitsList.Enabled = true;

                try
                {
                    serialPort1.Close();
                    buttonSeriPortCon.Text = "Serial Port Connect";

                    labelSerialPortInfo.Text = "Serial Port Info:";

                    buttonSeriPortDataReceiveTextBoxClear.Text = "Data Clear";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Serial Port Not Closed.\n{ex.Message}","Error",MessageBoxButtons.OK);
                }
            }
            else
            {
                //Combo box disable hale getiriliyor.
                comboBoxSeriPortList.Enabled = false;
                comboBoxSeriPortBaudRateList.Enabled = false;
                comboBoxSeriPortParityList.Enabled = false;
                comboBoxSeriPortStopBitsList.Enabled = false;
                comboBoxSeriPortDataBitsList.Enabled = false;

                //Serial Port Parameters setting.
                serialPort1.PortName = comboBoxSeriPortList.Text;
                serialPort1.BaudRate = (int)Int32.Parse(comboBoxSeriPortBaudRateList.Text);

                switch (comboBoxSeriPortParityList.Text)
                {
                    case "None":
                        serialPort1.Parity = System.IO.Ports.Parity.None;
                        break;

                    case "Odd":
                        serialPort1.Parity = System.IO.Ports.Parity.Odd;
                        break;

                    case "Even":
                        serialPort1.Parity = System.IO.Ports.Parity.Even;
                        break;

                    case "Mark":
                        serialPort1.Parity = System.IO.Ports.Parity.Mark;
                        break;

                    case "Space":
                        serialPort1.Parity = System.IO.Ports.Parity.Space;
                        break;

                    default:
                        break;
                }

                switch (comboBoxSeriPortStopBitsList.Text)
                {
                    case "None":
                        serialPort1.StopBits = System.IO.Ports.StopBits.None;
                        break;

                    case "One":
                        serialPort1.StopBits = System.IO.Ports.StopBits.One;
                        break;

                    case "Two":
                        serialPort1.StopBits = System.IO.Ports.StopBits.Two;
                        break;

                    case "OnePointFive":
                        serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;
                        break;

                    default:
                        break;
                }

                serialPort1.DataBits = (int)Int32.Parse(comboBoxSeriPortDataBitsList.Text);

                //Open serial port
                try
                {
                    serialPort1.Open();
                    buttonSeriPortCon.Text = "Serial Port Discon.";

                    string[] serialPortİnfo = new string[5];
                    serialPortİnfo[0] = serialPort1.PortName;
                    serialPortİnfo[1] = serialPort1.BaudRate.ToString();
                    serialPortİnfo[2] = serialPort1.Parity.ToString();
                    serialPortİnfo[3] = serialPort1.StopBits.ToString();
                    serialPortİnfo[4] = serialPort1.DataBits.ToString();

                    labelSerialPortInfo.Text = "Serial Port Info:";

                    foreach (var info in serialPortİnfo)
                    {
                        labelSerialPortInfo.Text += "  " + info;
                    }

                    buttonSeriPortDataReceiveTextBoxClear.Text = "Stop";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Serial Port Not Opened.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Tread cakısması hatasının giderilmesi icin kullanılmıstır.
        public delegate void showSerialPortData (int data);
        public void writeToTextBox(int data)
        {
            textBoxSeriPortDataReceive.Text += " " + data.ToString("X");
        }
        
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int serialPortReceivedData = serialPort1.ReadByte();
            textBoxSeriPortDataReceive.Invoke(new showSerialPortData(writeToTextBox), serialPortReceivedData);

            /*
            string serialPortReceivedData = serialPort1.ReadLine();
            textBoxSeriPortDataReceive.Invoke(new showSerialPortData(writeToTextBox), serialPortReceivedData);
            */
        }

        private void buttonSeriPortDataReceiveTextBoxClear_Click(object sender, EventArgs e)
        {
            if(buttonSeriPortDataReceiveTextBoxClear.Text == "Stop")
            {
                byte[] stoptArray = new byte[2] { 0xA5, 0x25 };
                serialPort1.Write(stoptArray, 0, 2);
            }

            if(buttonSeriPortDataReceiveTextBoxClear.Text == "Data Clear") textBoxSeriPortDataReceive.Clear();
        }

        private void buttonSeralPortDtrEn_Click(object sender, EventArgs e)
        {
            bool seriPortDtrPin = serialPort1.DtrEnable;

            if (seriPortDtrPin == true)
            {
                serialPort1.DtrEnable = false;
                buttonSeralPortDtrEn.Text = "Serial Port DTR Ds.";
            }
            else
            {
                serialPort1.DtrEnable = true;
                buttonSeralPortDtrEn.Text = "Serial Port DTR En.";
            }
        }

        private void buttonSeriPortDataSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                /*
                //"0x" veya "0X" ile başlayan bir string ise hex formatında gönderim yapılacaktır.
                char[] textSendDataArray = textBoxSeriPortDataSend.Text.ToCharArray();
                if (textSendDataArray[0] == '0' && (textSendDataArray[1] == 'x' || textSendDataArray[1] == 'x'))
                {
                    byte[] hexDataArray = new byte[(textSendDataArray.Length - 2)/2];
                    int hexDataCounter = 0;
                    string tempData;
                    
                    for(int i = 2; i<(textSendDataArray.Length) - 1; i+=2)
                    {
                        tempData = "0x" + textSendDataArray[i] + textSendDataArray[i + 1];//indexlemedekata var 'i+3' -> 'i+4' olabilir.BAK!!!
                        hexDataArray[hexDataCounter++] = Convert.ToByte(tempData, 16); //İndekleme fazladan yapılıyor onada BAK!!!
                    }

                    tempData = System.Text.Encoding.ASCII.GetString(hexDataArray);
                    tempData = System.Text.ASCIIEncoding.ASCII.GetString(hexDataArray);
                    serialPort1.Write(tempData);
                    int a = 0;
                }
                else
                {
                    serialPort1.Write(textBoxSeriPortDataSend.Text);
                }
                
                textBoxSeriPortDataSend.Clear();
                */

                serialPort1.Write(new byte[] { 0xA5, 0x20 }, 0, 2);
            }
        }
    }
}
