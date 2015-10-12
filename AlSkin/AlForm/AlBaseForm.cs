//作者：阿龙(Along)
//QQ号：646494711
//QQ群：57218890
//网站：http://www.8timer.com
//博客：http://www.cnblogs.com/Along729/
//声明：未经作者许可，任何人不得发布出售该源码，请尊重别人的劳动成果，谢谢大家支持
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using AlSkin.AlClass;
using System.ComponentModel.Design;

namespace AlSkin.AlForm
{
    public partial class AlBaseForm : Form
    {
        #region 声明
        private Bitmap _BacklightImg = AlSkin.Properties.Resources.AlForm;//  ImageObject.GetResBitmap("AlSkin.AlSkinImg.AlFormImg.all_inside_bkg.png");//窗体光泽背景图片
        private Rectangle _BacklightLTRB = new Rectangle(10, 80, 10, 70);//窗体光泽重绘边界
        private int _RgnRadius = 4;//设置窗口圆角
        private int Rgn;
        private Graphics g;
        private FormSystemBtn _FormSystemBtnSet = FormSystemBtn.SystemAll;
        private Bitmap btn_closeImg = AlSkin.Properties.Resources.AlForm_close;//ImageObject.GetResBitmap("AlSkin.AlSkinImg.AlFormImg.btn_close.png");
        private Bitmap btn_maxImg = AlSkin.Properties.Resources.AlForm_max;//ImageObject.GetResBitmap("AlSkin.AlSkinImg.AlFormImg.btn_max.png");
        private Bitmap btn_miniImg = AlSkin.Properties.Resources.AlForm_mini;//ImageObject.GetResBitmap("AlSkin.AlSkinImg.AlFormImg.btn_mini.png");
        private Bitmap btn_restoreImg = AlSkin.Properties.Resources.AlForm_restore;//ImageObject.GetResBitmap("AlSkin.AlSkinImg.AlFormImg.btn_restore.png");
        private Size oldSize;//记录当前窗口大小
        //枚举系统按钮状态
        public enum FormSystemBtn
        {
            SystemAll = 0,
            SystemNo = 1,
            btn_close = 2,
            btn_miniAndbtn_close = 3,
            btn_maxAndbtn_close = 4
        }
        #endregion

