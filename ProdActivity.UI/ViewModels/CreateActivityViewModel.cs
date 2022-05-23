using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

using ProdActivity.Domain.Enums;
using ProdActivity.Domain.Interfaces;
using ProdActivity.Domain.Repositories;
using ProdActivity.UI.Stores;

namespace ProdActivity.UI.ViewModels
{
    public class CreateActivityViewModel : ViewModelBase
    {
        public CreateActivityViewModel(NavigationStore navigationStore) : base(navigationStore)
        {
            InitializeProperties();
        }

        private void InitializeProperties()
        {
            Title = "Create Activity";

            EngineeringResourcesRepository engineeringResourcesRepository = new();

            Resources = engineeringResourcesRepository.GetAll();
        }

        public string Title { get => Get<string>(); set => Set(value); }

        public IEnumerable<IEngineeringResource> Resources { get => Get<IEnumerable<IEngineeringResource>>(); set => Set(value); }

        public IEnumerable<IEngineeringActivity> Activities => SelectedResource?.Activities;


        public IEngineeringResource SelectedResource
        {
            get => Get(Resources?.First());
            set
            {
                Set(value);
                OnPropertyChanged(nameof(Activities));
            }
        }

        public IEngineeringActivity SelectedActivity { get => Get<IEngineeringActivity>(); set => Set(value); }

        public DateTime StartDate { get => Get<DateTime>(); set => Set(value); }

        public DateTime EndDate { get => Get<DateTime>(); set => Set(value); }

        public ICommand CreateActivityCommand { get; set; }

        public ICommand CancelCreateActivityCommand { get; set; }
    }
}
