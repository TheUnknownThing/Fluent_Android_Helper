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
using Command_Executor;
namespace Fluent_Android_Helper.Function_Views.Input_Simulate_Views
{
    /// <summary>
    /// Touch_Simulate.xaml 的交互逻辑
    /// </summary>
    public partial class Touch_Simulate : Page
    {
        public Touch_Simulate()
        {
            InitializeComponent();
        }

        private void Simulate_Input_Text_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input keyboard text " + InputText.Text;
            ADBExecutor.CommandExecutor();
        }

        private void Simulate_Swipe_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input swipe " + SwipeX1.Text + " " + SwipeY1.Text + " " + SwipeX2.Text + " " + SwipeY2.Text+" "+DurationTime.Text;
            ADBExecutor.CommandExecutor();
        }

        private void Simulate_Tap_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell input tap " + tapX.Text + " " + tapY.Text;
            ADBExecutor.CommandExecutor();
        }
    }
}
