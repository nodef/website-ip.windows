using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace sw_WebIp
{
	public partial class MainWin : Form
	{
		public MainWin()
		{
			InitializeComponent();
		}

		private void ObtainButton_Click(object sender, EventArgs e)
		{
			try
			{
				string hostName = WebsiteText.Text;
				
				int protocolOff = hostName.IndexOf("://");
				if(protocolOff >= 0)
					hostName = hostName.Substring(protocolOff + 3);
				
				int pathOff = hostName.IndexOf('/');
				if(pathOff >= 0)
					hostName = hostName.Remove(pathOff);

				int queryOff = hostName.IndexOf('?');
				if ( queryOff >= 0 )
					hostName = hostName.Remove(queryOff);

				IPAddress[] ipAddresses = Dns.GetHostAddresses(hostName);
				try
				{
					IPAddress ipv4Address = ipAddresses.First(ip => ip.AddressFamily == AddressFamily.InterNetwork);
					Ipv4AddressText.Text = ipv4Address.ToString();
				}
				catch(Exception)
				{ Ipv4AddressText.Text = "Failed to resolve."; }
				try
				{
					IPAddress ipv6Address = ipAddresses.First(ip => ip.AddressFamily == AddressFamily.InterNetworkV6);
					Ipv6AddressText.Text = ipv6Address.ToString();
				}
				catch ( Exception )
				{ Ipv6AddressText.Text = "Failed to resolve."; }
			}
			catch ( Exception )
			{
				Ipv4AddressText.Text = "Failed to resolve.";
				Ipv6AddressText.Text = "Failed to resolve.";
			}
		}
	}
}
