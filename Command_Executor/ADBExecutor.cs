using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Executor
{
    class ADBExecutor
    {
        public static string input { get; set; }
        public static string output { get; set; }
        public static bool CommandExecutor()
        {
            string str0 = ADBExecutor.input;
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = false;
            p.Start();
            p.StandardInput.WriteLine(str0 + "&exit");
            p.StandardInput.AutoFlush = true;
            ADBExecutor.output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            p.Close();
            return true;
        }
    }
}
