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
    /// Логика взаимодействия для usageRequestPage.xaml
    /// </summary>
    public partial class usageRequestPage : Page
    {
        headerItem headerItem = new headerItem();
        public usageRequestPage()
        {
            InitializeComponent();
            headerParent.Children.Add(headerItem);
            headerItem.Usage.Background = new SolidColorBrush(Color.FromRgb(74, 123, 186));
            headerItem.Report.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            headerItem.Service.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            headerItem.Usable.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            headerItem.Servicable.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));

            for(int i = 0; i < 10; i++)
            {
                useParent.Children.Add(new useItem(false));
            }
            devFreeList.Text += "\nНоутбук: 15\nVR-шлем: 7\nVR-контроллер: 17\nТрекеры движения: 13\nКлавиатуры: 5";
            devFreeCount.Text += "57";
        }

        private void toUsable(object sender, RoutedEventArgs e)
        {
            MainWindow.init.frame.Navigate(new View.usableDevices());
        }

        private void createRequest(object sender, RoutedEventArgs e)
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
            var usageWindow = new createUsageRequest();
            usageWindow.Owner = MainWindow.init;
            usageWindow.ShowDialog();
            if (App.Current.MainWindow != null)
            {
                App.Current.MainWindow.Effect = null;
            }
        }
    }
}
