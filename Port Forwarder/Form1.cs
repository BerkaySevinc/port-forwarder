using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mono.Nat;


namespace Port_Forwarder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }





        int Port;
        private void btnForward_Click(object sender, EventArgs e)
        {
            string PortText = txtPort.Text.Trim();

            if (!Int32.TryParse(PortText, out _)) return;

            Port = Convert.ToInt32(PortText);

            NatUtility.DeviceFound += ForwardPort;

            NatUtility.StartDiscovery();
        }

        private void ForwardPort(object sender, DeviceEventArgs args)
        {
            INatDevice device = args.Device;

            device.CreatePortMap(new Mapping(Protocol.Tcp, Port, Port));

            MessageBox.Show(Port + ". Port Forwarded To This Local Device!");

            NatUtility.DeviceFound -= ForwardPort;
        }



        private void btnDeleteForward_Click(object sender, EventArgs e)
        {
            string PortText = txtPort2.Text.Trim();

            if (!Int32.TryParse(PortText, out _)) return;

            Port = Convert.ToInt32(PortText);

            NatUtility.DeviceFound += DeleteForwardedPort;

            NatUtility.StartDiscovery();
        }

        private void DeleteForwardedPort(object sender, DeviceEventArgs args)
        {
            INatDevice device = args.Device;

            device.DeletePortMap(new Mapping(Protocol.Tcp, Port, Port));

            MessageBox.Show(Port + ". Forwarded Port Has Been Deleted!");

            NatUtility.DeviceFound -= DeleteForwardedPort;
        }


    }
}
