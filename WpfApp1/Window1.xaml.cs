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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private int i = 0;
        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Color[] color = new Color[7];
                color[0] = Color.FromRgb(255, 0, 0);
                color[1] = Color.FromRgb(0, 255, 0);
                color[2] = Color.FromRgb(0, 0, 255);
                color[3] = Color.FromRgb(0, 0, 0);
                color[4] = Color.FromRgb(255, 255, 255);
                color[5] = Color.FromRgb(255, 251, 0);
                color[6] = Color.FromRgb(252, 0, 255);
                frme1.Background = new SolidColorBrush(color[i]);
                i++;
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Тест монитора завершен");
                this.Close();
            }

        }

        private void Dt_Tick(object sender, EventArgs e)
        {

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                Color[] color = new Color[7];
                color[0] = Color.FromRgb(255, 0, 0);
                color[1] = Color.FromRgb(0, 255, 0);
                color[2] = Color.FromRgb(0, 0, 255);
                color[3] = Color.FromRgb(0, 0, 0);
                color[4] = Color.FromRgb(255, 255, 255);
                color[5] = Color.FromRgb(255, 251, 0);
                color[6] = Color.FromRgb(252, 0, 255);
                frme1.Background = new SolidColorBrush(color[i]);
                i++;
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Тест монитора завершен");
                this.Close();
            }
        }
    }
}
