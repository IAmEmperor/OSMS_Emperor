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
        public OSMS()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //notifyIcon.Visible = false;

            #region 皮肤设置
            //sr.InitSkins(skinEngine);//初始化皮肤
            //this.ForeColor = Color.FromArgb(0,0,0); 
            #endregion

            InitFormControls();//初始化窗体控件


        }

        #region 对象实例化

        SkinsRepertories sr = new SkinsRepertories();//皮肤库
        ComboBox cmbSkins = new ComboBox();//皮肤下拉框 

        #endregion

        #region 全局变量

        private int width;//窗体宽度
        private int height; //窗体高度

        #endregion

        #region 初始化窗体
        /// <summary>
        /// 初始化窗体
        /// </summary>
        /// <returns></returns>
        private bool InitFormControls()
        {
            //InitSkinList();//皮肤选择下拉框
            InitFormSizeAndLoc();//初始化窗体大小和位置
            InitFormPanel();
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
            this.Width = width;
            this.Height = height;
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
            BindingSource bs = new BindingSource();
            bs.DataSource = sr.skins;
            cmbSkins.DataSource = bs;
            cmbSkins.DisplayMember = "key";
            cmbSkins.ValueMember = "Value";
            cmbSkins.Size = new System.Drawing.Size(80, 10);
            cmbSkins.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSkins.Location = new Point(this.Width - 110, 10);
            cmbSkins.SelectedIndexChanged += new EventHandler(cmbSkinsSelChange);
            this.Controls.Add(cmbSkins);
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
            return true;
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

        #region 关闭窗体时间
        /// <summary>
        /// 关闭窗体时间
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
                    // notifyIcon.ShowBalloonTip(5000, "Hello", "I'm Emperor", ToolTipIcon.Info);
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

    }
}
