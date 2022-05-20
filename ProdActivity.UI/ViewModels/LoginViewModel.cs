using System.Windows.Input;

using ProdActivity.UI.Commands;
using ProdActivity.UI.Stores;

namespace ProdActivity.UI.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;

        public LoginViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            ChangePasswordCommand = new RelayCommand(OnChangePassword, true);
        }

        private void OnChangePassword()
        {
            _navigationStore.CurrentViewModel = new ChangePasswordViewModel(_navigationStore);
        }

        public string Username { get => Get<string>(); set => Set(value); }

        public object Password { get => Get<string>(); set => Set(value); }

        public bool IsLoggedIn { get => Get<bool>(); set => Set(value); }

        public ICommand ChangePasswordCommand { get; set; }


    }
}
