using DodoPizza.AppServises;
using DodoPizza.MenuPages;
using DodoPizza.Properties;
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
using System.Xml.Linq;

namespace DodoPizza.Pages
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public int IDPizza1;
        public int Idd = 0;
        public Menu(string nameCashier)
        {
            InitializeComponent();

            FrameApp.frmObj = AddMenu;
            AddMenu.Navigate(new PizzaPage());

            Cashier.Text = nameCashier;
            /* string IDPizza = Convert.ToString(Settings.Default["IDPizza"]);
             if (Convert.ToInt32(Settings.Default["IDPizza"]) > 0)
             {
                 for (int i = 0; i < IDPizza.Length; i++)
                 {
                     if (IDPizza[i] == Convert.ToChar(" "))
                     {
                         IDPizza1 = Convert.ToInt32(IDPizza[i - 1]);
                         Idd = Convert.ToInt32(DbConnect.entObj.Pizza.Select(x => x.Id == IDPizza1).FirstOrDefault());

                         if (DbConnect.entObj.Users.Select(x => x.Name) != null)
                         {
                             cartList.Items.Add(Idd);
                         }
                     }

                 }*/
            /* int Idd = Convert.ToInt32(DbConnect.entObj.Pizza.Select(x => x.Id == IDPizza1).FirstOrDefault());

             if (DbConnect.entObj.Users.Select(x => x.Name) != null)
             {
                 cartList.Items.Add(Idd);
             }}*/

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PizzaPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new SnackPage());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new BeveragesPage());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new DessertPage());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new AddProductPage());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Order());
        }

        private void TxbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_39(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы сделали заказ!",
                                  "Заказ",
                                  MessageBoxButton.OK,
                                  MessageBoxImage.Warning);
           
        }

        private void cartList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cartList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try { 
            string IDPizza = Convert.ToString(Settings.Default["IDPizza"]);
            if (Convert.ToInt32(Settings.Default["IDPizza"]) > 0)
            {
                for (int i = 0; i < IDPizza.Length; i++)
                {
                    if (IDPizza[i] == Convert.ToChar(" "))
                    {
                        IDPizza1 = Convert.ToInt32(IDPizza[i - 1]);
                        Idd = Convert.ToInt32(DbConnect.entObj.Pizza.Select(x => x.Id == IDPizza1).FirstOrDefault());

                        if (DbConnect.entObj.Users.Select(x => x.Name) != null)
                        {
                            cartList.Items.Add(Idd);
                        }
                    }

                }
            }
            string IDDessert = Convert.ToString(Settings.Default["IDDessert"]);
            if (Convert.ToInt32(Settings.Default["IDDessert"]) > 0)
            {
                for (int i = 0; i < IDDessert.Length; i++)
                {
                    if (IDDessert[i] == Convert.ToChar(" "))
                    {
                        IDPizza1 = Convert.ToInt32(IDDessert[i - 1]);
                        Idd = Convert.ToInt32(DbConnect.entObj.Pizza.Select(x => x.Id == IDPizza1).FirstOrDefault());

                        if (DbConnect.entObj.Users.Select(x => x.Name) != null)
                        {
                            cartList.Items.Add(Idd);
                        }
                    }

                }
            }
            string IDBeverages = Convert.ToString(Settings.Default["IDBeverages"]);
            if (Convert.ToInt32(Settings.Default["IDBeverages"]) > 0)
            {
                for (int i = 0; i < IDBeverages.Length; i++)
                {
                    if (IDBeverages[i] == Convert.ToChar(" "))
                    {
                        IDPizza1 = Convert.ToInt32(IDBeverages[i - 1]);
                        Idd = Convert.ToInt32(DbConnect.entObj.Pizza.Select(x => x.Id == IDPizza1).FirstOrDefault());

                        if (DbConnect.entObj.Users.Select(x => x.Name) != null)
                        {
                            cartList.Items.Add(Idd);
                        }
                    }

                }
            }
            string IDAdd = Convert.ToString(Settings.Default["IDAdd"]);
            if (Convert.ToInt32(Settings.Default["IDAdd"]) > 0)
            {
                for (int i = 0; i < IDPizza.Length; i++)
                {
                    if (IDAdd[i] == Convert.ToChar(" "))
                    {
                        IDPizza1 = Convert.ToInt32(IDAdd[i - 1]);
                        Idd = Convert.ToInt32(DbConnect.entObj.Pizza.Select(x => x.Id == IDPizza1).FirstOrDefault());

                        if (DbConnect.entObj.Users.Select(x => x.Name) != null)
                        {
                            cartList.Items.Add(Idd);
                        }
                    }

                }
            }
            string IDSnack = Convert.ToString(Settings.Default["IDSnack"]);
            if (Convert.ToInt32(Settings.Default["IDSnack"]) > 0)
            {
                for (int i = 0; i < IDSnack.Length; i++)
                {
                    if (IDSnack[i] == Convert.ToChar(" "))
                    {
                        IDPizza1 = Convert.ToInt32(IDSnack[i - 1]);
                        Idd = Convert.ToInt32(DbConnect.entObj.Pizza.Select(x => x.Id == IDPizza1).FirstOrDefault());

                        if (DbConnect.entObj.Users.Select(x => x.Name) != null)
                        {
                            cartList.Items.Add(Idd);
                        }
                    }

                }
            }
            cartList.UpdateLayout();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка работы приложения: " + ex.Message.ToString(),
                                   "Критический сбой работы приложения",
                                   MessageBoxButton.OK,
                                   MessageBoxImage.Warning);
            }
        }

    } 
}

