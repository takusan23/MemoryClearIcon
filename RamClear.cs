using System.Diagnostics;

namespace MemoryClearIcon
{
    class RamClear
    {
        /// <summary>
        /// メモリを開放する。empty.exeを実行する関数。同期処理
        /// </summary>
        public static void Clear()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c ";
            startInfo.Arguments += @"C:\Windows\System32\empty.exe ";
            startInfo.Arguments += "*";
            var proc = Process.Start(startInfo);
            proc.WaitForExit();
        }

        /// <summary>
        /// 空きメモリを返す
        /// </summary>
        /// <returns></returns>
        public static float GetFreeRamMB()
        {
            var ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            return ramCounter.NextValue();
        }

    }
}
