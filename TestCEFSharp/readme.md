# TestCefSharp

CefSharp web browser demo. http://github.com/surfsky/TestCefSharp
Cef is Chromium Embedded Framework.
CefSharp is a CEF dotnet wrapper. See:

- https://github.com/cefsharp/CefSharp
- http://cefsharp.github.io
- https://github.com/cefsharp/CefSharp.MinimalExample
- https://github.com/sharpbrowser/SharpBrowser
- https://github.com/cefnet/cefnet

# Features

- [x] Display web
- [x] Back & Forward button
- [x] Develop tool
- [x] Show html
- [x] Load html
- [ ] Invoke Js function : https://www.cnblogs.com/jsydb/p/9993516.html
- [ ] Invoke C# method: https://www.cnblogs.com/jsydb/p/9993516.html
- [ ] Use tab to show "_blank" link page: 

# Basic steps to use CefSharp browser control

1. Create windows form project with netframework over **4.5.2**.
2. install CefSharp with nuget.

    ![](./Doc/nuget.png)

3. Set project build platform to x64

    ![](./Doc/anycpu.png)

4. Write codes

    ``` csharp
    using CefSharp;
    using CefSharp.WinForms;

    public partial class Form1 : Form
    {
        protected ChromiumWebBrowser browser;

        public Form1()
        {
            InitializeComponent();
            InitBrowser();
        }

        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("http://www.baidu.com");
            browser.Font = new Font("Arial", 10.5f);
            browser.Dock = DockStyle.Fill;
            browser.LoadingStateChanged += Browser_LoadingStateChanged;
            this.Controls.Add(browser);
        }

        private void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            this.lblStatus.Text = e.IsLoading ? "Loading" : "Ready";
        }
    }
    ```

5. Run it.

    ![](./Doc/01.png)
    ![](./Doc/02.png)
    ![](./Doc/03.png)
    ![](./Doc/04.png)


