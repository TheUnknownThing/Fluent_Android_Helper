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

namespace Fluent_Android_Helper
{
    /// <summary>
    /// UI_Modify.xaml 的交互逻辑
    /// </summary>
    public partial class UI_Modify : Window
    {
        bool isLoaded = false;
        double Ani, Window, GD;
        double changetoWin = 1;
        double changetoAni = 1;
        double changetoGd = 1;
        public UI_Modify()
        {
            InitializeComponent();
        }
        private void ChangeDPI_Click(object sender, RoutedEventArgs e)
        {
            if (DPI.Text != "0")
            {
                ADBExecutor.input = "adb shell wm density " + DPI.Text;
                ADBExecutor.CommandExecutor();
                ADBExecutor.input = "adb reboot";
                ADBExecutor.CommandExecutor();
            }

        }

        private void ChangeWindow_Click(object sender, RoutedEventArgs e)
        {

            ADBExecutor.input = "adb shell settings put global window_animation_scale " + changetoAni.ToString();
            ADBExecutor.CommandExecutor();
        }

        private void ChangeGD_Click(object sender, RoutedEventArgs e)
        {
            ADBExecutor.input = "adb shell settings put global transition_animation_scale " + changetoGd.ToString();
            ADBExecutor.CommandExecutor();
        }

        private void ChangeAnimator_Click(object sender, RoutedEventArgs e)
        {

            ADBExecutor.input = "adb shell settings put global animator_duration_scale " + changetoWin.ToString();
            ADBExecutor.CommandExecutor();
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (isLoaded == true)
            {
                string Aniani = ComboWindow.SelectedItem.ToString();

                if (Aniani.IndexOf("2x") != -1) changetoWin = 2;
                else if (Aniani.IndexOf("0.25") != -1) changetoWin = 0.25;
                else if (Aniani.IndexOf("0.75") != -1) changetoWin = 0.75;
                else if (Aniani.IndexOf("1x") != -1) changetoWin = 1;
                else if (Aniani.IndexOf("1.5x") != -1) changetoWin = 1.5;
                else if (Aniani.IndexOf("0") != -1) changetoWin = 0;


            }
        }


        private void ComboWindow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (isLoaded == true)
            {
                string windowani = ComboWindow.SelectedItem.ToString();

                if (windowani.IndexOf("2x") != -1) changetoAni = 2;
                else if (windowani.IndexOf("0.25") != -1) changetoAni = 0.25;
                else if (windowani.IndexOf("0.75") != -1) changetoAni = 0.75;
                else if (windowani.IndexOf("1x") != -1) changetoAni = 1;
                else if (windowani.IndexOf("1.5x") != -1) changetoAni = 1.5;
                else if (windowani.IndexOf("0") != -1) changetoAni = 0;


            }



        }

        private void ComboGD_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (isLoaded == true)
            {
                string GDa = ComboWindow.SelectedItem.ToString();


                if (GDa.IndexOf("2x") != -1) changetoGd = 2;
                else if (GDa.IndexOf("0.25") != -1) changetoGd = 0.25;
                else if (GDa.IndexOf("0.75") != -1) changetoGd = 0.75;
                else if (GDa.IndexOf("1x") != -1) changetoGd = 1;
                else if (GDa.IndexOf("1.5x") != -1) changetoGd = 1.5;
                else if (GDa.IndexOf("0") != -1) changetoGd = 0;


            }
        }
    }
}
