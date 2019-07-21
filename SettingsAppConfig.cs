using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Xml;

namespace Text_style_setter
{
    internal class SettingsAppConfig : SettingsApp
    {
        private readonly XmlDocument configDoc = new XmlDocument();

        private readonly string nameOfConfFile = $"{Assembly.GetExecutingAssembly().Location}.config";
        public SettingsAppConfig(MainWindow mWindow)
        {
            try
            {
                configDoc.Load(nameOfConfFile);
            }
            catch (FileNotFoundException e)
            {
                throw new Exception("File can't be loaded", e);
            }
            ReadSettings(mWindow, ConfigurationManager.AppSettings);
        }

        public override void SaveSettings(Dictionary<string, object> userPreferences)
        {
            XmlNode appSettingsTag = configDoc.SelectSingleNode("//appSettings");

            if (appSettingsTag == null)
            {
                XmlNode configTag = configDoc.SelectSingleNode("configuration");

                appSettingsTag = configDoc.CreateElement("appSettings");
                configTag.AppendChild(appSettingsTag);
            }

            foreach (KeyValuePair<string, object> pair in userPreferences)
            {
                XmlNode currAddTag = appSettingsTag.SelectSingleNode($"//add[@key='{pair.Key}']");

                if (currAddTag is XmlElement addTag)
                {
                    addTag.SetAttribute("value", pair.Value.ToString());
                }
                else
                {
                    XmlElement newAddTag = configDoc.CreateElement("add");

                    newAddTag.SetAttribute("key", pair.Key);
                    newAddTag.SetAttribute("value", pair.Value.ToString());

                    appSettingsTag.AppendChild(newAddTag);
                }
            }
            configDoc.Save(nameOfConfFile);//save changes 
        }
    }
}
