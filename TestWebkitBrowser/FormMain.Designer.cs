namespace WebkitExplorer
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.webKitBrowser = new WebKit.WebKitBrowser();
            this.tbHtml = new ICSharpCode.TextEditor.TextEditorControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbUrl = new System.Windows.Forms.ToolStripTextBox();
            this.btnGo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShowHtml = new System.Windows.Forms.ToolStripButton();
            this.btnLoadHtml2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUrl = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webKitBrowser
            // 
            this.webKitBrowser.BackColor = System.Drawing.Color.White;
            this.webKitBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webKitBrowser.Location = new System.Drawing.Point(0, 0);
            this.webKitBrowser.Name = "webKitBrowser";
            this.webKitBrowser.Size = new System.Drawing.Size(590, 588);
            this.webKitBrowser.TabIndex = 0;
            this.webKitBrowser.Url = null;
            this.webKitBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webKitBrowser_DocumentCompleted);
            this.webKitBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webKitBrowser_Navigated);
            this.webKitBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webKitBrowser_Navigating);
            this.webKitBrowser.Error += new WebKit.WebKitBrowserErrorEventHandler(this.webKitBrowser_Error);
            this.webKitBrowser.DownloadBegin += new WebKit.FileDownloadBeginEventHandler(this.webKitBrowser_DownloadBegin);
            // 
            // tbHtml
            // 
            this.tbHtml.ConvertTabsToSpaces = true;
            this.tbHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHtml.IsReadOnly = false;
            this.tbHtml.Location = new System.Drawing.Point(0, 0);
            this.tbHtml.Name = "tbHtml";
            this.tbHtml.Size = new System.Drawing.Size(342, 588);
            this.tbHtml.TabIndex = 0;
            this.tbHtml.Text = resources.GetString("tbHtml.Text");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbUrl,
            this.btnGo,
            this.toolStripSeparator1,
            this.btnShowHtml,
            this.btnLoadHtml2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(936, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(500, 25);
            this.tbUrl.Text = "https://lbs.qq.com/webDemoCenter/javascriptV2/mapOperate/createMap";
            // 
            // btnGo
            // 
            this.btnGo.Image = global::WebkitExplorer.Properties.Resources.bullet_right;
            this.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(45, 22);
            this.btnGo.Text = "Go";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnShowHtml
            // 
            this.btnShowHtml.Image = global::WebkitExplorer.Properties.Resources.application_lightning;
            this.btnShowHtml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowHtml.Name = "btnShowHtml";
            this.btnShowHtml.Size = new System.Drawing.Size(84, 22);
            this.btnShowHtml.Text = "LoadHtml";
            this.btnShowHtml.Click += new System.EventHandler(this.btnShowHtml_Click);
            // 
            // btnLoadHtml2
            // 
            this.btnLoadHtml2.Image = global::WebkitExplorer.Properties.Resources.application_lightning;
            this.btnLoadHtml2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadHtml2.Name = "btnLoadHtml2";
            this.btnLoadHtml2.Size = new System.Drawing.Size(91, 22);
            this.btnLoadHtml2.Text = "LoadHtml2";
            this.btnLoadHtml2.Click += new System.EventHandler(this.btnLoadHtml2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblInfo,
            this.lblUrl,
            this.lblTitle});
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(936, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblInfo
            // 
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(29, 17);
            this.lblInfo.Text = "STS";
            // 
            // lblUrl
            // 
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(31, 17);
            this.lblUrl.Text = "URL";
            // 
            // lblTitle
            // 
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.Text = "TITLE";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.webKitBrowser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbHtml);
            this.splitContainer1.Size = new System.Drawing.Size(936, 588);
            this.splitContainer1.SplitterDistance = 590;
            this.splitContainer1.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 641);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebkitBrowser - http://github.com/surfsky";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox tbUrl;
        private System.Windows.Forms.ToolStripButton btnGo;
        private System.Windows.Forms.ToolStripButton btnShowHtml;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblInfo;
        private ICSharpCode.TextEditor.TextEditorControl tbHtml;
        private WebKit.WebKitBrowser webKitBrowser;
        private System.Windows.Forms.ToolStripStatusLabel lblUrl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel lblTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton btnLoadHtml2;
    }
}

