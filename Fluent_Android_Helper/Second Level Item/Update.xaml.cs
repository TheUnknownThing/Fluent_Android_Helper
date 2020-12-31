using ModernWpf.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
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
using System.Windows.Threading;

namespace Fluent_Android_Helper
{
    /// <summary>
    /// Update.xaml 的交互逻辑
    /// </summary>
    public partial class Update : Window
    {
        ObservableCollection<UserApplication> UserApp = new ObservableCollection<UserApplication>();
        DispatcherTimer timer = new DispatcherTimer();
        bool isLoaded = false;
        public Update()
        {
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = TimeSpan.FromSeconds(0.5);
            timer.Start();
            isLoaded = true;
            InitializeComponent();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            if (isLoaded == true)
            {
                timer.Stop();
                DisplayLoadingDialog();
            }
        }
        private async void DisplayLoadingDialog()
        {
            ContentDialog LoadingDialog = new ContentDialog
            {
                Title = "正在加载更新内容以及更新日志",
                Content = "更新内容以及日志是在线从Gitee上获取的，若长时间卡死请按关闭(这玩意关闭貌似没用，下一个版本弄)",
                CloseButtonText = "关闭"
            };
            await LoadingDialog.ShowAsync();
            LatestVersion.Content = GetHtmlStr("https://gitee.com/theunknownthing/fluent_-android_-helper_-icon_-logs/raw/master/Version.txt", "UTF8");
            UpdateFunction.Text = GetHtmlStr("https://gitee.com/theunknownthing/fluent_-android_-helper_-icon_-logs/raw/master/NewFunction.txt", "UTF8");
            Logs.Text = GetHtmlStr("https://gitee.com/theunknownthing/fluent_-android_-helper_-icon_-logs/raw/master/Logs.txt", "UTF8");
            LoadingDialog.Hide();
        }
        public static string GetHtmlStr(string url, string encoding)
        {
            string htmlStr = "";
            try
            {
                if (!String.IsNullOrEmpty(url))
                {
                    WebRequest request = WebRequest.Create(url);            //实例化WebRequest对象  
                    WebResponse response = request.GetResponse();           //创建WebResponse对象  
                    Stream datastream = response.GetResponseStream();       //创建流对象  
                    Encoding ec = Encoding.Default;
                    if (encoding == "UTF8")
                    {
                        ec = Encoding.UTF8;
                    }
                    else if (encoding == "Default")
                    {
                        ec = Encoding.Default;
                    }
                    StreamReader reader = new StreamReader(datastream, ec);
                    htmlStr = reader.ReadToEnd();                  //读取网页内容  
                    reader.Close();
                    datastream.Close();
                    response.Close();
                }
            }
            catch { }
            return htmlStr;
        }
    }
}
