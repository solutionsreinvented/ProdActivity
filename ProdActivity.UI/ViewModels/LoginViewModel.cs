using System;
using System.Linq;
using System.Windows.Input;

using ProdActivity.UI.Commands;
using ProdActivity.UI.Stores;

namespace ProdActivity.UI.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel(NavigationStore navigationStore) : base(navigationStore)
        {
            ChangePasswordCommand = new RelayCommand(OnChangePassword, true);
            LogInCommand = new RelayCommand(OnLogIn, true);
        }

        private void OnLogIn()
        {
            if (IsValidUser)
            {
                _navigationStore.CurrentViewModel = new DashboardViewModel(_navigationStore)
                {
                    
                };
            }
        }

        private void OnChangePassword()
        {
            _navigationStore.CurrentViewModel = new ChangePasswordViewModel(_navigationStore)
            {
                Username = Username,
                CurrentPassword = Password
            };
        }

        public string Username
        {
            get => Get<string>();
            set
            {
                Set(value);
                OnPropertyChanged(nameof(IsValidUser));
            }
        }

        public string Password
        {
            get => Get<string>();
            set
            {
                Set(value);
                OnPropertyChanged(nameof(IsValidUser));
            }
        }

        public bool IsValidUser => ValidUser() && ValidPassword();

        private bool ValidUser()
        {
            return !string.IsNullOrEmpty(Username) && (Username.Length is >= 8 and <= 15);
        }

        private bool ValidPassword()
        {
            return !string.IsNullOrEmpty(Password) && (Password.Length is >= 8 and <= 15) && Password.Any(c => char.IsDigit(c));
        }

        public bool IsLoggedIn { get => Get<bool>(); set => Set(value); }

        public ICommand ChangePasswordCommand { get; set; }

        public ICommand LogInCommand { get; set; }

    }
}
