using Microsoft.Win32;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Text_style_setter
{
    internal class SettingsAppRegistry : SettingsApp
    {
        private readonly RegistryKey appStSaverKey;
        private readonly string pathToConfKey = @"Software\AppStateSaver";

        public SettingsAppRegistry(MainWindow mWindow)
        {
            RegistryKey currUser = Registry.CurrentUser;
            appStSaverKey = currUser.OpenSubKey(pathToConfKey, true);

            if (appStSaverKey == null)
            {
                appStSaverKey = currUser.CreateSubKey(pathToConfKey);
                return;
            }

            var appSettings = new NameValueCollection();

            foreach (string name in appStSaverKey.GetValueNames())
            {
                string value = appStSaverKey.GetValue(name) as string;
                appSettings.Add(name, value);
            }

            ReadSettings(mWindow, appSettings);
        }

        public override void SaveSettings(Dictionary<string, object> userPreferences)
        {
            foreach (KeyValuePair<string, object> pair in userPreferences)
            {
                appStSaverKey.SetValue(pair.Key, pair.Value);
            }
        }
    }
}
