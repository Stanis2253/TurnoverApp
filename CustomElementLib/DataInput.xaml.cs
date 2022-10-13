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

namespace CustomElementLib
{
    /// <summary>
    /// Логика взаимодействия для DataInput.xaml
    /// </summary>
    public partial class DataInput : UserControl
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public DataInput()
        {
            InitializeComponent();
            this.DataContext = this;
            tb.Name = Name;
        }
    }
}
