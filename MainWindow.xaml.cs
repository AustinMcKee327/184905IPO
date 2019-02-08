/*Austin McKee
 * Feb 8, 2019
 * This program is for calculating deck area using length and width
 */
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

namespace _184905IPO
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            Double Length;
            Double Width;
            Double Area;
            Double.TryParse(txtLength.Text, out Length);
            Double.TryParse(txtWidth.Text, out Width);

            Area = Length * Width;
            lblOutput.Content = "The Area is:" + Area.ToString("#.00");
        }
    }
}
