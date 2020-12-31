using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Forms;
using System.Windows.Threading;
using System.Collections.ObjectModel;
using System.Threading;

namespace Fluent_Android_Helper
{
    /// <summary>
    /// CheckADB.xaml 的交互逻辑
    /// </summary>
    public partial class CheckADB : Window
    {
        ObservableCollection<UserApplication> UserApp = new ObservableCollection<UserApplication>();
        DispatcherTimer timer = new DispatcherTimer();
        //DispatcherTimer timer2 = new DispatcherTimer();
        bool isLoaded = false;
        public CheckADB()
        {
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
            isLoaded = true;
            InitializeComponent();
            
        }
        void timer_Tick(object sender, EventArgs e)
        {
            if (isLoaded == true)
            {
                timer.Stop();
                this.Dispatcher.Invoke(DispatcherPriority.Normal, (ThreadStart)delegate ()
                {
                    string str0 = "adb devices";
                    System.Diagnostics.Process p = new System.Diagnostics.Process();
                    p.StartInfo.FileName = "cmd.exe";
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardInput = true;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.RedirectStandardError = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.Start();
                    p.StandardInput.WriteLine(str0 + "&exit");
                    p.StandardInput.AutoFlush = true;
                    string serial= p.StandardOutput.ReadToEnd();
                    p.WaitForExit();
                    p.Close();
                    int offst = serial.IndexOf("List of devices attached");
                    serialinfo.Text = serial.Substring(offst);
                    

                });
            }
        }
        
        private void gomainmenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow k = new MainWindow();
            k.Show();
            this.Close();
        }
    }
}
