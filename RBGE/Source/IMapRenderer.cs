using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBGE.Source
{
    interface IMapRenderer
    {
        void Draw(List<string[]> tiles);
        void DrawTile(int Row, int Column, string currentTile);
        void ClearMap();
        void SayHello(string text, int x, int y);
    }
}
