using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection.Emit;

namespace SnowRunnerFix
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string commandClose = "taskkill /f /im explorer.exe";

        private bool ExplorerIsClosed = false;

        string explorerPath = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\explorer.exe");

        public MainWindow()
        {
            InitializeComponent();
            /// checking for process of SnowRunner
            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1); //set delay 1 sec
            timer.IsEnabled = true;
            timer.Tick += (o, e) => { SearchProccess(); };
            timer.Start();
            /// Just a Clocks
            var timer2 = new System.Windows.Threading.DispatcherTimer();
            timer2.Interval = new TimeSpan(0, 0, 1);
            timer2.IsEnabled = true;
            timer2.Tick += (o, e) => { Clocks.Content = DateTime.Now.ToString(); };
            timer2.Start();
        }

        private void StartExp_Button_Click(object sender, RoutedEventArgs e)
        {
            StartExplorer();
        }
        private void CloseExp_Button_Click(object sender, RoutedEventArgs e)
        {
            CloseExplorer();
        }        

        private void StartExplorer()
        {            
            if (Environment.Is64BitOperatingSystem)
            {
                Process.Start(explorerPath);
            }
            else
            {
                Process.Start("explorer.exe");
            }
        }

        private void CloseExplorer()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.StandardInput.WriteLine(commandClose);
            process.StandardInput.Close();
            process.WaitForExit();
            process.Close();
        }

        private void SearchProccess()
        {            
            Process[] processes = Process.GetProcessesByName("SnowRunner");               
            if (processes.Length > 0)
            {
                if (!ExplorerIsClosed)
                {
                    CloseExplorer();
                    ExplorerIsClosed = true;
                }
            }
            else
            {
                if (ExplorerIsClosed)
                {
                    StartExplorer();
                    ExplorerIsClosed = false;
                }
            }                
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var res = MessageBox.Show("Really close?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (res != MessageBoxResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
