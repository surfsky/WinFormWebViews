# Microsoft Web Browser demo


https://github.com/surfsky/WinFormWebViews/

# Steps

1. Drag WebBrowser control into form.
![](./Doc/01.png)

2. Write codes.

```csharp
// ignore js error
webBrowser.ScriptErrorsSuppressed = true;  // ignore js error

// navigate to some url
this.webBrowser.Navigate(this.tbUrl.Text);

// load html
var html = this.tbHtml.Text;
this.webBrowser.DocumentText = html;  // may show nothing

// load html2
var html = this.tbHtml.Text;
var path = string.Format("{0}\\tmp.html", Environment.CurrentDirectory);
CreateFile(path, html);
this.webBrowser.Navigate(path);  // ok
```

3. Run

![](./Doc/05.png)
