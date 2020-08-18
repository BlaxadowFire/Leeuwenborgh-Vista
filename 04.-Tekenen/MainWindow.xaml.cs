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
using System.Threading;

namespace _04._Tekenen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int IntCountClick = 0;
        public static Line ManualLine = new Line
            {
                Height = 300,
                Width = 300,
                Fill = Brushes.AliceBlue,
                Stroke = Brushes.Red,
                StrokeThickness = 5
            };
        
        public MainWindow()
        {
            InitializeComponent();
            Thread thread = new Thread(CrossHair);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            canvas.Children.Add(ManualLine);
        }

        public void MousePosition()
        {
            while (true)
            {
                Thread.Sleep(TimeSpan.FromSeconds(0.1));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    lblMousePosition.Content = Mouse.GetPosition(MainWin).ToString();

                }));
            }
        }
        public void CrossHair()
        {
            while (true)
            {
                Thread.Sleep(10);
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    lblMousePosition.Content = Mouse.GetPosition(MainWin).ToString();
                    Line linex = new Line
                    {
                        X1 = (Mouse.GetPosition(MainWin).X - 10),
                        Y1 = (Mouse.GetPosition(MainWin).Y),
                        X2 = (Mouse.GetPosition(MainWin).X + 10),
                        Y2 = (Mouse.GetPosition(MainWin).Y),
                        StrokeThickness = 2,
                        Stroke = Brushes.Red

                    };
                    Line liney = new Line
                    {
                        X1 = (Mouse.GetPosition(MainWin).X),
                        Y1 = (Mouse.GetPosition(MainWin).Y - 10),
                        X2 = (Mouse.GetPosition(MainWin).X),
                        Y2 = (Mouse.GetPosition(MainWin).Y + 10),
                        StrokeThickness = 2,
                        Stroke = Brushes.Blue
                    };
                    CrosshairOverlay.Children.Clear();
                    CrosshairOverlay.Children.Add(linex);
                    CrosshairOverlay.Children.Add(liney);
                }));
            }
        }
        public void DrawLine(object sender, RoutedEventArgs e)
        {
            Line line = new Line
            {
                X1 = 10,
                Y1 = 10,
                X2 = 150,
                Y2 = 150,
                Height = 300,
                Width = 300,
                Fill = Brushes.AliceBlue,
                Stroke = Brushes.Red,
                StrokeThickness = 5
            };
            MainGrid.Children.Add(line);
        }
        public void DrawRectangle(object sender, RoutedEventArgs e)
        {
            Rectangle rectangle = new Rectangle
            {
                Height = 300,
                Width = 300,
                Fill = Brushes.AliceBlue,
                Stroke = Brushes.Red,
                StrokeThickness = 5
            };
            MainGrid.Children.Add(rectangle);
        }
        public void DrawEllipse(object sender, RoutedEventArgs e)
        {
            Ellipse ellipse = new Ellipse
            {
                Height = 300,
                Width = 300,
                Fill = Brushes.AliceBlue,
                Stroke = Brushes.Red,
                StrokeThickness = 5
            };
            MainGrid.Children.Add(ellipse);
        }
        public void ManualDrawClick(object sender, RoutedEventArgs e)
        {
            if (IntCountClick == 0)
            {
                ManualLine.X1 = Mouse.GetPosition(MainWin).X;
                ManualLine.Y1 = Mouse.GetPosition(MainWin).Y;
                IntCountClick++;
            }
            else
            {
                ManualLine.X2 = Mouse.GetPosition(MainWin).X;
                ManualLine.Y2 = Mouse.GetPosition(MainWin).Y;
                IntCountClick = 0;
            }
        }
    }
}
