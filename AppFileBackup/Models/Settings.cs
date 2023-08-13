using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFileBackup.Models
{
    public class Settings
    {
        public List<PathSetting> PathSourceSettings { get; set; }
        public string PathTemp { get; set; }

    }
}
