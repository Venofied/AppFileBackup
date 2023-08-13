using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFileBackup.Data
{
    public static class HelperBackup
    {
        public static bool RunningBackup = false;

        public static bool ResetData = false;

        public static void ChangeData()
        {
            if(ResetData)
            {
                ResetData = false;
            }
            else
            {
                ResetData = true;
            }
        }
    }
}
