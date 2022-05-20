using System.ComponentModel;

using ProdActivity.UI.Stores;

namespace ProdActivity.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;

        public MainViewModel()
        {
            _navigationStore = new NavigationStore();
            _navigationStore.CurrentViewModel = new LoginViewModel(_navigationStore);
            _navigationStore.PropertyChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
    }
}
