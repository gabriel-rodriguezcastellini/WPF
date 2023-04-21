using Exercise7.Stores;
using Exercise7.ViewModels;
using System.Windows;

namespace Exercise7.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        public MainWindow(SelectedNameStore selectedNameStore)
        {
            DataContext = new ViewModel(selectedNameStore);
            InitializeComponent();
        }
    }
}
