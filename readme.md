# About

https://github.com/surfsky/WinFormWebViews/

Windows Form WebView/WebBrowser solutions: 

- [WebBrowser control](https://github.com/surfsky/WinFormWebViews/TestWebBrowser/)
- [AxWebBrowser COM control (Microsoft Internet Controls)](https://github.com/surfsky/WinFormWebViews/TestInternetControl/)
- [XAML Island + WebView](https://github.com/surfsky/WinFormWebViews/TestXamlIsland/)
- [WebkitBrowser](https://github.com/surfsky/WinFormWebViews/TestWebkitBrowser/)
- [CefSharp](https://github.com/surfsky/WinFormWebViews/TestCefSharp/)
- ...


# Compare

Solution      | Speed   | Size   | ShowTencentMap | LoadStringForTencentMap  | LoadFileForTencentMap 
--------------|---------|--------|----------------|--------------------------|-----------------------|
WebBrowser    | normal  | small  | ok             | fail                     | ok       
AxWebBrowser  | normal  | small  | ok             | fail                     | ok       
XamlIsland    | fast    | small  | ok             | fail                     | fail     
WebkitBrowser | slow    | normal | fail           | fail                     | fail       
CefSharp      | veryfast| big    | ok             | ok                       | ok       


TencentMap: https://lbs.qq.com/webDemoCenter/javascriptV2/mapOperate/createMap

# Snap

[](./TestCEFSharp/Doc/02.png)

