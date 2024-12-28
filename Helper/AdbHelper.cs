using System.Diagnostics;

namespace MobileProxyApi.Helper
{
    public static class AdbHelper
    {
        private static void RunAdbCommand(string command, string workingDirectory = "platform-tools")
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.WorkingDirectory = "C:\\platform-tools";
            process.StartInfo.Arguments = "/c " + command;
            process.Start();
            process.WaitForExit();
        }

        public static void StartProcess()
        {
            RunAdbCommand("adb shell svc data disable");
            RunAdbCommand("adb shell svc data enable");
        }
    }
}
