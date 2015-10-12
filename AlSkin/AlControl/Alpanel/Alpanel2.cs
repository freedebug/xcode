using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using AlSkin.AlClass;
using System.Drawing;
using System.ComponentModel;

namespace AlSkin.AlControl
{

    public class Alpanel2 :Panel
    {
        public Bitmap _BackImg = AlSkin.Properties.Resources.AlPanel2;// ImageObject.GetResBitmap("AlSkin.AlControl.Alpanel.Manright.png");
        public Alpanel2()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.StandardDoubleClick, false);
            this.SetStyle(ControlStyles.Selectable, true);      
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rc = this.ClientRectangle;
            Graphics g = e.Graphics;
            ImageDrawRect.DrawRect(g, _BackImg, rc, Rectangle.FromLTRB(10, 50, 10, 30), 1, 1);
        }
        #region 释放资源
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _BackImg.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion
    }
}
