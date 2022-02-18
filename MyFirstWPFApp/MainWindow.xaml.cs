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

namespace MyFirstWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button myButton = new Button();
            myButton.Content = "Кнопка";
            myButton.Width = 120;
            myButton.Height = 40;
            myButton.HorizontalAlignment = HorizontalAlignment.Center;
            myButton.Background = new SolidColorBrush(Colors.Red);
            layoutGrid.Children.Add(myButton);
        }
    }
}
