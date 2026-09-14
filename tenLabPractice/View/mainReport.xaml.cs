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

namespace tenLabPractice.Pages
{
    /// <summary>
    /// Логика взаимодействия для mainReport.xaml
    /// </summary>
    public partial class mainReport : Page
    {
        headerItem headerItem = new headerItem();
        public mainReport()
        {
            InitializeComponent();
            headerParent.Children.Add(headerItem);
            headerItem.Report.Background = new SolidColorBrush(Color.FromRgb(74, 123, 186));
            headerItem.Usage.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            headerItem.Service.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            headerItem.Usable.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            headerItem.Servicable.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));

            for (int i = 0; i < 10; i++)
            {
                serviceParent.Children.Add(new serviceItem(false));
            }
            devUseList.Text += "\nНоутбуков: 10\nVR-шлем: 5\nVR-контроллер: 15\nТрекеры движения: 10\nКлавиатуры: 5";
            devServiceList.Text += "\nНоутбук: 1\nVR-шлем: 2\nVR-контроллер: 5\nТрекеры движения: 5\nКлавиатуры: 3";
            devUseCount.Text += "45";
            devServiceCount.Text += "16";
        }

        private void toUsableDevice(object sender, RoutedEventArgs e)
        {
            MainWindow.init.frame.Navigate(new View.usableDevices());
        }

        private void toServicableDevice(object sender, RoutedEventArgs e)
        {
            MainWindow.init.frame.Navigate(new View.servicableDevices());
        }
    }
}
