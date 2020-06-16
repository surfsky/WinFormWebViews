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

namespace TestXAMLLand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.webView.NavigationCompleted += WebView_NavigationCompleted;
        }

        private void WebView_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e)
        {
            this.lblStatus.Text = e.IsSuccess ? "OK" : "Fail";
            this.lblTitle.Text = "";
            this.lblUrl.Text = e.Uri?.ToString();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.webView.Navigate(this.tbUrl.Text);
        }

        private void btnLoadHtml_Click(object sender, EventArgs e)
        {
            var html = this.tbHtml.Text;
            this.webView.NavigateToString(html); // may not show
        }

        private void btnLoadHtml2_Click(object sender, EventArgs e)
        {
            var html = this.tbHtml.Text;
            var path = string.Format("{0}\\tmp.html", Environment.CurrentDirectory);
            CreateFile(path, html);

            path = @"file:///" + path.Replace(@"\", @"/");  // 转化为webview支持的地址（如 file:///c:/html/file.htm）
            //path = @"ms-appdata:///" + path.Replace(@"\", @"/");   // 应用文件夹
            //path = @"ms-appx-web:///" + path.Replace(@"\", @"/");  // 应用包内文件
            this.webView.Navigate(new Uri(path));  // System.Exception:“已中止操作 (异常来自 HRESULT:0x80004004 (E_ABORT))”
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
