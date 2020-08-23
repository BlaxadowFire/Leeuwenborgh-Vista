using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBGE.Source
{
    class Directions
    {
        public static readonly Geom.Point NONE = new Geom.Point(0, 0);
        public static readonly Geom.Point UP = new Geom.Point(-1, 0);
        public static readonly Geom.Point DOWN = new Geom.Point(1, 0);
        public static readonly Geom.Point LEFT = new Geom.Point(0, -1);
        public static readonly Geom.Point RIGHT = new Geom.Point(0, 1);
    }
}
