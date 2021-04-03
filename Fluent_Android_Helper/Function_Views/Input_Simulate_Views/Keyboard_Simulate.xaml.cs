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

namespace Fluent_Android_Helper.Function_Views.Input_Simulate_Views
{
    /// <summary>
    /// Keyboard_Simulate.xaml 的交互逻辑
    /// </summary>
    public partial class Keyboard_Simulate : Page
    {
        public Keyboard_Simulate()
        {
            InitializeComponent();
        }

        private void multitasking_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input keyevent 187";
            ADBExecutor.CommandExecutor();

        }

        private void up_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input keyevent 19";
            ADBExecutor.CommandExecutor();
        }

        private void left_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input keyevent 21";
            ADBExecutor.CommandExecutor();
        }

        private void right_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input keyevent 22";
            ADBExecutor.CommandExecutor();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input keyevent 3";
            ADBExecutor.CommandExecutor();
        }

        private void down_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input keyevent 20";
            ADBExecutor.CommandExecutor();

        }

        private void powerbutton_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input keyevent 26";
            ADBExecutor.CommandExecutor();
        }

        private void zoomin_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input keyevent 168";
            ADBExecutor.CommandExecutor();
        }

        private void zoomout_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input keyevent 169";
            ADBExecutor.CommandExecutor();
        }

        private void volumeup_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input keyevent 24";
            ADBExecutor.CommandExecutor();
        }

        private void volumedown_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input keyevent 25";
            ADBExecutor.CommandExecutor();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input keyevent 85";
            ADBExecutor.CommandExecutor();
        }

        private void pause_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input keyevent 86";
            ADBExecutor.CommandExecutor();
        }

        private void fastfoward_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input keyevent 87";
            ADBExecutor.CommandExecutor();
        }

        private void backfoward_Click(object sender, RoutedEventArgs e)
        {

        }

        private void previous_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input keyevent 88";
            ADBExecutor.CommandExecutor();
        }

        private void mute_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input keyevent 164";
            ADBExecutor.CommandExecutor();
        }

        private void Tab_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input keyevent 61";
            ADBExecutor.CommandExecutor();

        }

        private void Simulate_Custom_Buttons_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input keyevent "+Text.Text;
            ADBExecutor.CommandExecutor();
        }
    }
}
