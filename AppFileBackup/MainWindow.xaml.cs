using AppFileBackup.Data;
using AppFileBackup.Models;
using AppFileBackup.Windows;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
//using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace AppFileBackup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Settings Settings { get; set; }

        HelperGrid helperGrid = new HelperGrid();
        SettingsReader reader = new SettingsReader();
        HelperSettings helperSettings = new HelperSettings();        
        public MainWindow()
        {
            InitializeComponent();

            System.Windows.Forms.NotifyIcon ni = new System.Windows.Forms.NotifyIcon();
            ni.Icon = new System.Drawing.Icon("Main.ico");
            ni.Visible = true;
            ni.DoubleClick +=
                delegate (object sender, EventArgs args)
                {
                    this.Show();
                    this.WindowState = WindowState.Normal;
                };
        }

        protected override void OnStateChanged(EventArgs e)
        {
            if (WindowState == WindowState.Minimized) this.Hide();
            base.OnStateChanged(e);
        }
        /*protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            base.OnClosing(e);
        }*/

        private string SelectPath()
        {
            string path = String.Empty;
            System.Windows.Forms.FolderBrowserDialog FBD = new System.Windows.Forms.FolderBrowserDialog();
            var dialogResult = FBD.ShowDialog();
            if (System.Windows.Forms.DialogResult.OK == dialogResult)
            {
                path = FBD.SelectedPath;
            }
            return path;
        }

        private void GrigPathSource_Loaded(object sender, RoutedEventArgs e)
        {
            TextBoxPathTemp.Text = Settings.PathTemp;

            List<PathSetting> pathSettingGrid = helperGrid.GetPathSettingGrid();
            
            GrigPathSource.ItemsSource = pathSettingGrid;

            GrigPathSource.AutoGenerateColumns = true;

        }
        /// <summary>
        /// Загрузка данных Исходных путей
        /// </summary>
        private void GetItemsDataGrid()
        {
            List<PathSetting> pathSettingGrid = helperGrid.GetPathSettingGrid();
            GrigPathSource.ItemsSource = null;
            GrigPathSource.ItemsSource = pathSettingGrid;
        }

        private FrameworkElementFactory CreateTamplateButton(string name)
        {
            var buttonTemplate = new FrameworkElementFactory(typeof(Button));
            buttonTemplate.SetBinding(Button.ContentProperty, new Binding(name));
            return buttonTemplate;
        }

        private void GrigPathSource_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "SourcePath":
                    e.Column.Header = "Исходная папка";
                    break;

                case "Description":
                    e.Column.Header = "Комментарий";
                    break;

                case "IsActive":
                    e.Column.Header = "В работе";
                    break;

                case "SyncData":
                    e.Column.Header = "Синхронизация";
                    break;

                case "AutoStarts":
                    e.Column.Header = "Автозапуск";
                    e.Column.Visibility = Visibility.Hidden;
                    break;

                case "Filters":
                    e.Column.Header = "Фильтры";
                    e.Column.Visibility = Visibility.Hidden;
                    break;

                default:
                    break;
            }
        }

        private void GrigPathSource_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OpenEditWindow();
            GetItemsDataGrid();
        }

        private void EditPath_Click(object sender, RoutedEventArgs e)
        {
            OpenEditWindow();
            GetItemsDataGrid();
        }
        /// <summary>
        /// Открыть форму "Изменить" Исходного пути
        /// </summary>
        private void OpenEditWindow()
        {
            var pathSelected = GrigPathSource.SelectedItem;
            if(pathSelected != null)
            {
                var path = pathSelected as PathSetting;
                EditPathSettingWindow editPathSettingWindow = new EditPathSettingWindow(path);
                editPathSettingWindow.Show();
            }
            else
            {
                MessageBox.Show("Выберите путь");
            }
        }

        private void ChangePathTemp_Click(object sender, RoutedEventArgs e)
        {
            string pathSource = SelectPath();
            bool checkPathSource = String.IsNullOrEmpty(pathSource);
            if (!checkPathSource)
            {
                TextBoxPathTemp.Text = pathSource;
            }
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            var listPathSetting = GrigPathSource.ItemsSource as List<PathSetting>;
            Settings.PathSourceSettings = listPathSetting;
            Settings.PathTemp = TextBoxPathTemp.Text;
            reader.WriteAllSetting(Settings);
            GetItemsDataGrid();
        }

        private PathSetting CreateNewPathSetting()
        {            
            string path = TextBoxPathSource.Text;
            var newSettingPath = helperSettings.NewSettingPath(path);                      
            return newSettingPath;
        }

        private void EditPathSetting()
        {
            var newSettingPath = CreateNewPathSetting();
            Settings.PathTemp = TextBoxPathTemp.Text;

            Settings.PathSourceSettings.Add(newSettingPath);
        }

        private void AddPathSource_Click(object sender, RoutedEventArgs e)
        {
            string pathSource = SelectPath();
            TextBoxPathSource.Text = pathSource;
            EditPathSetting();

            reader.WriteAllSetting(Settings);
            GetItemsDataGrid();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Settings = reader.GetMainSettings();
            Watcher();
        }

        private void AutoStart_Click(object sender, RoutedEventArgs e)
        {

            var pathSelected = GrigPathSource.SelectedItem;
            if (pathSelected != null)
            {
                var path = pathSelected as PathSetting;
                AutoStartWindow autoStartWindow = new AutoStartWindow(path);
                autoStartWindow.Show();
            }
            else
            {
                MessageBox.Show("Выберите по какому пути настроить автозапуски");
            }
        }

        private void buttonFiltres_Click(object sender, RoutedEventArgs e)
        {
            var pathSelected = GrigPathSource.SelectedItem;
            if (pathSelected != null)
            {
                var path = pathSelected as PathSetting;
                FilterWindow filtres = new FilterWindow(path);
                filtres.Show();
            }
            else
            {
                MessageBox.Show("Выберите по какому пути настроить фильтры");
            }
        }

        private void ButtonStartBackup_Click(object sender, RoutedEventArgs e)
        {
            if (HelperBackup.RunningBackup)
            {
                MessageBox.Show("Резервное копирование выполяется!");
            }
            else
            {
                Backup backup = new Backup(Settings);
                HelperBackup.RunningBackup = true;
                backup.RunBackup();
                ButtonStartBackup.Content = "Выполнется!";
                ButtonStartBackup.IsEnabled = false;
            }
        }

        private void DeletePathSource_Click(object sender, RoutedEventArgs e)
        {
            var pathSelected = GrigPathSource.SelectedItem;
            if (pathSelected != null)
            {
                var path = pathSelected as PathSetting;
                for(int i = 0; i < Settings.PathSourceSettings.Count; i++)
                {
                    if (Settings.PathSourceSettings[i].Id == path.Id)
                    {
                        Settings.PathSourceSettings.RemoveAt(i);
                    }
                }
                reader.WriteAllSetting(Settings);
                GetItemsDataGrid();
            }
            else
            {
                MessageBox.Show("Выберите какой исходный путь удалить!");
            }
        }
        /// <summary>
        /// Отслеживание изменение файла Settings.json
        /// </summary>
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public void Watcher()
        {
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = reader.GetPathSettings();
                watcher.NotifyFilter = NotifyFilters.Attributes
                                | NotifyFilters.CreationTime
                                | NotifyFilters.DirectoryName
                                | NotifyFilters.FileName
                                | NotifyFilters.LastAccess
                                | NotifyFilters.LastWrite
                                | NotifyFilters.Security
                                | NotifyFilters.Size;
                watcher.Filter = "Settings.json";
                watcher.Changed += new FileSystemEventHandler(Watcher_Changed);
                watcher.EnableRaisingEvents = true;
            }

            using (FileSystemWatcher watcher2 = new FileSystemWatcher())
            {
                watcher2.Path = SettingsReader.InnerPath;
                watcher2.NotifyFilter = NotifyFilters.Attributes
                | NotifyFilters.CreationTime
                | NotifyFilters.DirectoryName
                | NotifyFilters.FileName
                | NotifyFilters.LastAccess
                | NotifyFilters.LastWrite
                | NotifyFilters.Security
                | NotifyFilters.Size;
                watcher2.Filter = "Settings.json";
                watcher2.Changed += new FileSystemEventHandler(Watcher_Changed);
                //watcher.c
                watcher2.EnableRaisingEvents = true;
            }
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            GetItemsDataGrid();
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            if (HelperBackup.RunningBackup)
            {
                ButtonStartBackup.Content = "Запустить";
                ButtonStartBackup.IsEnabled = true;
                HelperBackup.RunningBackup = false;
            }
            else
            {
                MessageBox.Show("Резервное копирование не запущено!");
            }
        }

        private void ButtonRefresh_Click(object sender, RoutedEventArgs e)
        {
            GetItemsDataGrid();
        }
    }
}
