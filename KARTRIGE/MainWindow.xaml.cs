using KARTRIGE.ViewModels;
using KARTRIGE.Windows;
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

namespace KARTRIGE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainVM();
        }

        private void Orders(object sender, RoutedEventArgs e)
        {
            OrdersWin win = new OrdersWin();
            win.Show();
        }

        private void ListOrder(object sender, RoutedEventArgs e)
        {
            OrderList l = new OrderList();
            l.Show();
        }

        private void ListCabinets(object sender, RoutedEventArgs e)
        {
            ListCabinets l = new ListCabinets();
            l.Show();
        }

        private void CabinetAdd(object sender, RoutedEventArgs e)
        {
            CabinetEdit cab = new CabinetEdit();
            cab.Show();
        }
    }
}
