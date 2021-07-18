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
using WpfApp2.controller;
using WpfApp2.model;
namespace WpfApp2.views
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            controller.VMlivros mycontroller = new controller.VMlivros();
            mycontroller.inserlivro(nome.Text,ediçao.Text,Int32.Parse(ano.Text));
      
            gridview.ItemsSource =mycontroller.getlivro();
        }

        private void Page_Initialized(object sender, EventArgs e)
        {
            controller.VMlivros vmlivro = new controller.VMlivros();
            gridview.ItemsSource = vmlivro.getlivro();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            controller.VMlivros mycontroller = new controller.VMlivros();
            mycontroller.dellivro((livros)gridview.SelectedItem);

        }
    }
}
