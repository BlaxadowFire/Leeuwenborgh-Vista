using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Additional namespaces
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace RBGE.Source
{
    class Game
    {
        private Canvas _DisplayCanvas;
        private bool _Invalid;
        private IMapRenderer _MapRenderer;
        private IMap _Map;
        private Input _Input;
        private Geom.Point _PlayerPosition;
        public int GameLevel;
        public static int GameScore;
        public static int PlayerLives;
        private Http.Request _httpRequest;
        private List<string[]> _Tiles;
        public DispatcherTimer Timer = new DispatcherTimer();

        public Game(Canvas displayCanvas, Window applicationwindow)
        {
            GameLevel = 1;
            GameScore = 0;
            PlayerLives = 3;
            /*
            this._Tiles = new string[][]{
                new string []{"1", "1" , "1" , "1" , "1" , "1" , "1" , "1" , "1" },
                new string []{"1", "0" , "0" , "0" , "0" , "0" , "0" , "0" , "1" },
                new string []{"1", "0" , "0" , "0" , "0" , "0" , "0" , "0" , "1" },
                new string []{"1", "0" , "0" , "0" , "0" , "0" , "0" , "0" , "1" },
                new string []{"1", "1" , "1" , "1" , "1" , "1" , "1" , "1" , "1" }};*/
            LoadLevel();
            this._DisplayCanvas = displayCanvas;
            this._MapRenderer = new CanvasMapRenderer(this._DisplayCanvas, new Geom.Rectangle(0, 0, 88, 88));
            this._Input = new Input(applicationwindow, _MapRenderer);

            this._Invalid = true;

            this._PlayerPosition = new Geom.Point(1, 1);

            Timer.Interval = new TimeSpan(0, 0, 0, 0, 24);
            Timer.Tick += new EventHandler(Update);
            Timer.Start();
        }
        public void Update(object sender, EventArgs e)
        {
            if (this._Input.NewDirection != Directions.NONE)
            {
                this.Move(this._Input.NewDirection);
                this._Input.Clear();
            }

            if(this._Invalid)
            {
                this._DisplayCanvas.Children.Clear();
                this.Draw();
            }
        }
        public void Move(Geom.Point newDirection)
        {
            Geom.Point tmpPoint = this._PlayerPosition.Clone();

            tmpPoint.x += newDirection.x;
            tmpPoint.y += newDirection.y;

            string tile = this._Map.GetTileType(tmpPoint);

            switch (tile)
            {
                case "0":
                    this._PlayerPosition = tmpPoint;
                    this._Invalid = true;
                    break;
                case "2":
                    this._PlayerPosition = tmpPoint;
                    this._Invalid = true;
                    this._Map.PickupDiamond(this._PlayerPosition);
                    break;
                case "3":
                    this._PlayerPosition = tmpPoint;
                    this._Invalid = true;
                    this._Map.Die(this._PlayerPosition);
                    EnemyHit();
                    Relocate(new Geom.Point(1,1));
                    break;
                case "4":
                    this._PlayerPosition = tmpPoint;
                    this._Invalid = true;
                    GameLevel++;
                    LoadLevel();
                    break;
                case "5":
                    this._PlayerPosition = tmpPoint;
                    this._Invalid = true;
                    break;
                case "6":
                    this._PlayerPosition = tmpPoint;
                    this._Invalid = true;
                    break;
            }
            
        }
        public void Draw()
        {
            this._Invalid = false;
            this._Map = new TileMap(this._Tiles);
            this._MapRenderer.Draw(this._Map.GetTiles());
            this._MapRenderer.DrawTile(this._PlayerPosition.x, this._PlayerPosition.y, "5");
        }

        public void LoadLevel()
        {
            if (!Http.Request.UrlExist("http://blaxadowfire.ddns.net/A14M/levels/level" + GameLevel + ".json"))
            {
                GameLevel = 1;
            }
            this._httpRequest = new Http.Request("http://blaxadowfire.ddns.net/A14M/levels/level" + GameLevel + ".json");
            this._Tiles = this._httpRequest.Response();
            Relocate(new Geom.Point(1, 1));
        }
        public void EnemyHit()
        {
            if (PlayerLives > 0)
            {
                PlayerLives--;
            }
            if (PlayerLives == 0)
            {
                GameOver();
            }
        }
        public void GameOver()
        {
            MessageBox.Show("You dead boi");
            PlayerLives = 3;
            GameScore = 0;
            GameLevel = 1;
            LoadLevel();
        }
        public void Relocate(Geom.Point location){
            _PlayerPosition = location;
        }

        public void Resize()
        {
            
        }
    }
}
