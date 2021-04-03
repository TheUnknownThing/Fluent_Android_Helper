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
using Fluent_Android_Helper.Function_Views;

namespace Fluent_Android_Helper
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow frm = null;
        public MainWindow()
        {
            InitializeComponent();
            frm = this;
        }

        private void Input_Simulate_Click(object sender, RoutedEventArgs e)
        {
            Input_Simulate k = new Input_Simulate();
            k.Show();
        }

        private void Font_Click(object sender, RoutedEventArgs e)
        {
            Fluent_Android_Helper.Function_Views.Fonts k = new Fluent_Android_Helper.Function_Views.Fonts();
            k.Show();
        }

        private void Appearance_Click(object sender, RoutedEventArgs e)
        {
            UI_Modify l = new UI_Modify();
            l.Show();
        }

        private void command_Click(object sender, RoutedEventArgs e)
        {
            Command_Line k = new Command_Line();
            k.Show();
        }

        private void application_Click(object sender, RoutedEventArgs e)
        {
            Software_Management k = new Software_Management();
            k.Show();
        }

        private void mtp_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void function_setting_Click(object sender, RoutedEventArgs e)
        {
            Software_Settings k = new Software_Settings();
            k.Show();
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            Update k = new Update();
            k.Show();
        }
        public void setLabel(string str)
        {
            WelcomeTitle.Content = str;
        }

        private void MTK_Copy1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NativeAndroidToolbox_Click(object sender, RoutedEventArgs e)
        {
            NativeAndroidToolbox p = new NativeAndroidToolbox();
            p.Show();
        }

        private void MiToolbox_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
