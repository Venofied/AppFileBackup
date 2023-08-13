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
    public partial class EditPathSettingWindow : Window
    {
        private string[] ItemsComboBox = new string[] { "Автозапуски", "Фильтры" };
        //private int _pathSettingId { get; set; }
        private PathSetting _pathSetting { get; set; }

        SettingsReader SettingsReader = new SettingsReader();
        public EditPathSettingWindow(PathSetting pathSetting)
        {
            _pathSetting = pathSetting;
            InitializeComponent();            
        }

        

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            SettingsReader settingsReader = new SettingsReader();

            var pathSetting = GetNewPath();
            settingsReader.WritePathSettings(pathSetting);
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //_pathSetting = SettingsReader.GetMainPathSetting(_pathSettingId);

            ComboBoxChangeSettingList.Items.Clear();
            ComboBoxChangeSettingList.ItemsSource = ItemsComboBox;
            CheckBoxIsActive.IsChecked = _pathSetting.IsActive;
            CheckBoxSyncData.IsChecked = _pathSetting.SyncData;
            TextBoxDescription.Text = _pathSetting.Description;
            TextBoxPath.Text = _pathSetting.SourcePath;
        }

        private PathSetting GetNewPath()
        {
            PathSetting newPathSetting = new PathSetting();
            newPathSetting.Id = _pathSetting.Id;
            newPathSetting.SourcePath = TextBoxPath.Text;
            newPathSetting.Description = TextBoxDescription.Text;

            newPathSetting.IsActive = (bool)CheckBoxIsActive.IsChecked;
            newPathSetting.SyncData = (bool)CheckBoxSyncData.IsChecked;
            return newPathSetting;
        }

        private void ComboBoxChangeSettingList_DropDownClosed(object sender, EventArgs e)
        {
            switch(ComboBoxChangeSettingList.SelectedIndex)
            {
                case 0:
                    DataGridAdvanced.ItemsSource = _pathSetting.AutoStarts;
                    break;
                case 1:
                    DataGridAdvanced.ItemsSource = _pathSetting.Filters;
                    break;
               default:
                    DataGridAdvanced.ItemsSource = null;
                    break;
            }
            DataGridAdvanced.UpdateLayout();
        }
    }
}
