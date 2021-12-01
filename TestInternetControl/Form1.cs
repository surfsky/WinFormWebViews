using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestInternetControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.webBrowser.Silent = true; // 屏蔽脚本错误
            this.webBrowser.DownloadComplete += WebBrowser_DownloadComplete;
            this.webBrowser.DocumentComplete += WebBrowser_DocumentComplete;
        }

        private void WebBrowser_DownloadComplete(object sender, EventArgs e)
        {
            this.lblStatus.Text = "DownloadComplete";
        }

        private void WebBrowser_DocumentComplete(object sender, AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent e)
        {
            this.lblStatus.Text = "DocumentComplete";
        }

        //
        //
        //
        private void btnGo_Click(object sender, EventArgs e)
        {
            var url = this.tbUrl.Text;
            this.webBrowser.Navigate(url);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var html = this.tbHtml.Text;
            var path = string.Format("{0}\\tmp.html", Environment.CurrentDirectory);
            CreateFile(path, html);
            this.webBrowser.Navigate(path);
        }

        public static void CreateFile(string filePath, string data)
        {
            using (FileStream stream = File.Open(filePath, FileMode.Create))
            {
                StreamWriter streamWriter = new StreamWriter(stream);
                streamWriter.Write(data);
                streamWriter.Flush();
                streamWriter.Close();
            }
        }

    }
}
