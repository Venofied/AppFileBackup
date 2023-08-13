using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using AppFileBackup.Models;
using System.Reflection.Metadata;

namespace AppFileBackup
{
    public delegate void SomeBoolChangedEvent();
    public class HelperGrid
    {
        SettingsReader settingsReader { get; set; }
        public HelperGrid()
        {
            settingsReader = new SettingsReader();
        }
        /// <summary>
        /// Получение списка исходных путей
        /// </summary>
        /// <returns></returns>
        public List<PathSetting> GetPathSettingGrid()
        {
            var settings = settingsReader.GetMainSettings();
            List<PathSetting> settingsPath = settings.PathSourceSettings;           

            return settingsPath;
        }

        public DataGridColumn GetColumn(FrameworkElementFactory buttonDataGrid, string nameHeader)
        {
            return new DataGridTemplateColumn()
            {
                Header = nameHeader,
                CellTemplate = new DataTemplate() { VisualTree = buttonDataGrid }
            };
        }

    }

    public class GridDataChanged
    {        
        public static event SomeBoolChangedEvent SomeBoolChanged;

        private bool someBool;
        public bool SomeBool
        {
            get
            {
                return someBool;
            }
            set
            {
                someBool = value;
                if (SomeBoolChanged != null)
                {
                    SomeBoolChanged();
                }
            }
        }
    }

}
