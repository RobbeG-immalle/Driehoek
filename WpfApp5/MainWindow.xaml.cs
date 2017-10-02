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

namespace WpfApp5
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Line lijn = new Line();
            lijn.X1 = 10;
            lijn.Y1 = 10;
            lijn.X2 = 10;
            lijn.Y2 = 210;

            lijn.Stroke = new SolidColorBrush(Colors.AliceBlue);
            mijnCanvas.Children.Add(lijn);


            Line lijn2 = new Line();
            lijn2.X1 = 10;
            lijn2.Y1 = 210;
            lijn2.X2 = 210;
            lijn2.Y2 = 100;

            lijn2.Stroke = new SolidColorBrush(Colors.Aqua);
            mijnCanvas.Children.Add(lijn2);

            Line lijn3 = new Line();
            lijn3.X1 = 210;
            lijn3.Y1 = 100;
            lijn3.X2 = 10;
            lijn3.Y2 = 10;

            lijn3.Stroke = new SolidColorBrush(Colors.Chocolate);
            mijnCanvas.Children.Add(lijn3);


        }
    }
}
