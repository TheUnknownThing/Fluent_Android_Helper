using System;
using System.Collections.Generic;
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

namespace Fluent_Android_Helper
{
    /// <summary>
    /// LicenseAgreement.xaml 的交互逻辑
    /// </summary>
    public partial class LicenseAgreement : Window
    {
        public LicenseAgreement()
        {
            InitializeComponent();
            string IsSettingsExist = "App.txt";
            if (File.Exists(IsSettingsExist))
            {
                using (StreamReader sReader = new StreamReader("App.txt", Encoding.UTF8))
                {
                    string aLine;

                    while (true)
                    {
                        aLine = sReader.ReadLine();
                        if (aLine == null)
                        {
                            break;
                        }
                        if (aLine == "LicenseAgreed = 1")
                        {
                            MainWindow k = new MainWindow();
                            k.Show();
                            this.Close();
                        }
                    }
                    sReader.Close();
                }
            }
            else
            {
                File.Create(IsSettingsExist);
            }
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("App.txt", true);
            sw.WriteLine("LicenseAgreed = 1");
            sw.Close();
            MainWindow k = new MainWindow();
            k.Show();
            string p = AppDomain.CurrentDomain.BaseDirectory + "startADB.cmd";
            if (!File.Exists(p))
            {
                ModernWpf.MessageBox.Show("缺失文件" + "startADB.cmd" + ",请检查杀软");
            }
            System.Diagnostics.Process.Start(@p);
            this.Close();
        }

        private void IsLicenseAgreed_Toggled(object sender, RoutedEventArgs e)
        {
            if (IsLicenseAgreed.IsOn == true)
            {
                Enter.IsEnabled = true;
            }
            else
            {
                Enter.IsEnabled = false;
            }
        }
    }
}
