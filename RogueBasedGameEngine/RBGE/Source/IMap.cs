using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBGE.Source
{
    interface IMap
    {
        int GetWidth();
        int GetHeight();
        List<string[]> GetTiles();
        string GetTileType(Geom.Point point);
        void PickupDiamond(Geom.Point playerPosition);
        void Die(Geom.Point playerPosition);
    }
}
