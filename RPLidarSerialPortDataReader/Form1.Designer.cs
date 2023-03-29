namespace RPLidarSerialPortDataReader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxSeriPortList = new System.Windows.Forms.ComboBox();
            this.buttonSeriPortCon = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labelSerialPortInfo = new System.Windows.Forms.Label();
            this.comboBoxSeriPortBaudRateList = new System.Windows.Forms.ComboBox();
            this.comboBoxSeriPortParityList = new System.Windows.Forms.ComboBox();
            this.comboBoxSeriPortStopBitsList = new System.Windows.Forms.ComboBox();
            this.comboBoxSeriPortDataBitsList = new System.Windows.Forms.ComboBox();
            this.labelSeriPortName = new System.Windows.Forms.Label();
            this.labelSeriPortBaudRate = new System.Windows.Forms.Label();
            this.labelSeriPortParity = new System.Windows.Forms.Label();
            this.labelSeriPortStopBit = new System.Windows.Forms.Label();
            this.labelSeriPortDataBit = new System.Windows.Forms.Label();
            this.textBoxSeriPortDataReceive = new System.Windows.Forms.TextBox();
            this.textBoxSeriPortDataSend = new System.Windows.Forms.TextBox();
            this.buttonSeriPortDataSend = new System.Windows.Forms.Button();
            this.buttonSeriPortDataReceiveTextBoxClear = new System.Windows.Forms.Button();
            this.buttonSeralPortDtrEn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSeriPortList
            // 
            this.comboBoxSeriPortList.FormattingEnabled = true;
            this.comboBoxSeriPortList.Location = new System.Drawing.Point(160, 11);
            this.comboBoxSeriPortList.Name = "comboBoxSeriPortList";
            this.comboBoxSeriPortList.Size = new System.Drawing.Size(109, 21);
            this.comboBoxSeriPortList.TabIndex = 0;
            // 
            // buttonSeriPortCon
            // 
            this.buttonSeriPortCon.Location = new System.Drawing.Point(288, 9);
            this.buttonSeriPortCon.Name = "buttonSeriPortCon";
            this.buttonSeriPortCon.Size = new System.Drawing.Size(109, 23);
            this.buttonSeriPortCon.TabIndex = 1;
            this.buttonSeriPortCon.Text = "Serial Port Connect";
            this.buttonSeriPortCon.UseVisualStyleBackColor = true;
            this.buttonSeriPortCon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSeriPortCon_MouseClick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // labelSerialPortInfo
            // 
            this.labelSerialPortInfo.AutoSize = true;
            this.labelSerialPortInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSerialPortInfo.Location = new System.Drawing.Point(403, 12);
            this.labelSerialPortInfo.Name = "labelSerialPortInfo";
            this.labelSerialPortInfo.Size = new System.Drawing.Size(107, 20);
            this.labelSerialPortInfo.TabIndex = 3;
            this.labelSerialPortInfo.Text = "Serial Port Info:";
            // 
            // comboBoxSeriPortBaudRateList
            // 
            this.comboBoxSeriPortBaudRateList.FormattingEnabled = true;
            this.comboBoxSeriPortBaudRateList.Location = new System.Drawing.Point(160, 38);
            this.comboBoxSeriPortBaudRateList.Name = "comboBoxSeriPortBaudRateList";
            this.comboBoxSeriPortBaudRateList.Size = new System.Drawing.Size(109, 21);
            this.comboBoxSeriPortBaudRateList.TabIndex = 4;
            // 
            // comboBoxSeriPortParityList
            // 
            this.comboBoxSeriPortParityList.FormattingEnabled = true;
            this.comboBoxSeriPortParityList.Location = new System.Drawing.Point(160, 65);
            this.comboBoxSeriPortParityList.Name = "comboBoxSeriPortParityList";
            this.comboBoxSeriPortParityList.Size = new System.Drawing.Size(109, 21);
            this.comboBoxSeriPortParityList.TabIndex = 5;
            // 
            // comboBoxSeriPortStopBitsList
            // 
            this.comboBoxSeriPortStopBitsList.FormattingEnabled = true;
            this.comboBoxSeriPortStopBitsList.Location = new System.Drawing.Point(160, 92);
            this.comboBoxSeriPortStopBitsList.Name = "comboBoxSeriPortStopBitsList";
            this.comboBoxSeriPortStopBitsList.Size = new System.Drawing.Size(109, 21);
            this.comboBoxSeriPortStopBitsList.TabIndex = 6;
            // 
            // comboBoxSeriPortDataBitsList
            // 
            this.comboBoxSeriPortDataBitsList.FormattingEnabled = true;
            this.comboBoxSeriPortDataBitsList.Location = new System.Drawing.Point(160, 119);
            this.comboBoxSeriPortDataBitsList.Name = "comboBoxSeriPortDataBitsList";
            this.comboBoxSeriPortDataBitsList.Size = new System.Drawing.Size(109, 21);
            this.comboBoxSeriPortDataBitsList.TabIndex = 7;
            // 
            // labelSeriPortName
            // 
            this.labelSeriPortName.AutoSize = true;
            this.labelSeriPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSeriPortName.Location = new System.Drawing.Point(42, 12);
            this.labelSeriPortName.Name = "labelSeriPortName";
            this.labelSeriPortName.Size = new System.Drawing.Size(115, 16);
            this.labelSeriPortName.TabIndex = 8;
            this.labelSeriPortName.Text = "Serial Port Name :";
            // 
            // labelSeriPortBaudRate
            // 
            this.labelSeriPortBaudRate.AutoSize = true;
            this.labelSeriPortBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSeriPortBaudRate.Location = new System.Drawing.Point(12, 39);
            this.labelSeriPortBaudRate.Name = "labelSeriPortBaudRate";
            this.labelSeriPortBaudRate.Size = new System.Drawing.Size(145, 16);
            this.labelSeriPortBaudRate.TabIndex = 9;
            this.labelSeriPortBaudRate.Text = "Serial  Port Baud Rate :";
            // 
            // labelSeriPortParity
            // 
            this.labelSeriPortParity.AutoSize = true;
            this.labelSeriPortParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSeriPortParity.Location = new System.Drawing.Point(45, 66);
            this.labelSeriPortParity.Name = "labelSeriPortParity";
            this.labelSeriPortParity.Size = new System.Drawing.Size(112, 16);
            this.labelSeriPortParity.TabIndex = 10;
            this.labelSeriPortParity.Text = "Serial Port Parity :";
            // 
            // labelSeriPortStopBit
            // 
            this.labelSeriPortStopBit.AutoSize = true;
            this.labelSeriPortStopBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSeriPortStopBit.Location = new System.Drawing.Point(30, 93);
            this.labelSeriPortStopBit.Name = "labelSeriPortStopBit";
            this.labelSeriPortStopBit.Size = new System.Drawing.Size(124, 16);
            this.labelSeriPortStopBit.TabIndex = 11;
            this.labelSeriPortStopBit.Text = "Serial Port Stop Bit :";
            // 
            // labelSeriPortDataBit
            // 
            this.labelSeriPortDataBit.AutoSize = true;
            this.labelSeriPortDataBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSeriPortDataBit.Location = new System.Drawing.Point(29, 120);
            this.labelSeriPortDataBit.Name = "labelSeriPortDataBit";
            this.labelSeriPortDataBit.Size = new System.Drawing.Size(125, 16);
            this.labelSeriPortDataBit.TabIndex = 12;
            this.labelSeriPortDataBit.Text = "Serial Port Data Bit :";
            // 
            // textBoxSeriPortDataReceive
            // 
            this.textBoxSeriPortDataReceive.Location = new System.Drawing.Point(12, 160);
            this.textBoxSeriPortDataReceive.Multiline = true;
            this.textBoxSeriPortDataReceive.Name = "textBoxSeriPortDataReceive";
            this.textBoxSeriPortDataReceive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSeriPortDataReceive.Size = new System.Drawing.Size(576, 101);
            this.textBoxSeriPortDataReceive.TabIndex = 13;
            // 
            // textBoxSeriPortDataSend
            // 
            this.textBoxSeriPortDataSend.Location = new System.Drawing.Point(12, 267);
            this.textBoxSeriPortDataSend.Name = "textBoxSeriPortDataSend";
            this.textBoxSeriPortDataSend.Size = new System.Drawing.Size(576, 20);
            this.textBoxSeriPortDataSend.TabIndex = 14;
            // 
            // buttonSeriPortDataSend
            // 
            this.buttonSeriPortDataSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSeriPortDataSend.Location = new System.Drawing.Point(594, 227);
            this.buttonSeriPortDataSend.Name = "buttonSeriPortDataSend";
            this.buttonSeriPortDataSend.Size = new System.Drawing.Size(128, 60);
            this.buttonSeriPortDataSend.TabIndex = 15;
            this.buttonSeriPortDataSend.Text = "Data Send";
            this.buttonSeriPortDataSend.UseVisualStyleBackColor = true;
            this.buttonSeriPortDataSend.Click += new System.EventHandler(this.buttonSeriPortDataSend_Click);
            // 
            // buttonSeriPortDataReceiveTextBoxClear
            // 
            this.buttonSeriPortDataReceiveTextBoxClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSeriPortDataReceiveTextBoxClear.Location = new System.Drawing.Point(594, 160);
            this.buttonSeriPortDataReceiveTextBoxClear.Name = "buttonSeriPortDataReceiveTextBoxClear";
            this.buttonSeriPortDataReceiveTextBoxClear.Size = new System.Drawing.Size(128, 60);
            this.buttonSeriPortDataReceiveTextBoxClear.TabIndex = 16;
            this.buttonSeriPortDataReceiveTextBoxClear.Text = "Data Clear";
            this.buttonSeriPortDataReceiveTextBoxClear.UseVisualStyleBackColor = true;
            this.buttonSeriPortDataReceiveTextBoxClear.Click += new System.EventHandler(this.buttonSeriPortDataReceiveTextBoxClear_Click);
            // 
            // buttonSeralPortDtrEn
            // 
            this.buttonSeralPortDtrEn.Location = new System.Drawing.Point(288, 39);
            this.buttonSeralPortDtrEn.Name = "buttonSeralPortDtrEn";
            this.buttonSeralPortDtrEn.Size = new System.Drawing.Size(109, 23);
            this.buttonSeralPortDtrEn.TabIndex = 17;
            this.buttonSeralPortDtrEn.Text = "Serial Port DTR Ds.";
            this.buttonSeralPortDtrEn.UseVisualStyleBackColor = true;
            this.buttonSeralPortDtrEn.Click += new System.EventHandler(this.buttonSeralPortDtrEn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.buttonSeralPortDtrEn);
            this.Controls.Add(this.buttonSeriPortDataReceiveTextBoxClear);
            this.Controls.Add(this.buttonSeriPortDataSend);
            this.Controls.Add(this.textBoxSeriPortDataSend);
            this.Controls.Add(this.textBoxSeriPortDataReceive);
            this.Controls.Add(this.labelSeriPortDataBit);
            this.Controls.Add(this.labelSeriPortStopBit);
            this.Controls.Add(this.labelSeriPortParity);
            this.Controls.Add(this.labelSeriPortBaudRate);
            this.Controls.Add(this.labelSeriPortName);
            this.Controls.Add(this.comboBoxSeriPortDataBitsList);
            this.Controls.Add(this.comboBoxSeriPortStopBitsList);
            this.Controls.Add(this.comboBoxSeriPortParityList);
            this.Controls.Add(this.comboBoxSeriPortBaudRateList);
            this.Controls.Add(this.labelSerialPortInfo);
            this.Controls.Add(this.buttonSeriPortCon);
            this.Controls.Add(this.comboBoxSeriPortList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSeriPortList;
        private System.Windows.Forms.Button buttonSeriPortCon;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelSerialPortInfo;
        private System.Windows.Forms.ComboBox comboBoxSeriPortBaudRateList;
        private System.Windows.Forms.ComboBox comboBoxSeriPortParityList;
        private System.Windows.Forms.ComboBox comboBoxSeriPortStopBitsList;
        private System.Windows.Forms.ComboBox comboBoxSeriPortDataBitsList;
        private System.Windows.Forms.Label labelSeriPortName;
        private System.Windows.Forms.Label labelSeriPortBaudRate;
        private System.Windows.Forms.Label labelSeriPortParity;
        private System.Windows.Forms.Label labelSeriPortStopBit;
        private System.Windows.Forms.Label labelSeriPortDataBit;
        private System.Windows.Forms.TextBox textBoxSeriPortDataReceive;
        private System.Windows.Forms.TextBox textBoxSeriPortDataSend;
        private System.Windows.Forms.Button buttonSeriPortDataSend;
        private System.Windows.Forms.Button buttonSeriPortDataReceiveTextBoxClear;
        private System.Windows.Forms.Button buttonSeralPortDtrEn;
    }
}

