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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppFileBackup.Windows
{
    /// <summary>
    /// Логика взаимодействия для AutoStartEdit.xaml
    /// </summary>
    public partial class AutoStartEdit : Window
    {
        private AutoStart _autoStart { get; set; }
        private HelperAutoStart _helperAutoStart { get; set; }
        public AutoStartEdit(AutoStart autoStart, HelperAutoStart helperAutoStart)
        {
            InitializeComponent();
            _autoStart = autoStart;
            _helperAutoStart = helperAutoStart;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {

            for(int i = 0; i < _helperAutoStart.PathSettings.AutoStarts.Count - 1; i++)
            {
                if (_helperAutoStart.PathSettings.AutoStarts[i].Id == _autoStart.Id)
                {
                    _helperAutoStart.PathSettings.AutoStarts[i].Description = TextBoxDescription.Text;
                    _helperAutoStart.PathSettings.AutoStarts[i].DateTimeStart = DatePickerNew.DisplayDate;
                    _helperAutoStart.PathSettings.AutoStarts[i].IsActive = (bool)CheckBoxIsActive.IsChecked;
                }
            }
            _helperAutoStart.SettingsReader.WritePathSettings(_helperAutoStart.PathSettings);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TextBoxCurrentDate.Text = _autoStart.DateTimeStart.ToString();
            TextBoxDescription.Text = _autoStart.Description;
            CheckBoxIsActive.IsChecked = _autoStart.IsActive;
        }
    }
}
