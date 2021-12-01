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

/*
 * Microsoft WebView2
 * https://docs.microsoft.com/zh-cn/microsoft-edge/webview2/get-started/winforms
 * 
 */
namespace TestWebView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webView.Source = new Uri("https://baidu.com");
            //webView.ScriptErrorsSuppressed = true;  // ignore js error
            //webView.DocumentCompleted += WebBrowser_DocumentCompleted;
            webView.NavigationCompleted += WebView_NavigationCompleted;
        }

        private void WebView_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            this.lblStatus.Text = "Complete";
            this.lblTitle.Text = webView.CoreWebView2.DocumentTitle;
            this.lblUrl.Text = webView.Source.ToString();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
                this.webView.CoreWebView2.Navigate(this.tbUrl.Text);
        }

        private void btnLoadHtml_Click(object sender, EventArgs e)
        {
            var html = this.tbHtml.Text;
            //this.webView.CoreWebView2.DocumentText = html;  // may show nothing
        }

        private void btnLoadHtml2_Click(object sender, EventArgs e)
        {
            var html = this.tbHtml.Text;
            var path = string.Format("{0}\\tmp.html", Environment.CurrentDirectory);
            CreateFile(path, html);
            this.webView.CoreWebView2.Navigate(path);
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
