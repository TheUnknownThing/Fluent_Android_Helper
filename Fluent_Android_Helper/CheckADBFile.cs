using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fluent_Android_Helper
{
    class CheckADBFile
    {
        public static void checkADBExsist()
        {
            bool isAllFileOK = true;
            List<string> check = new List<string>();
            List<string> name = new List<string>();
            check.Add( AppDomain.CurrentDomain.BaseDirectory + "adb.exe");
            check.Add(AppDomain.CurrentDomain.BaseDirectory + "fastboot.exe");
            check.Add(AppDomain.CurrentDomain.BaseDirectory + "AdbWinApi.dll");
            check.Add(AppDomain.CurrentDomain.BaseDirectory + "AdbWinUsbApi.dll");
            check.Add(AppDomain.CurrentDomain.BaseDirectory + "libwinpthread-1.dll");
            name.Add("ADB.exe");
            name.Add("Fastboot.exe");
            name.Add("AdbWinApi.dll");
            name.Add("AdbWinUsbApi.dll");
            name.Add("libwinthread-1.dll");
            for (int i = 0; i < check.Count(); i++)
            {
                if (!File.Exists(check[i]))
                {
                    ModernWpf.MessageBox.Show("缺失文件"+name[i]+",请检查杀软");
                    isAllFileOK = false;
                }
                if (i == check.Count - 1 && isAllFileOK == true)
                {
                    ModernWpf.MessageBox.Show("无文件缺失");
                }
            }
            
        }
        
        
    }
}
