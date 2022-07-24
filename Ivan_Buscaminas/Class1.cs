using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ivan_Buscaminas
{
    class boton : Button
    {


        /*  private Color borderColor = Color.Salmon;

          public Color BorderColor
          {
              get { return borderColor; }
              set { borderColor = value;
                  this.Invalidate();
              }
          }
          GraphicsPath GetRoundPath(RectangleF Rect, int radius)
          {
              float r2 = radius / 2f;
              GraphicsPath GraphPath = new GraphicsPath();
              GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
              GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
              GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
              GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
              GraphPath.AddArc(Rect.X + Rect.Width - radius,
                               Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
              GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
              GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
              GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
              GraphPath.CloseFigure();
              return GraphPath;
          }
          protected override void OnPaint(PaintEventArgs p)
          {
              base.OnPaint(p);
              Rectangle Rect = new Rectangle(0, 0, this.Width, this.Height);
              GraphicsPath GraphPath = new GraphicsPath();
              GraphPath.AddArc(Rect.X, Rect.Y, 50, 50, 180, 90);
              GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y, 50, 50, 270, 90);
              GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y + Rect.Height - 50, 50, 50, 0, 90);
              GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - 50, 50, 50, 90, 90);
              this.Region = new Region(GraphPath);
          }
        */
    }
}
