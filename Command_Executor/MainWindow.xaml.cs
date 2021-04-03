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
namespace Command_Executor
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Command="";
        public List<String> Commands;
        public bool isDualCommandAllowed = false;
        public MainWindow()
        {
            InitializeComponent();
            if (!isDualCommandAllowed && Command!="")
            {
                Command_Executor.ADBExecutor.input = Command;
                //Label2.Content = Command;
                Command_Executor.ADBExecutor.CommandExecutor();
            }
            else if (isDualCommandAllowed)
            {
                for (int i = 0; i < Commands.Count(); i++)
                {
                    Command_Executor.ADBExecutor.input = Commands[i];
                    //Label2.Content = Commands[i];
                    Command_Executor.ADBExecutor.CommandExecutor();
                }
            }
            this.Close();
        }
    }
}
