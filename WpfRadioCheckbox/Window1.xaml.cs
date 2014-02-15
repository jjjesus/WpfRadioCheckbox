using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace WpfRadioCheckbox
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            ViewModel = new Window1ViewModel();
            DataContext = ViewModel;
            InitializeComponent();
        }
        public Window1ViewModel ViewModel { get; set; }
        private void LoadModel(object sender, RoutedEventArgs e)
        {
            ViewModel.Load();
        }
    }
}
