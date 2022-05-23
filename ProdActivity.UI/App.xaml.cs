using System.Windows;

using ProdActivity.UI.Stores;
using ProdActivity.UI.ViewModels;

namespace ProdActivity.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            NavigationStore navigationStore = new();

            ///            navigationStore.CurrentViewModel = new LoginViewModel(navigationStore);

            navigationStore.CurrentViewModel = new CreateActivityViewModel(navigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigationStore)
            };

            MainWindow.Show();

        }
    }
}
