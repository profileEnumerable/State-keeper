using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Media;


namespace Text_style_setter
{
    internal abstract class SettingsApp
    {
        public abstract void SaveSettings(Dictionary<string, object> userPreferecses);

        public void ReadSettings(MainWindow mainWindow, NameValueCollection appSettings)
        {
            string errors = string.Empty;

            foreach (string key in appSettings)
            {
                string value = appSettings[key];
                string errorMassage = $"Value for {key} is incorrect or empty\n";

                switch (key)
                {
                    case "BackColor":
                        {
                            try
                            {
                                var newColor = (Color)ColorConverter.ConvertFromString(value);
                                mainWindow.ClrPcker_BackColor.SelectedColor = newColor;
                            }
                            catch (Exception)
                            {
                                errors += errorMassage;
                            }
                            break;
                        }

                    case "ForeColor":
                        {
                            try
                            {
                                var newColor = (Color)ColorConverter.ConvertFromString(value);
                                mainWindow.ClrPcker_ForeColor.SelectedColor = newColor;
                            }
                            catch (Exception)
                            {
                                errors += errorMassage;
                            }
                            break;
                        }

                    case "FontSize":
                        {
                            if (!int.TryParse(value, out int size))
                            {
                                errors += errorMassage;
                                break;
                            }
                            mainWindow.FontSizeChoise.SelectedItem = size;
                            break;
                        }
                    case "FontFamily":
                        {
                            mainWindow.FontFamilyChoise.SelectedItem = new FontFamily(value);
                            break;
                        }
                    default:
                        break;
                }
            }
            if (!string.IsNullOrEmpty(errors))
            {
                MessageBox.Show(errors);
            }
        }
    }
}
