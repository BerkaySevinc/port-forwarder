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


        private int targetPort;
        
        // Forwards port.
        private void btnForward_Click(object sender, EventArgs e)
        {
            string portText = txtPort.Text.Trim();

            if (!int.TryParse(portText, out targetPort)) return;

            NatUtility.DeviceFound += ForwardPort;

            NatUtility.StartDiscovery();
        }
        private void ForwardPort(object sender, DeviceEventArgs args)
        {
            INatDevice device = args.Device;
            var protocol = radioBtnTCP.Checked ? Protocol.Tcp : Protocol.Udp;

            device.CreatePortMap(new Mapping(protocol, targetPort, targetPort));

            MessageBox.Show(targetPort + ". Port Forwarded To This Local Device!");

            NatUtility.DeviceFound -= ForwardPort;
        }


        // Deletes forwarded port map.
        private void btnDeleteForward_Click(object sender, EventArgs e)
        {
            string portText = txtPort.Text.Trim();

            if (!int.TryParse(portText, out targetPort)) return;

            NatUtility.DeviceFound += DeleteForwardedPort;

            NatUtility.StartDiscovery();
        }
        private void DeleteForwardedPort(object sender, DeviceEventArgs args)
        {
            INatDevice device = args.Device;
            var protocol = radioBtnTCP.Checked ? Protocol.Tcp : Protocol.Udp;

            device.DeletePortMap(new Mapping(protocol, targetPort, targetPort));

            MessageBox.Show(targetPort + ". Forwarded Port Has Been Deleted!");

            NatUtility.DeviceFound -= DeleteForwardedPort;
        }

    }
}
