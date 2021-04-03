using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ModernWpf.Controls;
using System.Windows;

namespace Fluent_Android_Helper.Function_Views
{
    /// <summary>
    /// Command_Line.xaml 的交互逻辑
    /// </summary>
    public partial class Command_Line : Window
    {
        public Command_Line()
        {
            InitializeComponent();
        }

        private void ADB_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private async void DisplaySuccessDialog()
        {
            ContentDialog noWifiDialog = new ContentDialog
            {
                Title = "成功",
                Content = "已经发送重启指令",
                CloseButtonText = "确定"
            };

            ContentDialogResult result = await noWifiDialog.ShowAsync();
        }
        private void Fastboot_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb reboot bootloader &exit";
            ADBExecutor.CommandExecutor();
            DisplaySuccessDialog();
        }

        private void Recovery_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb reboot recovery &exit";
            ADBExecutor.CommandExecutor();
            DisplaySuccessDialog();
        }


        private void RebootSystem_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb reboot &exit";
            ADBExecutor.CommandExecutor();
            DisplaySuccessDialog();
        }
    }
}
