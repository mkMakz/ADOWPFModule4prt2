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

namespace ADOWPFModule4prt2
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

        private void GetData_Click(object sender, RoutedEventArgs e)
        {
            GroupFrame.Source = new Uri("Pages/ListGroup.xaml", UriKind.RelativeOrAbsolute);
        }

        private void GetData2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GetData3_Click(object sender, RoutedEventArgs e)
        {

        }


        private void GetData4_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
