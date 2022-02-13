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

namespace Task_WPF17
{
    /// <summary>
    /// Логика взаимодействия для CollorSetting.xaml
    /// </summary>
    public partial class CollorSetting : UserControl
    {
        public CollorSetting()
        {
            InitializeComponent();
        }

        private void Color_Changed(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ColorS.Fill = new SolidColorBrush(Color.FromRgb((byte)redS.Value,
                (byte)greenS.Value, (byte)blueS.Value));
        }

        public Brush GetColor
        {
            get
            {
                return ColorS.Fill;
            }
        }
    }
}
