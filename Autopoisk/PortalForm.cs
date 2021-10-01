using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortalMazda
{
    public partial class WindowForm : Form
    {
        WebBrowser webBrowser = new WebBrowser();
        string _url = "https://mapps.mazdaeur.com/cas/login?service=https%3a%2f%2fportal.mazdaeur.com%2f";
        public WindowForm()
        {
            InitializeComponent();
            ProxyControl.Set("127.0.0.1:8888");
            webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowserComleted);
            webBrowser.Size = ClientSize;
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.Navigate($"{_url}");
            this.BrowserPanel.Controls.Add(webBrowser);
            this.WindowState = FormWindowState.Maximized;
        }

        private void webBrowserComleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            if (webBrowser.ReadyState == WebBrowserReadyState.Uninitialized || webBrowser.ReadyState == WebBrowserReadyState.Loading || webBrowser.ReadyState == WebBrowserReadyState.Loaded)
            {
                downloadGIF.Visible = true;
            }
            if (webBrowser.ReadyState == WebBrowserReadyState.Complete)
            {
                downloadGIF.Visible = false;
            }
        }
    }
}
