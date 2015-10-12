using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace AlSkin.AlControl
{

    public class AlMenuStrip :MenuStrip
    {
        public AlMenuStrip()
        {
            this.Renderer = new AlMenuStripRenderer();
        }
    }
}
