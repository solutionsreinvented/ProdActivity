using System.ComponentModel;

using ProdActivity.UI.ViewModels;

namespace ProdActivity.UI.Stores
{
    public class NavigationStore
    {
        private ViewModelBase _currentViewModel;

        public event PropertyChangedEventHandler PropertyChanged;

        public NavigationStore()
        {
            ///CurrentViewModel = new ChangePasswordViewModel(this);
        }

        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                if (_currentViewModel != value)
                {
                    _currentViewModel = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentViewModel)));
                }
            }
        }

    }
}
