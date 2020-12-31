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
using System.Windows.Shapes;
using Command_Executor;
namespace Fluent_Android_Helper
{
    /// <summary>
    /// NativeAndroidToolbox.xaml 的交互逻辑
    /// </summary>
    public partial class NativeAndroidToolbox : Window
    {
        List<string> CommandsToBeExecuted=new List<string>();
        public NativeAndroidToolbox()
        {
            InitializeComponent();
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CommandsToBeExecuted.Clear();
            CommandsToBeExecuted.Add("adb shell settings put global captive_portal_https_url http://connect.rom.miui.com/generate_204");
            CommandsToBeExecuted.Add("adb shell settings put global captive_portal_use_https 0");
            CommandsToBeExecuted.Add("adb shell settings put global captive_portal_http_url http://connect.rom.miui.com/generate_204");
            Command_Executor.MainWindow p = new Command_Executor.MainWindow()
            {
                Commands = CommandsToBeExecuted,
                isDualCommandAllowed = true
            };
        }
    }
}
