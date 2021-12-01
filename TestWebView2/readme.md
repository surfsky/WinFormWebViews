# Microsoft WebView2 demo


https://github.com/surfsky/WinFormWebViews/

# Steps

1. Nuget install Microsoft.Web.WebView2.
2. Drag webview2 control into form.
![](./Doc/01.png)

2. Write codes.

```csharp

// navigate to some url
this.webView.Source = new Uri("baidu.com");
this.webView.CoreWebView2.Navigate(this.tbUrl.Text);

// load html2
var html = this.tbHtml.Text;
var path = string.Format("{0}\\tmp.html", Environment.CurrentDirectory);
CreateFile(path, html);
this.webView.CoreWebView2.Navigate(path);  // ok
```

3. Run

![](./Doc/05.png)


# Tips

- �÷���֧�� Edge �� IE��
- �÷���������֧�ֵģ�2021-11��[https://docs.microsoft.com/zh-cn/microsoft-edge/webview2/get-started/winforms]


``` cs
��ʼ��
    ����һ��
        webView.Source = new Uri("https://baidu.com");
    ��������
        webView.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;
        webView.EnsureCoreWebView2Async();


JS������������
   ����һ��Message
        webView.WebMessageReceived += WebView_WebMessageReceived;
        // js �ص�ʱ�ᴥ���÷���
        private void WebView_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            var cmd = e.WebMessageAsJson.Trim('"');
            var p = cmd.SplitString();
            ShowLngLat(p[1], p[2], p[3], p[4]);
        }
        /// <summary>��ʾ��γ�ȡ�</summary>
        public void ShowLngLat(string lng1, string lat1, string lng2, string lat2)
        {
            this.tbPointTL.Text = string.Format("{0}, {1}", lng1, lat1);
            this.tbPointBR.Text = string.Format("{0}, {1}", lng2, lat2);
        }

   ��������ע��HostObject��ӳ���෽��
        webView.CoreWebView2.AddHostObjectToScript("bridge", new JavaScriptBridge());
        webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("var bridge = chrome.webview.hostObjects.bridge;");
        /// <summary>
        /// ���౩¶�� Js ���е���
        /// </summary>
        [ComVisible(true)]
        public class JavaScriptBridge
        {
            /// <summary>
            /// const bridge = chrome.webview.hostObjects.bridge;
            /// var info = await bridge.func("world");
            /// </summary>
            /// <param name="p"></param>
            /// <returns></returns>
            public string func(string p)
            {
                return "hello " + p;
            }
        }

�����������JS
    ����һ��ֱ��ִ��
            webView.CoreWebView2.ExecuteScriptAsync("alert('webview2 is ready!')");
    ����������Ϣ��ʽ

```