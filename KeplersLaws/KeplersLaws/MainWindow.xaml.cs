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

namespace KeplersLaws
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Drawing Shapes
        private void DrawEllipse(Brush stroke, int height, int width, string name)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Height = height;
            ellipse.Width = width;
            ellipse.Stroke = stroke;
            ellipse.Name = name;
            RootGrid.Children.Add(ellipse);
        }
        #endregion

        private void btnSpawn_Click(object sender, RoutedEventArgs e)
        {
            DrawEllipse(Brushes.Black, 100, 200, "one");
        }
    }
}
