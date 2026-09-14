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
using tenLabPractice.Pages;
using tenLabPractice.View;

namespace tenLabPractice.Items
{
    /// <summary>
    /// Логика взаимодействия для headerItem.xaml
    /// </summary>
    public partial class headerItem : UserControl
    {
        private Point _startPoint;
        private double _startHorizontalOffset;
        private bool _isDragging;
        public headerItem()
        {
            InitializeComponent();
        }
        private void ReportClick(object sender, RoutedEventArgs e)
        {
            MainWindow.init.frame.Navigate(new mainReport());
        }

        private void UsageClick(object sender, RoutedEventArgs e)
        {
            MainWindow.init.frame.Navigate(new usageRequestPage());
        }

        private void ServiceClick(object sender, RoutedEventArgs e)
        {
            MainWindow.init.frame.Navigate(new serviceRequestPage());
        }

        private void UsableClick(object sender, RoutedEventArgs e)
        {
            MainWindow.init.frame.Navigate(new usableDevices());
        }

        private void ServicableClick(object sender, RoutedEventArgs e)
        {
            MainWindow.init.frame.Navigate(new servicableDevices());
        }

        private void ScrollViewer_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            _startPoint = e.GetPosition(menuContainer);
            _startHorizontalOffset = menuContainer.HorizontalOffset;
            _isDragging = false;
        }

        private void ScrollViewer_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton != MouseButtonState.Pressed) return;

            Point currentPoint = e.GetPosition(menuContainer);

            // Вычисляем, насколько сдвинулась мышь от точки старта
            double deltaX = currentPoint.X - _startPoint.X;

            // Включаем режим скролла только если мышь сдвинулась больше чем на 4 пикселя
            // Это защитит от случайных микродвижений при обычном клике
            if (!_isDragging && Math.Abs(deltaX) > 4)
            {
                _isDragging = true;
                menuContainer.CaptureMouse(); // Захватываем мышь для плавного скролла
            }

            if (_isDragging)
            {
                // Скроллим контент вслед за мышкой
                menuContainer.ScrollToHorizontalOffset(_startHorizontalOffset - deltaX);

                // Говорим WPF, что это событие "обработано" и кнопкам под мышкой его передавать не нужно
                e.Handled = true;
            }
        }

        private void ScrollViewer_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (_isDragging)
            {
                // Если мы перетаскивали меню, отпускаем захват мыши и гасим клик на кнопке
                _isDragging = false;
                menuContainer.ReleaseMouseCapture();
                e.Handled = true; // Защищает от ложного срабатывания кнопки при отпускании мыши после скролла
            }
        }
    }
}
