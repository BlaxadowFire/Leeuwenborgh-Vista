using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Media;

namespace RBGE.Source
{
    class Input
    {
        private Window _ApplicationWindow;
        private IMapRenderer _MapRenderer;
        public Geom.Point NewDirection;


        public Input(Window applicationWindow, IMapRenderer maprenderer)
        {
            this._ApplicationWindow = applicationWindow;
            this._MapRenderer = maprenderer;
            this._ApplicationWindow.KeyDown += new KeyEventHandler(OnKeyButtonDown);
            this.NewDirection = Directions.NONE;
        }
        public void OnKeyButtonDown(object sender, KeyEventArgs e)
        {
            var keyCode = e.Key.ToString();
            var direction = string.Empty;
            
            switch (keyCode)
            {
                case "Up":
                    this.NewDirection = Directions.UP;
                    break;
                case "Down":
                    this.NewDirection = Directions.DOWN;
                    break;
                case "Left":
                    this.NewDirection = Directions.LEFT;
                    break;
                case "Right":
                    this.NewDirection = Directions.RIGHT;
                    break;
                default:
                    this.NewDirection = Directions.NONE;
                    break;
            }
        }
        public void Clear()
        {
            this.NewDirection = Directions.NONE;
        }
    }
}
