using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBGE.Source
{
    class TileMap : IMap
    {
        private List<string[]> _Tiles;

        public TileMap(List<string[]> tiles)
        {
            this._Tiles = tiles;
        }

        public int GetHeight()
        {
            return this._Tiles.Count;
        }

        public int GetWidth()
        {
            return this._Tiles[0].Length;
        }

        public List<string[]> GetTiles()
        {
            return this._Tiles;
        }

        public int GetTileID(int row, int column)
        {
            return row * this.GetWidth() + column;
        }

        public string GetTileType(Geom.Point point)
        {
            return this._Tiles[point.x][point.y].ToString();
        }
        public void PickupDiamond(Geom.Point playerPosition)
        {
            this._Tiles[playerPosition.x][playerPosition.y] = "0";
            Game.GameScore = Game.GameScore + 100;
        }
        public void Die(Geom.Point playerPosition)
        {
            this._Tiles[playerPosition.x][playerPosition.y] = "1";
            Game.GameScore = Game.GameScore - 200;
        }
    }
}
