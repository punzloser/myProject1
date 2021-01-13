using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace QuanLyDiem
{
    class CircularButton : SimpleButton
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Update_Region();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Update_Region();
        }

        private void Update_Region()
        {
            Region prevRgn = Region;
            Region = new Region(CreateFormRegion(8));
            if (prevRgn != null)
                prevRgn.Dispose();
        }

        // bo góc 
        public GraphicsPath CreateFormRegion(int cornerRadius)
        {
            GraphicsPath GrpRect = new GraphicsPath();
            int width = Width + 1;
            int height = Height + 1;
            GrpRect.AddArc(new Rectangle(0, 0, cornerRadius * 2, cornerRadius * 2), 180f, 90f);//left-top
            GrpRect.AddArc(new Rectangle((width - cornerRadius * 2) - 1, 0, cornerRadius * 2, cornerRadius * 2), -90f, 90f);//right-top
            GrpRect.AddArc(new Rectangle((width - cornerRadius * 2) - 1, (height - cornerRadius * 2) - 1, cornerRadius * 2, cornerRadius * 2), 0f, 90f);//right-bottom
            GrpRect.AddArc(new Rectangle(0, (height - cornerRadius * 2) - 1, cornerRadius * 2, cornerRadius * 2), 90f, 90f);//left-bottom
            GrpRect.CloseAllFigures();
            return GrpRect;
        }
    }
}
