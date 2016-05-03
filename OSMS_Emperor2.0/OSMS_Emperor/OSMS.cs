using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IrisSkins;

namespace OSMS_Emperor
{
    public partial class OSMS : Form
    {
        #region 加载函数
        public OSMS()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            //notifyIcon.Visible = false;

            InitFormControls();//初始化窗体控件

            #region 皮肤设置

            //sr.InitSkins(skinEngine);//初始化皮肤
            this.ForeColor = Color.FromArgb(0, 0, 0);
            //InitSkinList();

            #endregion

            this.Show();

        }
        #endregion

        #region 对象实例化

        SkinsRepertories sr = new SkinsRepertories();//皮肤库
        ComboBox cmbSkins = new ComboBox();//皮肤下拉框 

        #endregion

        #region 全局变量

        private int width;//窗体宽度
        private int height; //窗体高度
        private int borderH = 6;//主界面左右边框
        private int borderV = 10;//主界面上下边框
        private Panel pnHeadLine = new Panel();//标题容器
        private Panel pnNavigation = new Panel();//导航栏容器
        private Panel pnSubhead = new Panel();//副标题容器
        private Panel pnContent = new Panel();//主内容容器
        private Panel pnFooter = new Panel();//底部栏容器
        private Font lbFont3 = new Font("宋体", 12, FontStyle.Bold);//标题字体
        private Font lbFont2 = new Font("宋体", 14, FontStyle.Bold);//标题字体
        private Font lbFont1 = new Font("宋体", 16, FontStyle.Bold);//标题字体
        private Color pnColor = Color.FromArgb(204, 226, 232);//容器颜色

        List<Panel> panelList = new List<Panel>();//容器列表
        Dictionary<int, string> dicNaIco = new Dictionary<int, string>();//导航栏图标标号和标语

        #endregion

        #region 初始化窗体
        /// <summary>
        /// 初始化窗体
        /// </summary>
        /// <returns></returns>
        private bool InitFormControls()
        {
            ControlBox = false;//隐藏自带标题栏
            //InitSkinList();//皮肤选择下拉框
            InitFormSizeAndLoc();//初始化窗体大小和位置
            InitFormPanel();
            InitStaticControls();
            return true;
        }
        #endregion

        #region 初始化窗体大小和位置
        /// <summary>
        /// 初始化窗体大小和位置
        /// </summary>
        /// <returns></returns>
        public bool InitFormSizeAndLoc()
        {
            width = Screen.PrimaryScreen.Bounds.Width / 4 * 3;
            height = Screen.PrimaryScreen.Bounds.Height / 4 * 3;
            this.Width = width + borderH * 2;
            this.Height = height + borderV * 2;
            this.Location = new Point(width / 6, height / 6);
            return true;
        }
        #endregion

        #region 初始化换肤下拉框
        /// <summary>
        /// 初始化换肤下拉框
        /// </summary>
        /// <returns></returns>
        private bool InitSkinList()
        {
            Label lb = new Label();
            lb.Width = 35;
            lb.Text = "换肤:";
            lb.Location = new Point(pnHeadLine.Width - cmbSkins.Width, pnHeadLine.Height / 2 + 4);
            pnHeadLine.Controls.Add(lb);
            BindingSource bs = new BindingSource();
            bs.DataSource = sr.skins;
            cmbSkins.DataSource = bs;
            cmbSkins.DisplayMember = "key";
            cmbSkins.ValueMember = "Value";
            cmbSkins.Size = new System.Drawing.Size(80, 10);
            cmbSkins.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSkins.Location = new Point(pnHeadLine.Width - cmbSkins.Width - 5, pnHeadLine.Height / 2);
            cmbSkins.SelectedIndexChanged += new EventHandler(cmbSkinsSelChange);
            cmbSkins.BringToFront();
            pnHeadLine.Controls.Add(cmbSkins);
            return true;
        }

