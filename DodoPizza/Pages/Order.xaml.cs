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

namespace DodoPizza.Pages
{
    /// <summary>
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class Order : Page
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Cashier1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заказ создан!",
                               "Уведомление",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заказ создан!",
                               "Уведомление",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
        }
    }
}
