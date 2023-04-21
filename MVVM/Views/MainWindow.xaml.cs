using MVVM.Stores;
using MVVM.ViewModels;
using System.Windows;

namespace MVVM.Views
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
