using System.Diagnostics;
using System.Windows;

namespace MemoryClearIcon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// なお、クリックイベントはShowMessageCommand.csに、メモリ開放はRamClear.csに、タスクトレイのアイコンはMainWindow.xamlにそれぞれ書いてあります。
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // ウインドウいらないので消す
            Hide();
        }


        /// <summary>
        /// 終了させる
        /// </summary>
        private void MenuItemClickExit(object sender, RoutedEventArgs e) => Application.Current.Shutdown();
    }
}
