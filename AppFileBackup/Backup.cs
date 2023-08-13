using AppFileBackup.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NLog;
using NLog.Targets;
using static System.Net.Mime.MediaTypeNames;
using AppFileBackup.Data;
using NLog.Filters;
using System.Windows.Shell;
using System.Diagnostics;
using System.IO.Compression;
using System.Windows.Documents;
using System.Reflection;
using NLog.Fluent;
using System.Windows.Shapes;

namespace AppFileBackup
{
    public static class AppFileLogger
    {
        public static Logger Logger = LogManager.GetCurrentClassLogger();

    }
    internal class Backup
    {
        private readonly string typeZip = ".zip";
        private Settings _settings;

        public Backup(Settings settings)
        {
            _settings = settings;
        }
        /// <summary>
        /// Запуск резервного копирования
        /// </summary>
        public void RunBackup()
        {
            AppFileLogger.Logger.Info($"Запуск резервоного копирования");            

            List<PathSetting> pathSourceSettingsIsActive = _settings.PathSourceSettings.Where(p => p.IsActive == true).ToList();

            if ((pathSourceSettingsIsActive != null) && (pathSourceSettingsIsActive.Count > 0))
            {
                var count = pathSourceSettingsIsActive.Count();
                AppFileLogger.Logger.Info($"Количество исходный путей для копирования {count}");

                List<Task> tasks = new List<Task>();

                for (var i = 0; i < count; i++)
                {
                    var index = i;
                    var backuptask = new Task(() =>
                    {
                        var pathSourceSetting = pathSourceSettingsIsActive[index];
                        BackupStart(pathSourceSetting);
                    });
                    tasks.Add(backuptask);
                    backuptask.Start();
                }
                Task.WaitAll(tasks.ToArray());
                BackupAutoStartRun(pathSourceSettingsIsActive);

                AppFileLogger.Logger.Info($"Завершены все задачи по копированию");
            }
        }
        /// <summary>
        /// Тип Резервного копирования
        /// </summary>
        /// <param name="sync">Синхронизация</param>
        /// <param name="sourcePath">Исходный путь</param>
        /// <param name="tempPath">Целевой путь</param>
        /// <param name="filters">Фильтры</param>
        private void StartBackup(bool sync, DirectoryInfo sourcePath, DirectoryInfo tempPath, List<Filtres> filters)
        {
            if (sync)
            {
                AllCopy(sourcePath, tempPath, filters);
            }
            else
            {
                CreateZipFile(sourcePath, filters);                
            }
        }
        /// <summary>
        /// Копирование всех файлов
        /// </summary>
        /// <param name="source">Исходный путь</param>
        /// <param name="target">Целевой путь</param>
        /// <param name="filters">Фильтры</param>
        public void AllCopy(DirectoryInfo source, DirectoryInfo target, List<Filtres> filters)
        {

            foreach (var ext in filters)
            {
                FileInfo[] files = source.GetFiles(ext.Filter);
                foreach (FileInfo file in files)
                {
                    file.CopyTo(System.IO.Path.Combine(target.FullName, file.Name), true);
                }
            }
        }
        /// <summary>
        /// Получение фильтров
        /// </summary>
        /// <param name="pathSourceSettingsIsActive">Исходный путь</param>
        /// <returns></returns>
        private List<Filtres> GetFiltres(PathSetting pathSourceSettingsIsActive)
        {
            List<Filtres> filters = new List<Filtres>();
            if (pathSourceSettingsIsActive.Filters == null)
            {
                filters = ListFiltres.GetDefaultFilters();
            }
            else
            {
                var collectionFilters = pathSourceSettingsIsActive.Filters.Where(f => f.IsActive == true);
                if (collectionFilters.Count() > 0)
                {
                    filters = collectionFilters.ToList();
                }
                else
                {
                    filters = ListFiltres.GetDefaultFilters();
                }
            }
            return filters;
        }
        /// <summary>
        /// Резервное копирование с архивацией
        /// </summary>
        /// <param name="source">Исходный путь</param>
        /// <param name="filters">Фильтры</param>
        private void CreateZipFile(DirectoryInfo source, List<Filtres> filters)
        {
            var nameZip = _settings.PathTemp + "\\" + source.Name + typeZip;
            System.IO.Compression.ZipArchiveMode archiveMode = System.IO.Compression.ZipArchiveMode.Create;
            if (File.Exists(nameZip))
            {
                archiveMode = System.IO.Compression.ZipArchiveMode.Update;
            }
            using (ZipArchive archive = ZipFile.Open(nameZip, archiveMode))
            {
                foreach (var ext in filters)
                {
                    FileInfo[] files = source.GetFiles(ext.Filter);
                    foreach (var item in files)
                    {
                        archive.CreateEntryFromFile(item.FullName, item.Name, CompressionLevel.Optimal);
                    }
                }

            }
        }
        /// <summary>
        /// Основной метод резервного копирования
        /// </summary>
        /// <param name="pathSourceSetting">Исходный путь</param>
        private void BackupStart(PathSetting pathSourceSetting)
        {
            try
            {
                DirectoryInfo tempPath = new DirectoryInfo(_settings.PathTemp);
                CreateTempPath(tempPath);

                AppFileLogger.Logger.Info($"Запуск задачи по копированию параметры: " +
                    $"Id {pathSourceSetting.Id} " +
                    $"В работе {pathSourceSetting.IsActive} " +
                    $"Синхронизация {pathSourceSetting.SyncData}");

                bool checkPath = String.IsNullOrEmpty(pathSourceSetting.SourcePath);
                if (checkPath)
                {
                    AppFileLogger.Logger.Error($"Ошибка при копировании! Id: {pathSourceSetting.Id} Исходный путь не корректный!");
                    return;
                }

                DirectoryInfo sourcePath = new DirectoryInfo(pathSourceSetting.SourcePath);
                if (sourcePath.Exists)
                {
                    List<Filtres> filters = GetFiltres(pathSourceSetting);

                    var countSubDir = sourcePath.GetDirectories().Length;

                    bool sync = pathSourceSetting.SyncData;

                    if (filters.Count() > 0)
                    {
                        StartBackup(sync, sourcePath, tempPath, filters);
                        if (countSubDir > 0)
                        {
                            foreach (DirectoryInfo diSourceSubDir in sourcePath.GetDirectories())
                            {
                                DirectoryInfo nextTargetSubDir = tempPath.CreateSubdirectory(diSourceSubDir.Name);
                                StartBackup(sync, diSourceSubDir, nextTargetSubDir, filters);
                            }
                        }
                    }
                    else
                    {
                        StartBackup(sync, sourcePath, tempPath, filters);

                        if (countSubDir > 0)
                        {
                            foreach (DirectoryInfo diSourceSubDir in sourcePath.GetDirectories())
                            {
                                DirectoryInfo nextTargetSubDir = tempPath.CreateSubdirectory(diSourceSubDir.Name);
                                StartBackup(sync, diSourceSubDir, nextTargetSubDir, filters);
                            }
                        }
                    }
                }
                else
                {
                    AppFileLogger.Logger.Error($"Ошибка при копировании! Id: {pathSourceSetting.Id} Исходный путь не корректный!");
                }
                AppFileLogger.Logger.Info($"Завершена задача по копированию Id: {pathSourceSetting.Id}");
            }
            catch (Exception ex)
            {
                AppFileLogger.Logger.Error($"Ошибка при резевном копировании Id: {pathSourceSetting.Id}. {ex}");
            }
        }
        /// <summary>
        /// Проверка Целевого пути
        /// </summary>
        /// <param name="pathTemp"></param>
        /// <returns></returns>
        private bool CreateTempPath(DirectoryInfo pathTemp)
        {
            try
            {               
                if (!pathTemp.Exists)
                {
                    pathTemp.Create();
                }
                return true;
            }
            catch (Exception ex)
            {
                AppFileLogger.Logger.Error($"Ошибка при создании подкаталога! {ex}");
                return false;
            }

        }
        /// <summary>
        /// Запуск потока с проверкой автозапусков
        /// </summary>
        /// <param name="pathSourceSettingsIsActive"></param>
        private void BackupAutoStartRun(List<PathSetting> pathSourceSettingsIsActive)
        {
            var outer = Task.Factory.StartNew(() =>
            {
                while (HelperBackup.RunningBackup)
                {
                    foreach (PathSetting pathSetting in pathSourceSettingsIsActive)
                    {
                        if (pathSetting.AutoStarts != null)
                        {
                            if (pathSetting.AutoStarts.Count > 0)
                            {
                                foreach (var autostart in pathSetting.AutoStarts)
                                {
                                    if (autostart.DateTimeStart.Hour == DateTime.Now.Hour && autostart.DateTimeStart.Minute == DateTime.Now.Minute)
                                    {
                                        BackupStart(pathSetting);
                                    }
                                }
                            }
                        }
                    }
                    Thread.Sleep(1000 * 59);
                }
            });
        }
    }
}
