using Notifications.Wpf;
using System;
using System.Windows.Input;

namespace MemoryClearIcon
{
    /// <summary>
    /// NotifyIconをダブルクリックしたときに呼ばれる。
    /// </summary>
    public class ShowMessageCommand : ICommand
    {
        public void Execute(object parameter)
        {
            // メモリ開放
            RamClear.Clear();
            // 解放結果
            var notificationManager = new NotificationManager();
            notificationManager.Show(new NotificationContent
            {
                Title = "メモリ開放を実行しました",
                Message = $"現在の空きメモリ{RamClear.GetFreeRamMB() / 1000F}GB",
                Type = NotificationType.Information
            });
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
