namespace OSMS_Emperor
{
    partial class OSMS
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OSMS));
            this.skinEngine = new Sunisoft.IrisSkin.SkinEngine();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示主菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.imgNaList = new System.Windows.Forms.ImageList(this.components);
            this.cmsTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinEngine
            // 
            this.skinEngine.@__DrawButtonFocusRectangle = true;
            this.skinEngine.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine.SerialNumber = "";
            this.skinEngine.SkinFile = null;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.cmsTray;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDown);
            // 
            // cmsTray
            // 
            this.cmsTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示主菜单ToolStripMenuItem,
            this.注销ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.cmsTray.Name = "contextMenuStrip";
            this.cmsTray.Size = new System.Drawing.Size(137, 70);
            // 
            // 显示主菜单ToolStripMenuItem
            // 
            this.显示主菜单ToolStripMenuItem.Name = "显示主菜单ToolStripMenuItem";
            this.显示主菜单ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.显示主菜单ToolStripMenuItem.Text = "显示主菜单";
            this.显示主菜单ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemShow_Click);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.注销ToolStripMenuItem.Text = "注销";
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemClose_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "OSMS.ico");
            this.imgList.Images.SetKeyName(1, "Close1.png");
            this.imgList.Images.SetKeyName(2, "Max1.png");
            this.imgList.Images.SetKeyName(3, "Min1.png");
            this.imgList.Images.SetKeyName(4, "Close2.png");
            this.imgList.Images.SetKeyName(5, "Max2.png");
            this.imgList.Images.SetKeyName(6, "Min2.png");
            // 
            // imgNaList
            // 
            this.imgNaList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgNaList.ImageStream")));
            this.imgNaList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgNaList.Images.SetKeyName(0, "1.jpg");
            this.imgNaList.Images.SetKeyName(1, "2.jpg");
            this.imgNaList.Images.SetKeyName(2, "3.jpg");
            this.imgNaList.Images.SetKeyName(3, "4.jpg");
            this.imgNaList.Images.SetKeyName(4, "5.jpg");
            this.imgNaList.Images.SetKeyName(5, "6.jpg");
            this.imgNaList.Images.SetKeyName(6, "7.jpg");
            // 
            // OSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OSMS";
            this.MinimumSizeChanged += new System.EventHandler(this.Form1_MinimumSizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OSMS_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OSMS_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OSMS_MouseUp);
            this.cmsTray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip cmsTray;
        private System.Windows.Forms.ToolStripMenuItem 显示主菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ImageList imgNaList;
    }
}

