using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFileBackup.Models
{
    public class PathSetting : MainSettings
    {
        [DisplayName("Исходная папка")]
        public string? SourcePath { get; set; }

        [DisplayName("Синхронизация")]
        public bool SyncData { get; set; }

        [DisplayName("Автозапуск")]
        public List<AutoStart>? AutoStarts { get; set; }

        [DisplayName("Фильтры")]
        public List<Filtres>? Filters { get; set; }
    }
}
