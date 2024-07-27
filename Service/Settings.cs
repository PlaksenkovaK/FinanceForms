using System.Configuration;
using System.Security;

namespace FinanceForms.Service
{
    internal static class settings
    {
        public static string path => AppDomain.CurrentDomain.GetData("DataDirectory")?.ToString() ?? "/";
        public static void reload()
        {
            ExeConfigurationFileMap map = new ExeConfigurationFileMap { ExeConfigFilename = Path.Combine(path, "app.config") };
            configuration = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
        }

        private static Configuration? configuration;

        public static string GetSetting(string key, string @default)
        {
            return GetSetting(key) ?? @default;
        }
        public static string? GetSetting(string key)
        {
            if (configuration == null)
            {
                reload();
            }

            if (configuration?.AppSettings.Settings[key] == null)
            {
                return null;
            }

            try
            {
                return configuration?.AppSettings.Settings[key].Value;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void SetSetting(string key, SecureString value)
        {
            SetSetting(key, value);
        }
        public static void SetSetting(string key, string value)
        {
            reload();
            if (configuration?.AppSettings.Settings[key] == null)
            {
                configuration?.AppSettings.Settings.Add(key, value);
            }
            else
            {
                configuration.AppSettings.Settings[key].Value = value;
            }
            configuration?.Save(ConfigurationSaveMode.Modified, true);
        }
    }
}