        #region 构造函数
        public AlBaseForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);//自绘
            this.SetStyle(ControlStyles.DoubleBuffer, true);// 双缓冲
            this.SetStyle(ControlStyles.ResizeRedraw, true);//调整大小时重绘
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);// 双缓冲
            //this.SetStyle(ControlStyles.Opaque, true);//如果为真，控件将绘制为不透明，不绘制背景
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);   //透明效果
            //设计模式下
            if (this.GetService(typeof(IDesignerHost)) != null || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                FormBorderStyle = FormBorderStyle.None;
            }

            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height); 
        }
        #endregion

        #region 属性

        [DefaultValue(4)]
        [CategoryAttribute("阿龙窗口属性"), Description("设置窗口圆角半径")]
        public int RgnRadius
        {
            get { return this._RgnRadius; }
            set
            {
                _RgnRadius = value;
                this.Invalidate();
            }

        }

        [CategoryAttribute("阿龙窗口属性"), Description("设置窗体光泽背景")]
        public Bitmap BacklightImg
        {

            get { return this._BacklightImg; }
            set
            {
                _BacklightImg = value;
                this.Invalidate();
            }
        }

        [CategoryAttribute("阿龙窗口属性"), Description("设置窗体光泽背景重绘边界，例如 10,10,10,10")]
        public Rectangle BacklightLTRB
        {

            get { return this._BacklightLTRB; }
            set
            {
                _BacklightLTRB = value;
                if (_BacklightLTRB != Rectangle.Empty)
                {
                    this.Invalidate();
                }
            }
        }

        bool _showTitle = true;
        [CategoryAttribute("阿龙窗口属性"), Description("是否显示窗体ICO图标和标题文字")]
        public bool ShowTitle
        {

            get { return _showTitle; }
            set
            {
                _showTitle = value;
            }
        }

        //[DefaultValue(true)]
        //[CategoryAttribute("阿龙窗口属性"), Description("是否允许改变窗口大小")]
        //public bool IsResize
        //{
        //    get { return this._IsResize; }
        //    set { _IsResize = value; }
        //}

        //[CategoryAttribute("阿龙窗口属性"), Description("系统按钮设置")]
        //public virtual FormSystemBtn FormSystemBtnSet
        //{
        //    get
        //    {
        //        return _FormSystemBtnSet;
        //    }
        //    set
        //    {
        //        _FormSystemBtnSet = value;
        //        this.Invalidate();

        //    }
        //}
        #endregion

        #region 重写方法
        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            SetReion();
            base.OnInvalidated(e);
        }

        //重绘窗口
        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                g = e.Graphics;
                g.SmoothingMode = SmoothingMode.HighQuality; //高质量
                g.PixelOffsetMode = PixelOffsetMode.HighQuality; //高像素偏移质量
                ImageDrawRect.DrawRect(g, _BacklightImg, ClientRectangle, Rectangle.FromLTRB(_BacklightLTRB.X, _BacklightLTRB.Y, _BacklightLTRB.Width, _BacklightLTRB.Height), 1, 1);

                if (_showTitle)
                {
                    if (this.ShowIcon && this.Text != "")
                    {
                        g.DrawIcon(this.Icon, new Rectangle(15, 12, 16, 16));
                        g.DrawString(this.Text, new Font("微软雅黑", 9F), new SolidBrush(Color.FromArgb(255, 255, 255)), 35, 12);
                    }
                    else
                    {
                        g.DrawString(this.Text, new Font("微软雅黑", 9F), new SolidBrush(Color.FromArgb(255, 255, 255)), 10, 12);
                    }
                }
            }
            catch
            { }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SystemBtnSet();
          
        }

        //重载WndProc方法
        protected override void WndProc(ref Message m)
        {
            try
            {
                switch (m.Msg)
                {
                    // 双击窗体时做相关判断（是否允许最大化或者最小化窗体？）
                    case 0xA3:
                        if (!this.MaximizeBox)
                            return;
                        break;
                    //用户选择最大化按钮，最小化按钮，复原按钮或关闭按钮时，窗口将会接收该消息
                    case Win32.WM_SYSCOMMAND:
                        #region
                        if ((m.WParam != (IntPtr)Win32.SC_MAXIMIZE) && (m.WParam.ToInt32() != 0xf032))
                        {
                            if ((m.WParam == (IntPtr)Win32.SC_RESTORE) || (m.WParam.ToInt32() == 0xf122))
                            {
                                base.Size = this.oldSize;
                            }
                            else if ((m.WParam == (IntPtr)Win32.SC_MINIMIZE) || (m.WParam.ToInt32() == 0xf022))
                            {
                                if (this.oldSize.Width == 0)
                                {
                                    this.oldSize = base.Size;
                                }
                            }
                            break;
                        }
                        this.oldSize = base.Size;
                        #endregion
                        break;
                    //在需要计算窗口客户区的大小和位置时发送。通过处理这个消息，应用程序可以在窗口大小或位置改变时控制客户区的内容
                    case Win32.WM_NCCALCSIZE:
                    //窗体客户区以外的重绘消息,一般是由系统负责处理
                    case Win32.WM_NCPAINT:
                        return;
                    //鼠标移动,按下或释放都会执行该消息
                    case Win32.WM_NCHITTEST:
                        WM_NCHITTEST(ref m);
                        return;
                    //画窗体被激活或者没有被激活时的样子//http://blog.csdn.net/commandos/archive/2007/11/27/1904558.aspx
                    case Win32.WM_NCACTIVATE:
                        #region
                        if (m.WParam == (IntPtr)Win32.WM_FALSE)
                        {
                            m.Result = (IntPtr)Win32.WM_TRUE;
                        }
                        if (m.WParam == (IntPtr)2097152)
                        {
                            m.Result = (IntPtr)1;
                        }
                        #endregion
                        return;
                    default:
                        base.WndProc(ref m);
                        return;
                }
                base.WndProc(ref m);
            }
            catch { }
        }

        private void AlBaseForm_Resize(object sender, EventArgs e)
        {
            SystemBtnSet();
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            this.oldSize = base.Size;
        }

        #endregion

        #region 方法
        protected void SystemBtnSet()
        {
            if (this.MaximizeBox && this.MinimizeBox)
                _FormSystemBtnSet = FormSystemBtn.SystemAll;
            else if (this.MaximizeBox && !this.MinimizeBox)
                _FormSystemBtnSet = FormSystemBtn.btn_maxAndbtn_close;
            else if (!this.MaximizeBox && this.MinimizeBox)
                _FormSystemBtnSet = FormSystemBtn.btn_miniAndbtn_close;
            else if (!this.MaximizeBox && !this.MinimizeBox)
                _FormSystemBtnSet = FormSystemBtn.btn_close;
            else
                _FormSystemBtnSet = FormSystemBtn.SystemNo;

            switch ((int)_FormSystemBtnSet)
            {
                case 0:
                    btn_close.BackgroundImage = btn_closeImg;
                    btn_close.Location = new Point(this.Width - 43, 5);
                    btn_mini.BackgroundImage = btn_miniImg;
                    btn_mini.Location = new Point(this.Width - 93, 5);
                    btn_max.BackgroundImage = btn_maxImg;
                    btn_restore.BackgroundImage = btn_restoreImg;
                    if (WindowState == FormWindowState.Normal)
                    {
                        btn_max.Location = new Point(this.Width - 68, 5);
                        btn_restore.Location = new Point(this.Width - 68, -19);
                    }
                    else
                    {
                        btn_max.Location = new Point(this.Width - 68, -19);
                        btn_restore.Location = new Point(this.Width - 68, 5);
                    }
                    break;
                case 1:
                    btn_close.BackgroundImage = btn_closeImg;
                    btn_close.Location = new Point(this.Width - 43, -19);
                    btn_max.BackgroundImage = btn_maxImg;
                    btn_max.Location = new Point(this.Width - 68, -19);
                    btn_mini.BackgroundImage = btn_miniImg;
                    btn_mini.Location = new Point(this.Width - 93, -19);
                    btn_restore.BackgroundImage = btn_restoreImg;
                    btn_restore.Location = new Point(this.Width - 68, -19);
                    break;
                case 2:
                    btn_close.BackgroundImage = btn_closeImg;
                    btn_close.Location = new Point(this.Width - 43, 5);
                    btn_max.BackgroundImage = btn_maxImg;
                    btn_max.Location = new Point(this.Width - 68, -19);
                    btn_mini.BackgroundImage = btn_miniImg;
                    btn_mini.Location = new Point(this.Width - 93, -19);
                    btn_restore.BackgroundImage = btn_restoreImg;
                    btn_restore.Location = new Point(this.Width - 68, -19);
                    break;
                case 3:
                    btn_close.BackgroundImage = btn_closeImg;
                    btn_close.Location = new Point(this.Width - 43, 5);
                    btn_max.BackgroundImage = btn_maxImg;
                    btn_max.Location = new Point(this.Width - 68, -19);
                    btn_mini.BackgroundImage = btn_miniImg;
                    btn_mini.Location = new Point(this.Width - 68, 5);
                    btn_restore.BackgroundImage = btn_restoreImg;
                    btn_restore.Location = new Point(this.Width - 68, -19);
                    break;
                case 4:
                    btn_close.BackgroundImage = btn_closeImg;
                    btn_close.Location = new Point(this.Width - 43, 5);
                    btn_mini.BackgroundImage = btn_miniImg;
                    btn_mini.Location = new Point(this.Width - 93, -19);
                    btn_max.BackgroundImage = btn_maxImg;
                    btn_restore.BackgroundImage = btn_restoreImg;
                    if (WindowState == FormWindowState.Normal)
                    {
                        btn_max.Location = new Point(this.Width - 68, 5);
                        btn_restore.Location = new Point(this.Width - 68, -19);
                    }
                    else
                    {
                        btn_max.Location = new Point(this.Width - 68, -19);
                        btn_restore.Location = new Point(this.Width - 68, 5);
                    }
                    break;

            }

        }
        /// <summary>
        /// 给窗口圆角
        /// </summary>
        protected void SetReion()
        {
            Rgn = Win32.CreateRoundRectRgn(5, 5, ClientRectangle.Width - 4, ClientRectangle.Height - 4, _RgnRadius, _RgnRadius);
            Win32.SetWindowRgn(this.Handle, Rgn, true);
        }

        // 处理拖动窗体时，是否允许最大化或者最小化的判断
        private void WM_NCHITTEST(ref Message m)
        {
            int wparam = m.LParam.ToInt32();
            Point point = new Point(Win32.LOWORD(wparam), Win32.HIWORD(wparam));
            point = PointToClient(point);
            /*
             *此段代码的用处是：对于MaximizeBox为True的窗口，可以通过拉动窗体边缘缩放窗体
             *此处将此段代码屏蔽，让所有的窗体都不能随意缩放 
             */
            //if (this.MaximizeBox)
            //{
            //    if (point.X <= 8)
            //    {
            //        if (point.Y <= 8)
            //            m.Result = (IntPtr)Win32.HTTOPLEFT;
            //        else if (point.Y > Height - 8)
            //            m.Result = (IntPtr)Win32.HTBOTTOMLEFT;
            //        else
            //            m.Result = (IntPtr)Win32.HTLEFT;
            //    }
            //    else if (point.X >= Width - 8)
            //    {
            //        if (point.Y <= 8)
            //            m.Result = (IntPtr)Win32.HTTOPRIGHT;
            //        else if (point.Y >= Height - 8)
            //            m.Result = (IntPtr)Win32.HTBOTTOMRIGHT;
            //        else
            //            m.Result = (IntPtr)Win32.HTRIGHT;
            //    }
            //    else if (point.Y <= 8)
            //    {
            //        m.Result = (IntPtr)Win32.HTTOP;
            //    }
            //    else if (point.Y >= Height - 8)
            //        m.Result = (IntPtr)Win32.HTBOTTOM;
            //    else
            //        m.Result = (IntPtr)Win32.HTCAPTION;
            //}
            //else
            //{ m.Result = (IntPtr)Win32.HTCAPTION; }
            m.Result = (IntPtr)Win32.HTCAPTION;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            Win32.PostMessage(base.Handle, Win32.WM_SYSCOMMAND, Win32.SC_MINIMIZE, 0);
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            Win32.PostMessage(base.Handle, Win32.WM_SYSCOMMAND, Win32.SC_MAXIMIZE, 0);
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            Win32.PostMessage(base.Handle, Win32.WM_SYSCOMMAND, Win32.SC_RESTORE, 0);
        }

        private void btn_close_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_close, "关闭");
        }

        private void btn_max_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_max, "最大化");
        }

        private void btn_mini_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_mini, "最小化");
        }

        private void btn_restore_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_restore, "还原");
        }
        #endregion
    }
}
