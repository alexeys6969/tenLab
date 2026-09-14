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

namespace tenLabPractice.Items
{
    /// <summary>
    /// Логика взаимодействия для useItem.xaml
    /// </summary>
    public partial class useItem : UserControl
    {
        public useItem(bool fullRequest)
        {
            InitializeComponent();
            if (!fullRequest)
            {
                employee.Visibility = Visibility.Collapsed;
                dateFrom.Visibility = Visibility.Collapsed;
                grid.ColumnDefinitions[1].Width = new GridLength(0);
                grid.ColumnDefinitions[4].Width = new GridLength(0);
            }
        }
    }
}
