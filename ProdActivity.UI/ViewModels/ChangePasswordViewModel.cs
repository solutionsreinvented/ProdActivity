using System.Windows.Input;

using ProdActivity.UI.Commands;
using ProdActivity.UI.Stores;

namespace ProdActivity.UI.ViewModels
{
    public class ChangePasswordViewModel : ViewModelBase
    {
        public ChangePasswordViewModel(NavigationStore navigationStore) : base(navigationStore)
        {
            SubmitCommand = new RelayCommand(OnPasswordChange, true);
        }

        private void OnPasswordChange()
        {
            _navigationStore.CurrentViewModel = new LoginViewModel(_navigationStore);
        }

        public bool CanChangePassword => ValidUsername() && PasswordsMatch();

        public string Username
        {
            get => Get<string>();
            set
            {
                Set(value);
                RaisePropertyChanged(nameof(CanChangePassword));
            }
        }

        public string CurrentPassword
        {
            get => Get<string>();
            set
            {
                Set(value);
                RaisePropertyChanged(nameof(CanChangePassword));
            }
        }

        public string NewPassword
        {
            get => Get<string>();
            set
            {
                Set(value);
                RaisePropertyChanged(nameof(CanChangePassword));
            }
        }

        public string ConfirmPassword
        {
            get => Get<string>();
            set
            {
                Set(value);
                RaisePropertyChanged(nameof(CanChangePassword));
            }
        }

        public ICommand SubmitCommand { get => Get<ICommand>(); set => Set(value); }

        private bool ValidUsername() => !string.IsNullOrEmpty(Username);

        private bool PasswordsMatch() => !string.IsNullOrEmpty(NewPassword) && !string.IsNullOrEmpty(ConfirmPassword) && NewPassword == ConfirmPassword;

    }
}
