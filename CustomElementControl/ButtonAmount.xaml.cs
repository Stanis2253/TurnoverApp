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

namespace CustomElementControl
{
    /// <summary>
    /// Логика взаимодействия для ButtonAmount.xaml
    /// </summary>
    public partial class ButtonAmount : UserControl
    {

        private string Count = "0";

        public string Size { get; set; }

        public int Amount { get; set; }

        public ButtonAmount()
        {
            InitializeComponent();
        }


        private void Reduce(object sender, RoutedEventArgs e)
        {
            Amount--;

            Count = Amount.ToString();
        }

        private void Increase(object sender, RoutedEventArgs e)
        {
            Amount++;

            Count = Amount.ToString();
        }
    }
}
