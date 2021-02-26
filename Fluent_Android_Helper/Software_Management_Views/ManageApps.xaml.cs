using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Windows.Threading;
using System.IO;

namespace Fluent_Android_Helper.Software_Management_Views
{
    /// <summary>
    /// ManageApps.xaml 的交互逻辑
    /// </summary>
    public partial class ManageApps : Page
    {
        ObservableCollection<UserApplication> UserApp = new ObservableCollection<UserApplication>();
        DispatcherTimer timer = new DispatcherTimer();
        bool isLoaded = false;
        public ManageApps()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
            isLoaded = true;
        }
        void timer_Tick(object sender, EventArgs e)
        {
            if (isLoaded == true)
            {
                timer.Stop();
                ADBExecutor.input = "adb shell pm list package >logs.txt &exit";
                ADBExecutor.CommandExecutor();
                if (ADBExecutor.output.IndexOf("package:") == -1)
                {
                    AppTotal.Content = "未找到应用";
                    ModernWpf.MessageBox.Show("请检查手机连接状况！", "失败");
                    return;
                }
                StreamReader package = new StreamReader("logs.txt", Encoding.GetEncoding("GB2312"));
                String line;
                int num = 0;
                while ((line = package.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        UserApp.Add(new UserApplication()
                        {
                            number = ++num,
                            packagename = line,
                            isSysUsr = "Unknown"
                        });
                    }

                    //TEST.Content = TEST.Content + "\n" + line;
                }
                Apps.ItemsSource = UserApp;
                AppTotal.Content = num;
            }
        }
        private void UninstallSelected_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Delete this app?", "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                UserApplication a = (UserApplication)Apps.SelectedItem;
                int len = a.packagename.Length;
                string needtouninstall = a.packagename.Substring(8, len);
                ADBExecutor.input = "adb shell uninstall " + needtouninstall + " &exit";
                ADBExecutor.CommandExecutor();
                ModernWpf.MessageBox.Show("删除成功！", "成功");
            }
        }

        private void Clean_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Clean the cache?", "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                UserApplication a = (UserApplication)Apps.SelectedItem;
                int len = a.packagename.Length;
                string needtouninstall = a.packagename.Substring(8, len);
                ADBExecutor.input = "adb shell pm clear " + needtouninstall + " &exit";
                ADBExecutor.CommandExecutor();
                ModernWpf.MessageBox.Show("清除数据成功！", "成功");
            }
        }

        private void UninstallSystem_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Delete this app?", "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                UserApplication a = (UserApplication)Apps.SelectedItem;
                int len = a.packagename.Length;
                string needtouninstall = a.packagename.Substring(8, len - 8);
                //System.Windows.Forms.MessageBox.Show(needtouninstall, "成功");
                ADBExecutor.input = "adb shell pm uninstall --user 0 " + needtouninstall + " &exit";
                ADBExecutor.CommandExecutor();
                ModernWpf.MessageBox.Show("删除成功！", "成功");
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void ActivityDump_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChooseAPK_Click(object sender, RoutedEventArgs e)
        {

        }

        private void InstallApps_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
