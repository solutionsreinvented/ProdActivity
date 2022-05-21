using System.ComponentModel;

using ProdActivity.UI.Stores;

namespace ProdActivity.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(NavigationStore navigationStore) : base(navigationStore)
        {
            _navigationStore.PropertyChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
    }
}
