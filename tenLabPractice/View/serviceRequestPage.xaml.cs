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
using tenLabPractice.Window;

namespace tenLabPractice.View
{
    /// <summary>
    /// Логика взаимодействия для serviceRequestPage.xaml
    /// </summary>
    public partial class serviceRequestPage : Page
    {
        headerItem headerItem = new headerItem();
        public serviceRequestPage()
        {
            InitializeComponent();
            headerParent.Children.Add(headerItem);
            headerItem.Service.Background = new SolidColorBrush(Color.FromRgb(74, 123, 186));
            headerItem.Usage.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            headerItem.Report.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            headerItem.Usable.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            headerItem.Servicable.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            for (int i = 0; i < 10; i++)
            {
                serviceParent.Children.Add(new serviceItem(true));
            }
            devServiceList.Text += "\nНоутбук: 3\nVR-шлем: 2\nVR-контроллер: 4\nТрекеры движения: 2\nКлавиатуры: 1";
            devServiceCount.Text += "12";
        }

        private void toServicable(object sender, RoutedEventArgs e)
        {
            MainWindow.init.frame.Navigate(new View.servicableDevices());
        }

        private void CreateServiceRequest(object sender, RoutedEventArgs e)
        {
            {
                var blurEffect = new System.Windows.Media.Effects.BlurEffect
                {
                    Radius = 15,
                    KernelType = System.Windows.Media.Effects.KernelType.Gaussian
                };
                if (App.Current.MainWindow != null)
                {
                    App.Current.MainWindow.Effect = blurEffect;
                }
                var serviceWindow = new createServiceReuqest();
                serviceWindow.Owner = MainWindow.init;
                serviceWindow.ShowDialog();
                if (App.Current.MainWindow != null)
                {
                    App.Current.MainWindow.Effect = null;
                }
            }
        }
    }
}
