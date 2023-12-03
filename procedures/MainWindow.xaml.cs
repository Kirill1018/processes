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
using System.Diagnostics;
using System.Threading;
using System.Xaml;
using System.Data.SqlTypes;

namespace procedures
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            while (true)
            {
                Process[] processes = Process.GetProcesses().OrderBy(process => process.ProcessName.ToString()).ToArray();
                DataContext = processes;
                Thread.Sleep(3000);
            }
        }

        private void proc_kill_Click(object sender, RoutedEventArgs e)
        {
            Process selected = (Process)list.SelectedItem;
            selected.Kill();
        }
    }
}