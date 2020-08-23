using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using RBGE.Source.Geom;
using System.Windows;
using System.Windows.Media.Imaging;

namespace RBGE.Source
{
    class CanvasMapRenderer : IMapRenderer
    {
        private Canvas _targetCanvas;
        private Rectangle _tileRect;

        public CanvasMapRenderer(Canvas canvas,Rectangle tileRect)
        {
            this._targetCanvas = canvas;
            this._tileRect = tileRect;
        }

        public void ClearMap()
        {
            //_targetCanvas.Children.Clear();
        }

        public void Draw(List<string[]> tiles)
        {
            this.ClearMap();
            this.DrawBanner();

            int row = 0;
            int column = 0;
            int total = tiles.Count;
            int rowWidth = tiles[0].Length;
            string currentTile = string.Empty;

            for (row = 0; row < total; row++)
            {
                for (column = 0; column < rowWidth; column++)
                {
                    currentTile = tiles[row][column].ToString();
                    this.DrawTile(row, column, currentTile);
                }
            }
            this.DrawInfo();
        }

        public void DrawTile(int Row, int Column, string currentTile)
        {
            this._tileRect.x = Column * this._tileRect.width;
            this._tileRect.y = Row * this._tileRect.height;

            System.Windows.Shapes.Rectangle rect;
            rect = new System.Windows.Shapes.Rectangle
            {
                Stroke = new SolidColorBrush(Colors.Black),
                Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom(this.TileColor(currentTile))),
                Width = this._tileRect.width,
                Height = this._tileRect.height,
                StrokeThickness = 1
            };
            Canvas.SetLeft(rect, this._tileRect.x);
            Canvas.SetTop(rect, this._tileRect.y);

            this._targetCanvas.Children.Add(rect);
        }

        public string TileColor(string value)
        {
            string color;
            switch (value)
            {
                case "0":
                    color = "#ffffff";
                    break;
                case "1":
                    color = "#333333";
                    break;
                case "2":
                    color = "#0094FF";
                    break;
                case "3":
                    color = "#ff0000";
                    break;
                case "4":
                    color = "#FAFF00";
                    break;
                case "5":
                    color = "#00ff00";
                    break;
                default:
                    color = "#333333";
                    break;
            }
            return color;
        }

        public void SayHello(string text, int x, int y)
        {
            throw new NotImplementedException();
        }

        public void DrawInfo()
        {
            TextBlock Score = new TextBlock
            {
                Text = "Score: " + Game.GameScore.ToString(),
                Foreground = Brushes.AntiqueWhite,
                Margin = new Thickness(3, 10, 0, 0),
            };
            TextBlock Life = new TextBlock
            {
                Text = "Life: " + Game.PlayerLives.ToString(),
                Margin = new Thickness(70, 10, 0, 0),
                Foreground = Brushes.AntiqueWhite,
            };
            this._targetCanvas.Children.Add(Score);
            this._targetCanvas.Children.Add(Life);
        }

        public void DrawBanner()
        {

            Image imgBanner = new Image
            {
                Source = new BitmapImage(new Uri("Assets/banner.png", UriKind.Relative)),
                VerticalAlignment = VerticalAlignment.Bottom,
                Width = 800,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(0, 460, 0, 0)
            };
            this._targetCanvas.Children.Add(imgBanner);
        }
    }
}
