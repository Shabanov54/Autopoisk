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
        DateTime timeEnd;
        DateTime timeStart;
        TimeSpan time;
        string timeTomessage;
        //ClienService ClienService = new ClienService();
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
            Log.Instance.Info("Запуск формы с WebBrowser", "Winform");
            timeStart = DateTime.Now;
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
                timeEnd = DateTime.Now;
                time = timeEnd.Subtract(timeStart);
                timeTomessage = $"{time.Seconds} сек : {time.Milliseconds} мсек";
                Log.Instance.Info("Собрал необходимые данные для отправки в клиентское приложение", "Winform");

                //string messageBox = ClientService.Client.RunClient(timeTomessage);
                //Log.Instance.Info("Получение строкового значения от сервера1", "Winform");
                //MessageBox.Show(messageBox);

                //string messagebogGetData = ClientService.Client.RunGetData();
                //Log.Instance.Info("Получение строкового значения от сервера2", "Winform");
                //MessageBox.Show(messagebogGetData);

                string messageGetDataBD = ClientService.Client.RunGetDataPostreg();
                Log.Instance.Info("Получение строкового значения от сервера БД", "Winform");
                MessageBox.Show(messageGetDataBD);

                Log.Instance.Info("Вывод строкового значения в всплывающее окно", "Winform");

            }
        }

    }
}
