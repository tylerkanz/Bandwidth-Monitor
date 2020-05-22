using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Bandwidth_Monitor
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        public Form1()
        {
            InitializeComponent();
        }

        long preBytesSend = 0;
        long preBytesRec = 0;

        long DSpeed, USpeed;

        IPv4InterfaceStatistics iFace;


        private void timer1_Tick(object sender, EventArgs e)
        {
            iFace = NetworkInterface.GetAllNetworkInterfaces()[0].GetIPv4Statistics();

            USpeed = (iFace.BytesSent - preBytesSend) / 1024;
            DSpeed = (iFace.BytesReceived - preBytesRec) / 1024;

            preBytesSend = NetworkInterface.GetAllNetworkInterfaces()[0].GetIPv4Statistics().BytesSent;
            preBytesRec = NetworkInterface.GetAllNetworkInterfaces()[0].GetIPv4Statistics().BytesReceived;

            lbl_down.Text = "Download: " + Math.Round((double)DSpeed, 2) + "KB/s";
            lbl_up.Text = "Upload: " + Math.Round((double)USpeed, 2) + "KB/s";
        }

    }
}
