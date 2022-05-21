using System.Windows.Input;

using ProdActivity.UI.Stores;

namespace ProdActivity.UI.ViewModels
{
    public class CreateActivityViewModel : ViewModelBase
    {
        public CreateActivityViewModel(NavigationStore navigationStore) : base(navigationStore)
        {

        }

        public ICommand CreateActivityCommand { get; set; }

        public ICommand CancelCreateActivityCommand { get; set; }
    }
}
