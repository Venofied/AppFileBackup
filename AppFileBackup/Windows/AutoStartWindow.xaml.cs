using AppFileBackup.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.IO.Compression;

namespace AppFileBackup.Windows
{
    /// <summary>
    /// Логика взаимодействия для AutoStartWindow.xaml
    /// </summary>
    public partial class AutoStartWindow : Window
    {        
        private HelperAutoStart _helperAutoStart { get; set; }
        private SettingsReader _settingsReader { get; set; }
        public AutoStartWindow(PathSetting pathSetting)
        {
            InitializeComponent();
            _helperAutoStart = new HelperAutoStart(pathSetting);
            _settingsReader = new SettingsReader();
        }

        private void AddNewDate_Click(object sender, RoutedEventArgs e)
        {
            AutoStart autoStart = CreateNewAutoStart(out bool result);
            if (result)
            {
                if(_helperAutoStart.PathSettings.AutoStarts == null)
                {
                    _helperAutoStart.PathSettings.AutoStarts = new List<AutoStart>();
                }
                _helperAutoStart.PathSettings.AutoStarts.Add(autoStart);
                _settingsReader.WritePathSettings(_helperAutoStart.PathSettings);
                GetAutoStart();
            }
            else
            {
                MessageBox.Show("Выберите дату");
            }
        }

        private AutoStart CreateNewAutoStart(out bool result)
        {
            result = true;
            AutoStart autoStart = new AutoStart();
            DateTime? selectedDate = DataPickerAutoStart.SelectedDate;
            string description = TextBoxDescription.Text;
            if (selectedDate != null)
            {
                autoStart = _helperAutoStart.AddNewAutoStart((DateTime)selectedDate, description);
            }
            else
            {
                result = false;
            }
            return autoStart;
        }

        private void AutoStartDataGrid_Loaded(object sender, RoutedEventArgs e)
        {           
                GetAutoStart();
        }
        private void GetAutoStart()
        {
            try
            {
                AutoStartDataGrid.ItemsSource = null;
                AutoStartDataGrid.ItemsSource = _helperAutoStart.PathSettings.AutoStarts;
                AutoStartDataGrid.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                AutoStartDataGrid.ItemsSource = null;
                MessageBox.Show("Ошибка при загрузке автозапусков по пути! Подробнее в лог файле", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void AutoStartDataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "DateTimeStart":
                    e.Column.Header = "Дата";
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

        private void DataPickerAutoStart_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            var selectAutoStart = AutoStartDataGrid.SelectedItem;
            if (selectAutoStart != null)
            {
                var autoStart = selectAutoStart as AutoStart;
                AutoStartEdit autoStartEdit = new AutoStartEdit(autoStart, _helperAutoStart);
                bool? result = autoStartEdit.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Выберите автозапуск");
            }
        }

        private void ButtonRefresh_Click(object sender, RoutedEventArgs e)
        {
            GetAutoStart();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {           
            var AutoStartSelected = AutoStartDataGrid.SelectedItem;
            if (AutoStartSelected != null)
            {
                var autoStart = AutoStartSelected as AutoStart;
                for (int i = 0; i < _helperAutoStart.PathSettings.AutoStarts.Count; i++)
                {
                    if (_helperAutoStart.PathSettings.AutoStarts[i].Id == autoStart.Id)
                    {
                        _helperAutoStart.PathSettings.AutoStarts.RemoveAt(i);
                    }
                }
                _settingsReader.WritePathSettings(_helperAutoStart.PathSettings);
                GetAutoStart();
            }
            else
            {
                MessageBox.Show("Выберите какой исходный путь удалить!");
            }
        }
    }
}
