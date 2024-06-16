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
using Wpf_MVVM_App.ViewModel;

namespace Wpf_MVVM_App.Views
{
    /// <summary>
    /// Interaction logic for ShowText.xaml
    /// </summary>
    public partial class ShowText : Window
    {
        public ShowText()
        {
            InitializeComponent();

            //ShowTextViewModel showTextVM = new ShowTextViewModel();
            //this.DataContext = showTextVM;

            //RTxtbox.AppendText(Title);
        }
    }
}
