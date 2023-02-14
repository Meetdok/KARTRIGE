using KARTRIGE.ViewModels;
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
using System.Windows.Shapes;

namespace KARTRIGE.Windows
{
    /// <summary>
    /// Логика взаимодействия для CabinetEdit.xaml
    /// </summary>
    public partial class CabinetEdit : Window
    {
        public CabinetEdit()
        {
            InitializeComponent();
            DataContext = new CabinetEditVM();
        }
    }
}
