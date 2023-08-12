using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace ProjectHoaDonApp_New
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonExport_Click(object sender, RoutedEventArgs e)
        {
            string fileName = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Invoice_online1\Invoice_online1\Invoice_online1.py";

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Invoice_online1\Invoice_online1\env\Scripts\python.exe";
            startInfo.Arguments = fileName;
            startInfo.StandardOutputEncoding = Encoding.UTF8;

            process.StartInfo = startInfo;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            MessageBox.Show("Quá trình trích xuất hóa đơn hoàn tất");
        }
    }
}
