using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RBGE.Source;

namespace RBGE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Canvas _displayCanvas;
        private Game _rogueGame;

        public MainWindow()
        {
            InitializeComponent();
            this._displayCanvas = display;
            this._rogueGame = new Game(this._displayCanvas, this);
        }

        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            display.Height = e.NewSize.Height - 50;
            display.Width = e.NewSize.Width - 50;
            
        }
    }
}
