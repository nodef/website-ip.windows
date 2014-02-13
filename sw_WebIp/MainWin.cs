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
				
				IPAddress[] hostAddresses = Dns.GetHostAddresses(hostName);
				IpAddressText.Text = hostAddresses[0].ToString();
			}
			catch ( Exception )
			{ IpAddressText.Text = "Failed to resolve."; }
		}
	}
}
