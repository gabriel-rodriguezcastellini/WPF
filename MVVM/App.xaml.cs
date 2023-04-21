using MVVM.Stores;
using MVVM.Views;
using System.Windows;

namespace MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedNameStore _selectedNameStore;

        public App()
        {
            _selectedNameStore = new SelectedNameStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow(_selectedNameStore);
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
