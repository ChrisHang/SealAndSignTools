namespace SealAndSignTools
{
    partial class CFCATools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CFCATools));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.签署ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FullSreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HandWriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageSignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.key内印章图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.公司名称外观ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人名公司外观ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SignCertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trustSignplugin = new AxPDFViewerLib.AxAxPDFViewer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trustSignplugin)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.签署ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.添加ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.openToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem1,
            this.CloseFileToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Enabled = false;
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.NewToolStripMenuItem.Text = "新建";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "打开";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveToolStripMenuItem.Text = "保存";
            // 
            // SaveAsToolStripMenuItem1
            // 
            this.SaveAsToolStripMenuItem1.Enabled = false;
            this.SaveAsToolStripMenuItem1.Name = "SaveAsToolStripMenuItem1";
            this.SaveAsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.SaveAsToolStripMenuItem1.Text = "另存为";
            // 
            // CloseFileToolStripMenuItem
            // 
            this.CloseFileToolStripMenuItem.Enabled = false;
            this.CloseFileToolStripMenuItem.Name = "CloseFileToolStripMenuItem";
            this.CloseFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CloseFileToolStripMenuItem.Text = "关闭文档";
            this.CloseFileToolStripMenuItem.Click += new System.EventHandler(this.CloseFileToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "退出";
            // 
            // 签署ToolStripMenuItem
            // 
            this.签署ToolStripMenuItem.Name = "签署ToolStripMenuItem";
            this.签署ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.签署ToolStripMenuItem.Text = "编辑";
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FullSreenToolStripMenuItem,
            this.toolBarShowToolStripMenuItem});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // FullSreenToolStripMenuItem
            // 
            this.FullSreenToolStripMenuItem.Name = "FullSreenToolStripMenuItem";
            this.FullSreenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.FullSreenToolStripMenuItem.Text = "全屏显示";
            this.FullSreenToolStripMenuItem.CheckedChanged += new System.EventHandler(this.FullSreenToolStripMenuItem_CheckedChanged);
            this.FullSreenToolStripMenuItem.Click += new System.EventHandler(this.FullSreenToolStripMenuItem_Click);
            // 
            // toolBarShowToolStripMenuItem
            // 
            this.toolBarShowToolStripMenuItem.Checked = true;
            this.toolBarShowToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarShowToolStripMenuItem.Name = "toolBarShowToolStripMenuItem";
            this.toolBarShowToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.toolBarShowToolStripMenuItem.Text = "工具栏";
            this.toolBarShowToolStripMenuItem.CheckedChanged += new System.EventHandler(this.toolBarShowToolStripMenuItem_CheckedChanged);
            this.toolBarShowToolStripMenuItem.Click += new System.EventHandler(this.toolBarShowToolStripMenuItem_Click);
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HandWriteToolStripMenuItem,
            this.ImageSignToolStripMenuItem,
            this.key内印章图片ToolStripMenuItem,
            this.公司名称外观ToolStripMenuItem,
            this.人名公司外观ToolStripMenuItem});
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.添加ToolStripMenuItem.Text = "添加";
            // 
            // HandWriteToolStripMenuItem
            // 
            this.HandWriteToolStripMenuItem.Name = "HandWriteToolStripMenuItem";
            this.HandWriteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.HandWriteToolStripMenuItem.Text = "手写签字";
            this.HandWriteToolStripMenuItem.Click += new System.EventHandler(this.HandWriteToolStripMenuItem_Click);
            // 
            // ImageSignToolStripMenuItem
            // 
            this.ImageSignToolStripMenuItem.Name = "ImageSignToolStripMenuItem";
            this.ImageSignToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ImageSignToolStripMenuItem.Text = "外传印章图片";
            this.ImageSignToolStripMenuItem.Click += new System.EventHandler(this.ImageSignToolStripMenuItem_Click);
            // 
            // key内印章图片ToolStripMenuItem
            // 
            this.key内印章图片ToolStripMenuItem.Name = "key内印章图片ToolStripMenuItem";
            this.key内印章图片ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.key内印章图片ToolStripMenuItem.Text = "Key内印章图片";
            // 
            // 公司名称外观ToolStripMenuItem
            // 
            this.公司名称外观ToolStripMenuItem.Name = "公司名称外观ToolStripMenuItem";
            this.公司名称外观ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.公司名称外观ToolStripMenuItem.Text = "公司名称外观";
            // 
            // 人名公司外观ToolStripMenuItem
            // 
            this.人名公司外观ToolStripMenuItem.Name = "人名公司外观ToolStripMenuItem";
            this.人名公司外观ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.人名公司外观ToolStripMenuItem.Text = "人名+公司名称外观";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SignCertToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // SignCertToolStripMenuItem
            // 
            this.SignCertToolStripMenuItem.Name = "SignCertToolStripMenuItem";
            this.SignCertToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SignCertToolStripMenuItem.Text = "签章证书";
            this.SignCertToolStripMenuItem.Click += new System.EventHandler(this.SignCertToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // trustSignplugin
            // 
            this.trustSignplugin.Enabled = true;
            this.trustSignplugin.Location = new System.Drawing.Point(0, 27);
            this.trustSignplugin.Name = "trustSignplugin";
            this.trustSignplugin.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("trustSignplugin.OcxState")));
            this.trustSignplugin.Size = new System.Drawing.Size(1063, 738);
            this.trustSignplugin.TabIndex = 1;
            this.trustSignplugin.NotifyCtrlReady += new System.EventHandler(this.trustSignplugin_NotifyCtrlReady);
            this.trustSignplugin.NotifyDragRect += new AxPDFViewerLib._IAxPDFViewerEvents_NotifyDragRectEventHandler(this.trustSignplugin_NotifyDragRect);
            this.trustSignplugin.NotifyClickPoint += new AxPDFViewerLib._IAxPDFViewerEvents_NotifyClickPointEventHandler(this.trustSignplugin_NotifyClickPoint);
            this.trustSignplugin.NotifyClickField += new AxPDFViewerLib._IAxPDFViewerEvents_NotifyClickFieldEventHandler(this.trustSignplugin_NotifyClickField);
            // 
            // CFCATools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 777);
            this.Controls.Add(this.trustSignplugin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CFCATools";
            this.Text = "CFCATools";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trustSignplugin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 签署ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FullSreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolBarShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private AxPDFViewerLib.AxAxPDFViewer trustSignplugin;
        private System.Windows.Forms.ToolStripMenuItem CloseFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HandWriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImageSignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem key内印章图片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 公司名称外观ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人名公司外观ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SignCertToolStripMenuItem;
    }
}

