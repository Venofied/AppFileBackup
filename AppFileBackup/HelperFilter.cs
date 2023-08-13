using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFileBackup.Data;
using AppFileBackup.Interface;
using AppFileBackup.Models;

namespace AppFileBackup
{
    internal class HelperFilter : InterfaceSetting
    {
        public PathSetting PathSettings { get; set; }

        public HelperFilter(PathSetting pathSetting)
        {
            PathSettings = pathSetting;
        }
        /// <summary>
        /// Создание нового фильтра
        /// </summary>
        /// <returns></returns>
        public Filtres CreateNewFilter()
        {
            Filtres filter = new Filtres();

            filter.Id = GetNewId();
            filter.Description = String.Empty;
            filter.Filter = ListFiltres.Filters[0];
            filter.IsActive = true;
            return filter;
        }
        /// <summary>
        /// Добавление нового фильтра
        /// </summary>
        /// <param name="newFilter"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        public Filtres AddNewFilter(string newFilter, string description)
        {
            Filtres filter = new Filtres();

            filter.Id = GetNewId();
            filter.Description = description;
            filter.Filter = newFilter;
            filter.IsActive = true;
            return filter;
        }
        /// <summary>
        /// Получение нового Id
        /// </summary>
        /// <returns></returns>
        public int GetNewId()
        {
            if(PathSettings.Filters == null)
            {
                return 1;
            }
            var id = PathSettings.Filters.LastOrDefault().Id;
            return id;
        }
        
    }
}
