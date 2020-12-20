using System;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace WebsiteIP {
  public partial class MainForm : Form {

    public MainForm() {
      InitializeComponent();
    }

    private void BSubmit_Click(object sender, EventArgs e) {
      IPAddress ipv4 = null, ipv6 = null;
      try {
        string hostname = GetHostname(TURL.Text);
        IPAddress[] ips = Dns.GetHostAddresses(hostname);
        ipv4 = ips.First(ip => ip.AddressFamily == AddressFamily.InterNetwork);
        ipv6 = ips.First(ip => ip.AddressFamily == AddressFamily.InterNetworkV6);
      }
      catch (Exception) {}
      TIPv4.Text = ipv4 != null ? ipv4.ToString() : "Failed to resolve.";
      TIPv6.Text = ipv6 != null ? ipv6.ToString() : "Failed to resolve.";
    }

    private string GetHostname(string url) {
      int i = url.IndexOf("://");
      int j = i<0 ? 0 : i+3;
      int k = url.IndexOf(":", j);
      int l = url.IndexOf("/", j);
      k = k<0 ? url.Length : k;
      l = l<0 ? url.Length : l;
      return url.Substring(j, Math.Min(k, l));
    }
  }
}
