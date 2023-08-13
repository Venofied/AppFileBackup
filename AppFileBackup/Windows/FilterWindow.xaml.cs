using AppFileBackup.Models;
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
using System.Windows.Shapes;

namespace AppFileBackup.Windows
{
    /// <summary>
    /// Логика взаимодействия для FilterWindow.xaml
    /// </summary>
    public partial class FilterWindow : Window
    {

        private HelperFilter _helperFilter { get; set; }
        private SettingsReader _settingsReader { get; set; }
        public FilterWindow(PathSetting pathSetting)
        {
            InitializeComponent();
            _helperFilter = new HelperFilter(pathSetting);
            _settingsReader = new SettingsReader();
        }

        private void DataGridFiltres_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Filter":
                    e.Column.Header = "Фильтр";
                    break;

                case "Description":
                    e.Column.Header = "Комментарий";
                    break;

                case "IsActive":
                    e.Column.Header = "В работе";
                    break;

                default:
                    break;
            }
        }

        private void DataGridFiltres_Loaded(object sender, RoutedEventArgs e)
        {
            GetFiltres();
        }
        private void GetFiltres()
        {
            try
            {
                DataGridFiltres.ItemsSource = null;
                if(_helperFilter.PathSettings.Filters == null)
                {
                    var filter = _helperFilter.CreateNewFilter();
                    List<Filtres> filtres = new List<Filtres>();
                    filtres.Add(filter);
                    _helperFilter.PathSettings.Filters = filtres;
                }
                DataGridFiltres.ItemsSource = _helperFilter.PathSettings.Filters;

                DataGridFiltres.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                DataGridFiltres.ItemsSource = null;
                MessageBox.Show("Ошибка при загрузке фильтров по пути! Подробнее в лог файле", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            Filtres filter = CreateNewFilter(out bool result);
            if (result)
            {
                _helperFilter.PathSettings.Filters.Add(filter);
                _settingsReader.WritePathSettings(_helperFilter.PathSettings);
                GetFiltres();
            }
            else
            {
                MessageBox.Show("Введите фильтр для файлов");
            }
        }

        private Filtres CreateNewFilter(out bool result)
        {
            result = true;
            Filtres filter = new Filtres();
            if (String.IsNullOrEmpty(TextBoxFilter.Text))
            {
                result = false;
            }
            else
            {
                string description = TextBoxDescription.Text;
                string newfilter = TextBoxFilter.Text;

                filter = _helperFilter.AddNewFilter(newfilter, description);
            }

            return filter;
        }

        private void ButtonDel_Click(object sender, RoutedEventArgs e)
        {
            var AutoStartSelected = DataGridFiltres.SelectedItem;
            if (AutoStartSelected != null)
            {
                var autoStart = AutoStartSelected as AutoStart;
                for (int i = 0; i < _helperFilter.PathSettings.Filters.Count; i++)
                {
                    if (_helperFilter.PathSettings.Filters[i].Id == autoStart.Id)
                    {
                        _helperFilter.PathSettings.Filters.RemoveAt(i);
                    }
                }
                _settingsReader.WritePathSettings(_helperFilter.PathSettings);
                GetFiltres();
            }
            else
            {
                MessageBox.Show("Выберите какой исходный путь удалить!");
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
