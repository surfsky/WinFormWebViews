using ICSharpCode.TextEditor.Document;
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

namespace WebkitExplorer
{
    public partial class FormMain : Form
    {
        //
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            tbHtml.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("XML");
            //this.tbUrl.Text = "http://baidu.com";
            //this.webKitBrowser.DocumentText = "<h1>Hello WebkitBrowser</h1>";
        }

        //---------------------------------------------
        // Form Events
        //---------------------------------------------
        // go to url
        private void btnGo_Click(object sender, EventArgs e)
        {
            var url = this.tbUrl.Text;
            this.webKitBrowser.Navigate(url);
        }

        // display html to webbrowser
        private void btnShowHtml_Click(object sender, EventArgs e)
        {
            var html = this.tbHtml.Text;
            this.webKitBrowser.DocumentText = html;   // show nothing
        }

        // save to temp html file and display
        private void btnLoadHtml2_Click(object sender, EventArgs e)
        {
            var html = this.tbHtml.Text;
            var path = string.Format("{0}\\tmp.html", Environment.CurrentDirectory);
            CreateFile(path, html);
            this.webKitBrowser.Navigate(path);   // show nothing
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


        //---------------------------------------------
        // WebBrowser events
        //---------------------------------------------
        private void webKitBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.lblInfo.Text = "Complete";
            this.tbHtml.Text = webKitBrowser.DocumentText;
            this.lblTitle.Text = webKitBrowser.DocumentTitle;
        }

        private void webKitBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.lblInfo.Text = "Navigating";
            this.lblUrl.Text = e.Url.ToString();
        }

        private void webKitBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.lblInfo.Text = "Navigated";
        }

        private void webKitBrowser_Error(object sender, WebKit.WebKitBrowserErrorEventArgs e)
        {
            this.lblInfo.Text = "Error";
        }

        private void webKitBrowser_DownloadBegin(object sender, WebKit.FileDownloadBeginEventArgs e)
        {
            this.lblInfo.Text = "Downloading";
        }
    }
}
