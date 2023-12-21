using DodoPizza.AppServises;
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
    /// Логика взаимодействия для WhoCashier.xaml
    /// </summary>
    public partial class WhoCashier : Page
    {
        public WhoCashier()
        {
            InitializeComponent();
        }

        private void Cashier1_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Menu("Яна Морозова"));
        }

        private void Cashier2_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Menu("Жасмин Рузанова"));
        }

        private void Cashier3_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Menu("Мари Каурова"));
        }
    }
}
