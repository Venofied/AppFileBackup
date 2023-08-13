using AppFileBackup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFileBackup.Data
{
    internal class ListFiltres
    {
        public static string[] Filters = new string[] {
            "*.*",
            };

        public static List<Filtres> GetDefaultFilters()
        {
            List<Filtres> filters = new List<Filtres>();
            foreach (var filter in Filters)
            {
                Filtres newDefaultfilters = new Filtres();
                newDefaultfilters.Filter = filter;
                newDefaultfilters.IsActive = true;
                filters.Add(newDefaultfilters);
            }
            return filters;
        }
    }
}
