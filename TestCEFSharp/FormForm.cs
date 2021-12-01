using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using CefSharp;
using CefSharp.WinForms;
using ICSharpCode.TextEditor.Document;

namespace TestCEFSharp
{
    public partial class FormForm : Form
    {
        protected ChromiumWebBrowser browser;

        public FormForm()
        {
            InitializeComponent();
            InitBrowser();
            tbHtml.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("XML");
        }

        //-----------------------------------------
        // Browser
        //-----------------------------------------
        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("http://www.baidu.com");
            browser.Font = new Font("Arial", 10.5f);
            browser.Dock = DockStyle.Fill;
            browser.LoadingStateChanged += Browser_LoadingStateChanged;
            browser.AddressChanged += Browser_AddressChanged;
            browser.FrameLoadEnd += Browser_FrameLoadEnd;
            browser.JavascriptMessageReceived += Browser_JavascriptMessageReceived;
            this.splitContainer.Panel1.Controls.Add(browser);
        }

        /// <summary>接收到网页发来的消息</summary>
        private void Browser_JavascriptMessageReceived(object sender, JavascriptMessageReceivedEventArgs e)
        {
            Invoke(() =>
            {
                this.tbMessage.Text += e.Message.ToString() + "\r\n";
            });
        }

        // 调用 js 方法
        private void btnCallScript_Click(object sender, EventArgs e)
        {
            browser.ExecuteScriptAsync("show('hello world')");
        }


        private void Browser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            var task = e.Frame.GetSourceAsync();
            task.ContinueWith(t =>
            {
                if (!t.IsFaulted)
                {
                    Invoke(() =>
                    {
                        //this.tbHtml.Text = t.Result;
                    });
                }
            });
        }

        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            Invoke(() =>
            {
                this.lblUrl.Text = e.Address;
            });
        }

        private void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            Invoke(() =>
            {
                this.lblStatus.Text = e.IsLoading ? "Loading" : "Ready";
                this.btnBack.Enabled = e.CanGoBack;
                this.btnForward.Enabled = e.CanGoForward;
                if (!e.IsLoading)
                {
                    //this.tbHtml.Text = browser.GetTextAsync().Result;
                }
            });
        }

        public void Invoke(Action action)
        {
            if (InvokeRequired)
                BeginInvoke(action);
            else
                action.Invoke();
        }


        //-----------------------------------------
        // Form events
        //-----------------------------------------
        private void tbUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Go();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Go();
        }

        void Go()
        {
            var url = this.tbUrl.Text;
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                browser.Load(url);
                lblUrl.Text = url;
            }
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            browser.ShowDevTools();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            browser.Back();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            browser.Forward();
        }

        private void btnLoadHtml_Click(object sender, EventArgs e)
        {
            browser.LoadHtml(this.tbHtml.Text, "http://www.example.com/");
        }

    }
}
