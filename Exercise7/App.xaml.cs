using Exercise7.Stores;
using Exercise7.Views;
using System.Windows;

namespace Exercise7
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
