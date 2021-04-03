using ModernWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fluent_Android_Helper.Function_Views.Software_Settings_Views
{
    /// <summary>
    /// Theme.xaml 的交互逻辑
    /// </summary>
    public partial class Theme : Page
    {
        public Theme()
        {
            InitializeComponent();
        }

        private void ThemeAccentBaseColor_Toggled(object sender, RoutedEventArgs e)
        {
            if (ThemeAccentBaseColor.IsOn == true)
            {
                ThemeManager.Current.ApplicationTheme = ApplicationTheme.Dark;
            }
        }

        private void IsTransparentActive_Toggled(object sender, RoutedEventArgs e)
        {

        }

        private void SetWelcomeTitle_Click(object sender, RoutedEventArgs e)
        {
            string str = WelcomeTitleText.Text;
            MainWindow.frm.setLabel(str);
            
        }
    }
}
