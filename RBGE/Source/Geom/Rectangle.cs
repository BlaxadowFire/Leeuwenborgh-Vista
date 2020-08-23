using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBGE.Source.Geom
{
    class Rectangle : Point
    {
        public int width;
        public int height;

        public Rectangle(int x, int y, int width = 0, int height = 0)
        {
            base.x = x;
            base.y = y;

            this.width = width;
            this.height = height;
        }
    }
}
