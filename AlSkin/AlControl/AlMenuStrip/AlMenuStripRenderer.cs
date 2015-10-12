//作者：阿龙(Along)
//QQ号：646494711
//QQ群：57218890
//网站：http://www.8timer.com
//博客：http://www.cnblogs.com/Along729/
//声明：未经作者许可，任何人不得发布出售该源码，请尊重别人的劳动成果，谢谢大家支持
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using AlSkin.AlClass;

namespace AlSkin.AlControl
{
    public class AlMenuStripRenderer  : ToolStripRenderer
    {
        private Bitmap _TopBgImg =  AlSkin.Properties.Resources.AlMenuStrip_Tbg;// ImageObject.GetResBitmap("AlSkin.AlControl.AlMenuStrip.Tbg.png");
        private Bitmap _TSDbgImg = AlSkin.Properties.Resources.AlMenuStrip_TSDbg;//ImageObject.GetResBitmap("AlSkin.AlControl.AlMenuStrip.TSDbg.png");
        private Bitmap _MbgImg = AlSkin.Properties.Resources.AlMenuStrip_Mbg;//ImageObject.GetResBitmap("AlSkin.AlControl.AlMenuStrip.Mbg.jpg");
        private Bitmap _Sepebg = AlSkin.Properties.Resources.AlMenuStrip_Sepebg;//ImageObject.GetResBitmap("AlSkin.AlControl.AlMenuStrip.Sepebg.png");
        public AlMenuStripRenderer()
            : base()
        {
            
        }
        protected override void OnRenderToolStripBackground(
            ToolStripRenderEventArgs e)
        {
            ToolStrip toolStrip = e.ToolStrip;
            // 如果设置了背景透明，则不再绘制背景
            if (toolStrip.BackColor == Color.Transparent)
                return;

            Graphics g = e.Graphics;
            Rectangle bounds = e.AffectedBounds;

            if (toolStrip is ToolStripDropDown)
            {
                ImageDrawRect.DrawRect(g, _TSDbgImg, bounds, Rectangle.FromLTRB(30, 3, 3, 3), 1, 1);
            }
            else if (toolStrip is MenuStrip)
            {
                
                ImageDrawRect.DrawRect(g, _TopBgImg, bounds, Rectangle.FromLTRB(1, 1, 1, 2), 1, 1);
            }
            else
            {
                base.OnRenderToolStripBackground(e);
            }
        }

        protected override void OnRenderMenuItemBackground(
   ToolStripItemRenderEventArgs e)
        {
            ToolStrip toolStrip = e.ToolStrip;
            ToolStripItem item = e.Item;

            if (!item.Enabled)
            {
                return;
            }

            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);

            if (toolStrip is MenuStrip)
            {
                LinearGradientMode mode =
                    toolStrip.Orientation == Orientation.Horizontal ?
                    LinearGradientMode.Vertical : LinearGradientMode.Horizontal;
                if (item.Selected)
                {
                    ImageDrawRect.DrawRect(g, _MbgImg, rect, Rectangle.FromLTRB(1, 1, 1, 1), 1, 1);
                }
                else if (item.Pressed)
                {
                    ImageDrawRect.DrawRect(g, _MbgImg, rect, Rectangle.FromLTRB(1, 1, 1, 1), 1, 1);
                }
                else
                {
                    base.OnRenderMenuItemBackground(e);
                }
            }
            else if (toolStrip is ToolStripDropDown)
            {
                rect.X += 29;
                rect.Width -= 30;

                if (item.Selected)
                {
                    ImageDrawRect.DrawRect(g, _MbgImg, rect, Rectangle.FromLTRB(3, 3, 3, 3), 1, 1);
                }
                else
                {
                    base.OnRenderMenuItemBackground(e);
                }
            }
        }

        protected override void OnRenderSeparator(
    ToolStripSeparatorRenderEventArgs e)
        {
            ToolStrip toolStrip = e.ToolStrip;
            Rectangle rect = e.Item.ContentRectangle;
            Graphics g = e.Graphics;
            rect.X += 25;
            rect.Width -= 26;   
            if (toolStrip is ToolStripDropDown)
            {
                ImageDrawRect.DrawRect(g, _Sepebg, rect, Rectangle.FromLTRB(2, 0, 30, 0), 1, 1); 
                
            }
        }
    }
}
