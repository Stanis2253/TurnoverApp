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
    /// Логика взаимодействия для LabelOutput.xaml
    /// </summary>
    public partial class LabelOutput : UserControl
    {
        public string Value { get; set; }
        new public string Content { get; set; }
        public LabelOutput()
        {
            InitializeComponent();
        }
    }
}
