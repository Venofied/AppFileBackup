using AppFileBackup.Data;
using AppFileBackup.Interface;
using AppFileBackup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFileBackup
{
    internal class HelperSettings : InterfaceSetting
    {
        /// <summary>
        /// Получение Id для новых исходных путей
        /// </summary>
        /// <returns></returns>
        public int GetNewId()
        {
            SettingsReader settingsReader = new SettingsReader();
            var setting = settingsReader.GetMainSettings();
            var newId = setting.PathSourceSettings.LastOrDefault().Id;

            return ++newId;
        }
        /// <summary>
        /// Создание нового исходного пути
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public PathSetting NewSettingPath(string path)
        {            
            PathSetting pathSetting = new PathSetting();
            pathSetting.Id = GetNewId();
            pathSetting.SourcePath = path;
            pathSetting.IsActive = true;
            pathSetting.SyncData = false;
            pathSetting.Description = String.Empty;
            pathSetting.Filters = GetFilters(pathSetting);
            pathSetting.AutoStarts = GetAutoStart(pathSetting);
            return pathSetting;
        }
        /// <summary>
        /// Получение списка автозапуска
        /// </summary>
        /// <param name="pathSetting"></param>
        /// <returns></returns>
        private List<AutoStart> GetAutoStart(PathSetting pathSetting)
        {
            HelperAutoStart helperAutoStart = new HelperAutoStart(pathSetting);
            AutoStart autoStart = helperAutoStart.CreateNewAutoStart();
            List<AutoStart> ListAutoStart = new List<AutoStart>();
            ListAutoStart.Add(autoStart);
            return ListAutoStart;
        }
        /// <summary>
        /// Получение списка фильтров
        /// </summary>
        /// <param name="pathSetting"></param>
        /// <returns></returns>
        private List<Filtres> GetFilters(PathSetting pathSetting)
        {
            HelperFilter helperFilter = new HelperFilter(pathSetting);
            Filtres filter = helperFilter.CreateNewFilter();
            List<Filtres> filters = new List<Filtres>();
            filters.Add(filter);
            return filters;            
        }

    }
}
