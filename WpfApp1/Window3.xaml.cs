using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();

        }
        
        private void timerTick(object sender, EventArgs e)
        {
            driveinf.Content = null;
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                driveinf.Content += Convert.ToString($"Диск {d}, {d.Name}  {'\n'}" +
                    $" Тип диска: {d}, {d.DriveType} {'\n'}");
                    
                if (d.IsReady)
                {
                    driveinf.Content += Convert.ToString($"Доступно на диске: {d.TotalFreeSpace} байт  {'\n'}" +
                        $"Размер диска: {d.TotalSize} байт");
                }
                driveinf.Content += $"{'\n'} {'\n'}";
            }
            
        }
    }
}
