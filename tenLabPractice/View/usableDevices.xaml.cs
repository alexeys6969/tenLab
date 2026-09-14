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
using tenLabPractice.Items;

namespace tenLabPractice.View
{
    /// <summary>
    /// Логика взаимодействия для usableDevices.xaml
    /// </summary>
    public partial class usableDevices : Page
    {
        headerItem headerItem = new headerItem();
        public usableDevices()
        {
            InitializeComponent();
            headerParent.Children.Add(headerItem);
            headerItem.Usable.Background = new SolidColorBrush(Color.FromRgb(74, 123, 186));
            headerItem.Report.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            headerItem.Service.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            headerItem.Usage.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            headerItem.Servicable.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));

            for (int i = 0; i < 10; i++)
            {
                useParent.Children.Add(new useItem(true));
            }
        }
    }
}
