using DodoPizza.AppServises;
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

namespace DodoPizza.MenuPages
{
    /// <summary>
    /// Логика взаимодействия для BeveragesPage.xaml
    /// </summary>
    public partial class BeveragesPage : Page
    {
        private List<Deverages> allItems;

        public BeveragesPage()
        {
            InitializeComponent();

            CmbFilter.SelectedValuePath = "Id";
            CmbFilter.DisplayMemberPath = "Name";
            CmbFilter.ItemsSource = DbConnect.entObj.Deverages.ToList();

            MaterialList.ItemsSource = DbConnect.entObj.Deverages.ToList();

            allItems = DbConnect.entObj.Deverages.ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                CmbFilter.ItemsSource = DbConnect.entObj.Deverages.ToList();
                CmbFilter.DisplayMemberPath = "Name";
                CmbSort.SelectedIndex = 0;
                CmbFilter.SelectedIndex = 0;

                MaterialList.ItemsSource = DbConnect.entObj.Deverages.Take(DbConnect.entObj.Deverages.Count()).ToList();

                ResultTxb.Text = MaterialList.Items.Count + "/" + DbConnect.entObj.Deverages.Count().ToString();
            }
            catch
            {
                MessageBox.Show("Упс, что-то пошло не так! ;)",
                               "Уведомление",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
            }
        }
        private void TxbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                MaterialList.ItemsSource = DbConnect.entObj.Deverages.Where(x => x.Name.Contains(TxbSearch.Text)).Take(15).ToList();
                ResultTxb.Text = MaterialList.Items.Count + "/" + DbConnect.entObj.Deverages.Where(x => x.Name.Contains(TxbSearch.Text)).Count().ToString();
            }
            catch
            {
                throw;
            }
        }

        private void CmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CmbSort.SelectedIndex == 0)
            {
                List<Deverages> sortMaterials = allItems.OrderBy(x => x.Name).ToList();
                MaterialList.ItemsSource = sortMaterials;
            }
            else if (CmbSort.SelectedIndex == 1)
            {
                List<Deverages> sortMaterials = allItems.OrderByDescending(x => x.Name).ToList();
                MaterialList.ItemsSource = sortMaterials;
            }
            else if (CmbSort.SelectedIndex == 2)
            {
                List<Deverages> sortMaterials = allItems.OrderBy(x => x.Sum).ToList();
                MaterialList.ItemsSource = sortMaterials;
            }
            else if (CmbSort.SelectedIndex == 3)
            {
                List<Deverages> sortMaterials = allItems.OrderByDescending(x => x.Sum).ToList();
                MaterialList.ItemsSource = sortMaterials;
            }
            
        }

        private void CmbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var select = CmbFilter.SelectedItem as Deverages;
            var items = (select != null) ? allItems.Where(x => x.Id == select.Id) : allItems;
            MaterialList.ItemsSource = items;
        }
        private void UpdateDataGrid()
        {
            var selectedDoc = CmbFilter.SelectedItem as Deverages;

            string searchText = TxbSearch.Text.ToLower();

            // Получение коллекции всех элементов или элементов для выбранной папки
            var items = (selectedDoc != null) ? allItems.Where(x => x.Id == selectedDoc.Id) : allItems;




            // Обновление отображения в DataGrid
            MaterialList.ItemsSource = items;


        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
        private void Like_Click(object sender, RoutedEventArgs e)
        {


            var item = MaterialList.SelectedItems.Cast<Pizza>().ToList();


            try
            {
                Settings.Default["IDBeverages"] += Convert.ToString(item.Count) + " ";

                MessageBox.Show("Вы добавили напиток!",
                               "Уведомление",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);



            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка работы приложения: " + ex.Message.ToString(),
                               "Критический сбой работы приложения",
                               MessageBoxButton.OK,
                               MessageBoxImage.Warning);
            }

        }

        private void MaterialList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