        /// <summary>
        /// 下拉框选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cmbSkinsSelChange(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            //MessageBox.Show(cmb.SelectedValue.ToString());
            sr.ChangeSkins(skinEngine, cmb.SelectedValue.ToString());
        }
        #endregion

        #region 初始化窗体布局
        /// <summary>
        /// 初始化窗体布局
        /// </summary>
        /// <returns></returns>
        public bool InitFormPanel()
        {
            //this.BackColor = Color.FromArgb(192, 192, 0);

            //标题栏
            pnHeadLine.Width = width;
            pnHeadLine.Height = height / 8 - borderH;
            pnHeadLine.Location = new Point(borderH, borderV);
            pnHeadLine.MouseDown += new MouseEventHandler(OSMS_MouseDown);
            pnHeadLine.MouseMove += new MouseEventHandler(OSMS_MouseMove);
            pnHeadLine.MouseUp += new MouseEventHandler(OSMS_MouseUp);
            pnHeadLine.BackColor = Color.White;

            //导航栏
            pnNavigation.Width = width / 6;
            pnNavigation.Height = height - pnHeadLine.Height - borderH;
            pnNavigation.Location = new Point(borderH, pnHeadLine.Height + borderV + borderH);
            pnNavigation.BackColor = pnColor;

            //副标题栏
            pnSubhead.Width = width - pnNavigation.Width - borderH;
            pnSubhead.Height = pnHeadLine.Height * 2 / 3 - borderH;
            pnSubhead.Location = new Point(pnNavigation.Width + borderH + borderH, pnHeadLine.Height + borderV + borderH);
            pnSubhead.BackColor = Color.White;

            //内容栏
            pnContent.Width = pnSubhead.Width;
            pnContent.Height = (height - pnHeadLine.Height - pnSubhead.Height) * 14 / 15 - borderH * 2;
            pnContent.Location = new Point(pnNavigation.Width + borderH + borderH, pnHeadLine.Height + pnSubhead.Height + borderV + borderH * 2);
            pnContent.BackColor = pnColor;

            //底部栏
            pnFooter.Width = pnContent.Width;
            pnFooter.Height = pnContent.Height / 14 - borderH;
            pnFooter.Location = new Point(pnNavigation.Width + borderH * 2, pnHeadLine.Height + pnSubhead.Height + pnContent.Height + borderV + borderH * 3);
            pnFooter.BackColor = pnColor;

            panelList.Add(pnHeadLine);
            panelList.Add(pnSubhead);
            panelList.Add(pnNavigation);
            panelList.Add(pnContent);
            panelList.Add(pnFooter);

            foreach (Panel pnItem in panelList)
            {

                //pnItem.BorderStyle = BorderStyle.FixedSingle;
                //pnItem.BackColor = Color.White;
                this.Controls.Add(pnItem);
            }
            return true;
        }
        #endregion

        #region 初始化主界面静态控件
        private bool InitStaticControls()
        {
            #region 标题栏
            PictureBox picIcon = new PictureBox();
            picIcon.Image = imgList.Images[0];
            picIcon.Size = new System.Drawing.Size(48, 48);
            picIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picIcon.Location = new Point(10, 10);
            //picIcon.BringToFront();
            pnHeadLine.Controls.Add(picIcon);

            Label lbName = new Label();
            lbName.Text = "办公用品管理系统";
            lbName.Font = lbFont2;
            lbName.Location = new Point(picIcon.Left + picIcon.Width + 7, picIcon.Height / 2 + picIcon.Top / 2 - 3);
            lbName.Width = 145;
            pnHeadLine.Controls.Add(lbName);

            PictureBox btnClose = new PictureBox();
            btnClose.BackColor = Color.Transparent;
            btnClose.Tag = 4;
            btnClose.Image = imgList.Images[1];
            btnClose.Size = new Size(24, 24);
            btnClose.Location = new Point(pnHeadLine.Width - 30, 5);
            pnHeadLine.Controls.Add(btnClose);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.MouseHover += new EventHandler(mouseHover);
            btnClose.MouseLeave += new EventHandler(mouseLeave);
            btnClose.MouseDown += new MouseEventHandler(mouseDown);
            btnClose.MouseUp += new MouseEventHandler(mouseUp);

            PictureBox btnMax = new PictureBox();
            btnMax.BackColor = Color.Transparent;
            btnMax.Tag = 5;
            btnMax.Image = imgList.Images[2];
            btnMax.Size = new Size(24, 24);
            btnMax.Location = new Point(pnHeadLine.Width - btnClose.Width - 30, 5);
            pnHeadLine.Controls.Add(btnMax);
            btnMax.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMax.MouseHover += new EventHandler(mouseHover);
            btnMax.MouseLeave += new EventHandler(mouseLeave);
            btnMax.MouseDown += new MouseEventHandler(mouseDown);
            btnMax.MouseUp += new MouseEventHandler(mouseUp);
            btnMax.Enabled = false;

            PictureBox btnMin = new PictureBox();
            btnMin.BackColor = Color.Transparent;
            btnMin.Tag = 6;
            btnMin.Image = imgList.Images[3];
            btnMin.Size = new Size(24, 24);
            btnMin.Location = new Point(pnHeadLine.Width - btnClose.Width - btnMax.Width - 30, 5);
            pnHeadLine.Controls.Add(btnMin);
            btnMin.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMin.MouseHover += new EventHandler(mouseHover);
            btnMin.MouseLeave += new EventHandler(mouseLeave);
            btnMin.MouseDown += new MouseEventHandler(mouseDown);
            btnMin.MouseUp += new MouseEventHandler(mouseUp);
            #endregion

            #region 副标题栏
            Label lbTitle = new Label();
            lbTitle.Text = "查询功能";
            lbTitle.Font = lbFont1;
            //lbTitle.BorderStyle = BorderStyle.FixedSingle;
            lbTitle.Width = 104;
            lbTitle.Top = (pnSubhead.Height - lbTitle.Height) / 2;
            lbTitle.Left = (pnSubhead.Width - lbTitle.Width) / 2;
            pnSubhead.Controls.Add(lbTitle);
            #endregion

            #region 导航栏
            dicNaIco.Add(-1, "汇总查询列表 ");
            dicNaIco.Add(0, "    物品分类");
            dicNaIco.Add(1, "    部门领用");
            dicNaIco.Add(2, "    人员领用");
            dicNaIco.Add(3, "    库存变动");
            dicNaIco.Add(4, "    超限库存");
            dicNaIco.Add(5, "    物品出入");
            dicNaIco.Add(6, "    商家供货");

            int left = 0;
            int top = 0;
            int width = pnNavigation.Width;

            CreateBtnPn(pnNavigation, new Point(left, top), width, pnSubhead.Height + 8, -1);
            int height = (pnNavigation.Height - pnSubhead.Height + 10 - pnFooter.Height - 25) / 7;
            top = pnSubhead.Height + 9;
            for (int i = 0; i < 7; i++)
            {
                CreateBtnPn(pnNavigation, new Point(left, top), width, height, i);
                top += height + 1;
            } 
            #endregion

            #region 底部栏
            Label lbFooter = new Label();
            lbFooter.Text = " 软件Emperor小组版权所有|小组成员：郑斐文|黄宝灵|林思晴|葛鸣枫|陈建丰  ";
            lbFooter.Width = pnFooter.Width;
            lbFooter.TextAlign = ContentAlignment.MiddleRight;
            pnFooter.Controls.Add(lbFooter); 
            #endregion

            return true;
        }
        #endregion

        #region 创建导航栏子容器
        /// <summary>
        /// 创建导航栏子容器
        /// </summary>
        /// <param name="parentPn"></param>
        /// <param name="location"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool CreateBtnPn(Panel parentPn, Point location, int width, int height, int index)
        {
            Panel pnTemp = new Panel();
            pnTemp.Location = location;
            pnTemp.Height = height;
            pnTemp.Width = width;
            //pnTemp.BorderStyle = BorderStyle.FixedSingle;
            pnTemp.BackColor = Color.White;
            CreateBtn(pnTemp, index);
            parentPn.Controls.Add(pnTemp);
            return true;
        }
        #endregion

        #region 创建导航栏子按钮
        /// <summary>
        /// 创建导航栏子按钮
        /// </summary>
        /// <param name="pnParent"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool CreateBtn(Panel pnParent, int index)
        {

            if (index > -1)
            {
                PictureBox picIco = new PictureBox();
                picIco.Size = new System.Drawing.Size(32, 32);
                picIco.SizeMode = PictureBoxSizeMode.StretchImage;
                picIco.Image = imgNaList.Images[index];
                picIco.Location = new Point(pnParent.Width / 8, pnParent.Height / 4);
                picIco.SendToBack();
                //picIco.MouseHover += new EventHandler(NaMouseHover);
                //picIco.MouseLeave += new EventHandler(NaMouseLeave);

                pnParent.Controls.Add(picIco);
                Label lbText = new Label();
                lbText.Text = dicNaIco[index];
                lbText.Size = pnParent.Size;
                lbText.TextAlign = ContentAlignment.MiddleCenter;
                lbText.Font = lbFont2;
                lbText.Location = new Point(0, 0);
                lbText.ForeColor = pnColor;
                lbText.MouseHover += new EventHandler(NaMouseHover);
                lbText.MouseLeave += new EventHandler(NaMouseLeave);
                lbText.Tag = index;
                lbText.Click += new EventHandler(NaClick);
                pnParent.Controls.Add(lbText);
                return true;
            }
            else
            {
                Label lbText = new Label();
                lbText.Text = dicNaIco[index];
                lbText.Font = lbFont2;
                lbText.Width = pnParent.Width;
                lbText.Location = new Point(pnParent.Width / 9, pnParent.Height / 3);
                lbText.Tag = index;
                pnParent.Controls.Add(lbText);
                return true;
            }
        }
        #endregion

        #region 导航栏子按钮效果
        /// <summary>
        /// 导航栏子按钮效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NaMouseHover(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            lb.BackColor = pnColor;
            lb.ForeColor = Color.White;
        }

        private void NaMouseLeave(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            lb.ForeColor = pnColor;
            lb.BackColor = Color.White;
        }
        #endregion

        #region 导航栏子按钮点击事件
        /// <summary>
        /// 导航栏子按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void NaClick(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            int temp = Convert.ToInt32(lb.Tag);
            switch (temp)
            {
                case 0: pnContent.BackColor = Color.Red; break;
                case 1: pnContent.BackColor = Color.Yellow; break;
                case 2: pnContent.BackColor = Color.Blue; break;
                case 3: pnContent.BackColor = Color.Green; break;
                case 4: pnContent.BackColor = Color.RoyalBlue; break;
                case 5: pnContent.BackColor = Color.Purple; break;
                case 6: pnContent.BackColor = Color.Gray; break;
                default:
                    break;
            }
        }
        #endregion

        #region 最大最小关闭操作键效果
        public void mouseHover(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.Image = imgList.Images[(int)pic.Tag];
        }
        public void mouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.Image = imgList.Images[(int)pic.Tag - 3];
        }

        public void mouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox pic = sender as PictureBox;
                pic.Location = new Point(pic.Left + 1, pic.Top + 1);
                switch (pic.Tag.ToString())
                {
                    case "4": this.Close(); break;
                    case "5": this.WindowState = FormWindowState.Maximized; break;
                    case "6": this.WindowState = FormWindowState.Minimized; break;
                    default:
                        break;
                }
            }

        }

        public void mouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox pic = sender as PictureBox;
                pic.Location = new Point(pic.Left - 1, pic.Top - 1);
            }

        }

        #endregion

        #region 界面最大化事件
        /// <summary>
        /// 界面最大化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            cmbSkins.Location = new Point(this.Width - 110, 10);
        }
        #endregion

        #region 最小化事件
        /// <summary>
        /// 最小化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MinimumSizeChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region 关闭窗体事件
        /// <summary>
        /// 关闭窗体事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!notifyIcon.Visible)
            {
                if (MessageBox.Show("是否最小化到托盘", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Hide();
                    notifyIcon.Visible = true;
                    //notifyIcon.ShowBalloonTip(5000, "Hello", "I'm Emperor", ToolTipIcon.Info);
                    e.Cancel = true;
                }
            }
        }
        #endregion

        #region 托盘点击事件
        /// <summary>
        /// 托盘点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                notifyIcon.Visible = false;
            }
            else if (e.Button == MouseButtons.Right)
            {
                cmsTray.Show();
            }
        }
        #endregion

        #region 托盘右击菜单点击事件
        /// <summary>
        /// 托盘右击菜单点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemShow_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon.Visible = false;
        }

        private void ToolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 窗体鼠标拖动效果
        private Point loc = new Point();
        private bool leftFlag;
        private void OSMS_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                loc = new Point(-e.X, -e.Y);
                leftFlag = true;

            }
        }

        private void OSMS_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(loc.X, loc.Y);
                Location = mousePosition;
            }
        }

        private void OSMS_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }
        #endregion

    }
}
