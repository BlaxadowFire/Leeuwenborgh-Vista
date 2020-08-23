using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBGE.Source.Geom
{
    class Point
    {
        public int x;
        public int y;

        public Point(int x=0, int y=0)
        {
            this.x = x;
            this.y = y;
        }
        public Point Clone()
        {
            return (new Point(this.x, this.y));
        }
    }
}
