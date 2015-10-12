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
using System.ComponentModel;

namespace AlSkin.AlControl
{

   public class AlContextMenuStrip
        : ContextMenuStrip
    {
        public AlContextMenuStrip()
            : base()
        {
            this.Renderer = new AlMenuStripRenderer();
        }
   }
}
