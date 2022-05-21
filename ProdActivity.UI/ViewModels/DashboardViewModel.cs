using ProdActivity.UI.Stores;

namespace ProdActivity.UI.ViewModels
{
    public class DashboardViewModel : ViewModelBase
    {
        public DashboardViewModel(NavigationStore navigationStore) : base(navigationStore)
        {

        }

        public string Title { get; set; } = "I am the dashboard!";
    }
}
