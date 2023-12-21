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
    /// Логика взаимодействия для SnackPage.xaml
    /// </summary>
    public partial class SnackPage : Page
    {
        private List<Snacks> allItems;
        public SnackPage()
        {
            InitializeComponent();

            CmbFilter.SelectedValuePath = "Id";
            CmbFilter.DisplayMemberPath = "Name";
            CmbFilter.ItemsSource = DbConnect.entObj.Snacks.ToList();

            MaterialList.ItemsSource = DbConnect.entObj.Snacks.ToList();

            allItems = DbConnect.entObj.Snacks.ToList();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                CmbFilter.ItemsSource = DbConnect.entObj.Snacks.ToList();
                CmbFilter.DisplayMemberPath = "Name";
                CmbSort.SelectedIndex = 0;
                CmbFilter.SelectedIndex = 0;

                MaterialList.ItemsSource = DbConnect.entObj.Snacks.Take(DbConnect.entObj.Snacks.Count()).ToList();

                ResultTxb.Text = MaterialList.Items.Count + "/" + DbConnect.entObj.Snacks.Count().ToString();
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
                MaterialList.ItemsSource = DbConnect.entObj.Snacks.Where(x => x.Name.Contains(TxbSearch.Text)).Take(15).ToList();
                ResultTxb.Text = MaterialList.Items.Count + "/" + DbConnect.entObj.Snacks.Where(x => x.Name.Contains(TxbSearch.Text)).Count().ToString();
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
                List<Snacks> sortMaterials = allItems.OrderBy(x => x.Name).ToList();
                MaterialList.ItemsSource = sortMaterials;
            }
            else if (CmbSort.SelectedIndex == 1)
            {
                List<Snacks> sortMaterials = allItems.OrderByDescending(x => x.Name).ToList();
                MaterialList.ItemsSource = sortMaterials;
            }
            else if (CmbSort.SelectedIndex == 2)
            {
                List<Snacks> sortMaterials = allItems.OrderBy(x => x.Sum).ToList();
                MaterialList.ItemsSource = sortMaterials;
            }
            else if (CmbSort.SelectedIndex == 3)
            {
                List<Snacks> sortMaterials = allItems.OrderByDescending(x => x.Sum).ToList();
                MaterialList.ItemsSource = sortMaterials;
            }
        }

        private void CmbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var select = CmbFilter.SelectedItem as Snacks;
            var items = (select != null) ? allItems.Where(x => x.Id == select.Id) : allItems;
            MaterialList.ItemsSource = items;
        }
        private void UpdateDataGrid()
        {
            var selectedDoc = CmbFilter.SelectedItem as Snacks;

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
                Settings.Default["IDSnack"] += Convert.ToString(item.Count) + " ";

                MessageBox.Show("Вы добавили снек!",
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
