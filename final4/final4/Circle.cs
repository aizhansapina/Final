using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace final4
{
    class Circle
    {
        public Circle(int x, int y)
        {
            GraphicsPath path = new GraphicsPath();

            Point[] point =
                {
                new Point(x,y),
                new Point(x + 20, y),
                new Point(x + 20, y - 10),
                new Point(x, y - 10)

            };

            path.AddPolygon(point);
        }
    }
}
