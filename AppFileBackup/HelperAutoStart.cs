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
    public class HelperAutoStart : InterfaceSetting
    {
        public PathSetting PathSettings { get; set; }

        private DateTime Default = DateTime.Now;        
        public SettingsReader SettingsReader { get; set; }

        public HelperAutoStart(PathSetting pathSetting)
        {
            PathSettings = pathSetting;
            SettingsReader = new SettingsReader();
        }

        public List<AutoStart> GetAutoStarts()
        {
            return PathSettings.AutoStarts;
        }
        /// <summary>
        /// Создание нового автозапуска
        /// </summary>
        /// <returns></returns>
        public AutoStart CreateNewAutoStart()
        {
            AutoStart autoStart = new AutoStart();

            autoStart.Id = GetNewId();
            autoStart.Description = String.Empty;
            autoStart.DateTimeStart = Default;
            autoStart.IsActive = true;
            return autoStart;
        }
        /// <summary>
        /// Добавление автозапуска
        /// </summary>
        /// <param name="newAutoStart"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        public AutoStart AddNewAutoStart(DateTime newAutoStart, string description)
        {
            AutoStart autoStart = new AutoStart();

            autoStart.Id = GetNewId();
            autoStart.Description = description;
            autoStart.DateTimeStart = newAutoStart;
            autoStart.IsActive = true;
            return autoStart;
        }
        /// <summary>
        /// Получение нового Id
        /// </summary>
        /// <returns></returns>
        public int GetNewId()
        {
            if (PathSettings.AutoStarts == null)
            {
                return 1;
            }
            var id = PathSettings.AutoStarts.LastOrDefault().Id;
            return ++id;
        }
        /// <summary>
        /// Обновление автозапуска
        /// </summary>
        /// <param name="autoStart"></param>
        public void UpdateAutoStart(AutoStart autoStart)
        {
            var checkAutoStarts = PathSettings.AutoStarts.Where(a => a.Id == autoStart.Id);
            if(checkAutoStarts.Count() > 0)
            {
                for(int i = 0; i < PathSettings.AutoStarts.Count - 1; i++)
                {
                    if (PathSettings.AutoStarts[i].Id == autoStart.Id)
                    {
                        PathSettings.AutoStarts[i].IsActive = autoStart.IsActive;
                        PathSettings.AutoStarts[i].Description = autoStart.Description;
                        PathSettings.AutoStarts[i].DateTimeStart = autoStart.DateTimeStart;
                        break;
                    }
                }
            }
            if(checkAutoStarts.Count() > 1)
            {
                for (int i = 0; i < PathSettings.AutoStarts.Count - 1; i++)
                {
                    PathSettings.AutoStarts[i].Id = i + 1;
                }
            }
            SettingsReader.WritePathSettings(PathSettings);
        }

    }
}
