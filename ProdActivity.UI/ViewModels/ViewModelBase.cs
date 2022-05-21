
using ProdActivity.Domain.Stores;
using ProdActivity.UI.Stores;

namespace ProdActivity.UI.ViewModels
{
    public abstract class ViewModelBase : PropertyStore
    {
        private protected readonly NavigationStore _navigationStore;

        public ViewModelBase(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
    }
}
