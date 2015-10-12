using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace AlSkin.AlControl
{
    public class AlToolStrip : ToolStrip
    {
        public AlToolStrip()
        {
            this.Renderer = new AlToolStripRenderer();
        }
    }
}
