#define UseFileConfig
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Text_style_setter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private SettingsApp settingsApp;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Defining the FontFamily items
            FontFamilyChoise.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.ToString());
            //Defining the FontSize items
            FontSizeChoise.ItemsSource = new[] { 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26 };
#if UseFileConfig
            settingsApp = new SettingsAppConfig(this);
#else
            settingsApp = new SettingsAppRegistry(this);
#endif
        }

        private void ClrPcker_BackColor_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            var newBackColor = new SolidColorBrush(ClrPcker_BackColor.SelectedColor.Value);

            Background = MainText.Background = backColorLabel.Background = foreColorLabel.Background
            = fontSizeLabel.Background = fontStyleLabel.Background = newBackColor;
        }

        private void ClrPcker_ForeColor_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            var newForeColor = new SolidColorBrush(ClrPcker_ForeColor.SelectedColor.Value);

            Foreground = backColorLabel.Foreground = foreColorLabel.Foreground = fontSizeLabel.Foreground
             = fontStyleLabel.Foreground = MainText.Foreground = newForeColor;
        }

        private void FontSizeChoise_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FontSize = backColorLabel.FontSize = foreColorLabel.FontSize = fontSizeLabel.FontSize
               = fontStyleLabel.FontSize = MainText.FontSize = Convert.ToInt32(FontSizeChoise.SelectedValue);
        }

        private void FontFamilyChoise_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FontFamily = backColorLabel.FontFamily = foreColorLabel.FontFamily = fontSizeLabel.FontFamily
             = fontStyleLabel.FontFamily = MainText.FontFamily = new FontFamily(FontFamilyChoise.SelectedValue.ToString());
        }

        private void SaveSettings_Click(object sender, RoutedEventArgs e)
        {
            var userPreferences = new Dictionary<string, object>()
            {
                {"BackColor",Background},
                {"ForeColor",Foreground},
                {"FontSize",FontSize},
                {"FontFamily",FontFamily}
            };

            settingsApp.SaveSettings(userPreferences);
        }
    }
}
