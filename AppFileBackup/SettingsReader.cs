using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using AppFileBackup.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Permissions;
using System.Windows.Shapes;

namespace AppFileBackup
{
    public class SettingsReader
    {
        public static string InnerPath = "D:\\Res\\infotecs\\AppFileBackup\\AppFileBackup";
        public static string InnerPathFull = InnerPath +  "\\Settings.json";

        private string _nameFileSettings = "Settings";
        private string _typeFileSettings = "json";        

        /// <summary>
        /// Получение название настроек
        /// </summary>
        /// <returns></returns>
        private string GetFullNameSettings()
        {
            string fullNameSettings = _nameFileSettings + '.' + _typeFileSettings;
            return fullNameSettings;
        }
        /// <summary>
        /// Получение пути к файлу
        /// </summary>
        /// <returns></returns>
        public string GetPathSettings()
        {
            string localPathSettings = System.AppDomain.CurrentDomain.BaseDirectory;
            return localPathSettings;
        }
        /// <summary>
        /// получение полного пути к настройкам
        /// </summary>
        /// <returns></returns>
        public string GetPathMainSettings()
        {
            string fullNameSettings = GetFullNameSettings();
            string localPathSettings = System.AppDomain.CurrentDomain.BaseDirectory + fullNameSettings;
            return localPathSettings;
        }
        /// <summary>
        /// Получение настроек
        /// </summary>
        /// <returns></returns>
        public Settings GetMainSettings()
        {
            Settings settings = new Settings();
            try
            {
                string localPathSettings = GetPathMainSettings();

                using (StreamReader r = new StreamReader(localPathSettings))
                {
                    string json = r.ReadToEnd();

                    settings = JsonConvert.DeserializeObject<Settings>(json);
                }
                return settings;
            }
            catch (Exception ex)
            {
                AppFileLogger.Logger.Error($"Ошибка при получении настроек! {ex}");
                return settings;
            }

        }
        /// <summary>
        /// Получение внутренних настроек
        /// </summary>
        /// <returns></returns>
        public Settings GetInnerSettings()
        {
            Settings settings = new Settings();
            try
            {
                using (StreamReader r = new StreamReader(InnerPathFull))
                {
                    string json = r.ReadToEnd();

                    settings = JsonConvert.DeserializeObject<Settings>(json);
                }
                return settings;
            }
            catch (Exception ex)
            {
                AppFileLogger.Logger.Error($"Ошибка при получении настроек(Inner)! {ex}");
                return settings;
            }

        }
        /// <summary>
        /// Получение Исходного пути по Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PathSetting GetMainPathSetting(int id)
        {
            var setting = GetMainSettings();

            var pathSetting = setting.PathSourceSettings[id - 1];
            return pathSetting;
        }
        /// <summary>
        /// Получние исходного пути по Id в внутренних настройках
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PathSetting GetInnerPathFullSetting(int id)
        {
            var setting = GetInnerSettings();

            var pathSetting = setting.PathSourceSettings[id - 1];
            return pathSetting;
        }
        /// <summary>
        /// Чтение настроек 
        /// </summary>
        /// <returns></returns>
        public string ReadMainSettings()
        {
            string json = String.Empty;
            try
            {
                string localPathSettings = GetPathMainSettings();

                using (StreamReader r = new StreamReader(localPathSettings))
                {
                    json = r.ReadToEnd();
                }
                return json;
            }
            catch (Exception ex)
            {
                AppFileLogger.Logger.Error($"Ошибка при чтении настроек! {ex}");
                return json;
            }
        }
        /// <summary>
        /// Чтение внутренних настроек
        /// </summary>
        /// <returns></returns>
        public string ReadInnerSettings()
        {
            string json = String.Empty;

            using (StreamReader r = new StreamReader(InnerPathFull))
            {
                json = r.ReadToEnd();
            }
            return json;
        }
        /// <summary>
        /// Записать всех настроек
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="InnerSettings"></param>
        public void WriteAllSetting(Settings settings, bool InnerSettings = false)
        {
            try
            {
#if DEBUG
                InnerSettings = true;
#endif
                string path = String.Empty;
                string pathSettingConvert = Newtonsoft.Json.JsonConvert.SerializeObject(settings);
                if (InnerSettings)
                {
                    path = InnerPathFull;
                    File.WriteAllText(path, pathSettingConvert);

                    path = GetPathMainSettings();
                    File.WriteAllText(path, pathSettingConvert);
                }
                else
                {
                    path = GetPathMainSettings();
                    File.WriteAllText(path, pathSettingConvert);
                }
                                
            }
            catch (Exception ex)
            {
                AppFileLogger.Logger.Error($"Ошибка при записи настроек(All)! {ex}");
            }

        }
        /// <summary>
        /// Запись настроек по исходному пути
        /// </summary>
        /// <param name="pathSetting"></param>
        /// <param name="InnerSettings"></param>
        public void WritePathSettings(PathSetting pathSetting, bool InnerSettings = false)
        {
            try
            {
#if DEBUG
                InnerSettings = true;
#endif
                if (InnerSettings)
                {
                    var settingInner = GetInnerSettings();
                    var settingMain = GetMainSettings();
                    WritePath(settingInner, pathSetting, CheckInnerPathFull: true);
                    WritePath(settingMain, pathSetting, CheckInnerPathFull: false);

                }
                else
                {
                    var settingMain = GetMainSettings();
                    WritePath(settingMain, pathSetting, CheckInnerPathFull: false);
                }
            }
            catch (Exception ex)
            {
                AppFileLogger.Logger.Error($"Ошибка при записи настроек(Path)! {ex}");
            }
        }
        /// <summary>
        /// Запись настроек по пути
        /// </summary>
        /// <param name="setting"></param>
        /// <param name="pathSetting"></param>
        /// <param name="CheckInnerPathFull"></param>
        private void WritePath(Settings setting, PathSetting pathSetting, bool CheckInnerPathFull)
        {
            string path = String.Empty;
            if (CheckInnerPathFull)
            {
                path = InnerPathFull;
            }
            else
            {
                path = GetPathMainSettings();
            }

            for (int i = 0; i < setting.PathSourceSettings.Count; i++)
            {
                if (setting.PathSourceSettings[i].Id == pathSetting.Id)
                {
                    setting.PathSourceSettings[i].SourcePath = pathSetting.SourcePath;
                    setting.PathSourceSettings[i].Description = pathSetting.Description;
                    setting.PathSourceSettings[i].SyncData = pathSetting.SyncData;
                    setting.PathSourceSettings[i].IsActive = pathSetting.IsActive;
                    setting.PathSourceSettings[i].Filters = pathSetting.Filters;
                    setting.PathSourceSettings[i].AutoStarts = pathSetting.AutoStarts;
                }
            }

            string pathSettingConvert = Newtonsoft.Json.JsonConvert.SerializeObject(setting);
            File.WriteAllText(path, pathSettingConvert);
        }

        private void WriteAll(Settings setting, bool CheckInnerPathFull)
        {
            string path = String.Empty;
            if (CheckInnerPathFull)
            {
                path = InnerPathFull;
            }
            else
            {
                path = GetPathMainSettings();
            }

            string pathSettingConvert = Newtonsoft.Json.JsonConvert.SerializeObject(setting);
            File.WriteAllText(path, pathSettingConvert);
        }

        public void DeletePath(PathSetting pathSetting)
        {

        }
    }
}
