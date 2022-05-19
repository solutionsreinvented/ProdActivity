using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

using Newtonsoft.Json;

using ProdActivity.Domain.Enums;
using ProdActivity.Domain.Interfaces;
using ProdActivity.Domain.Models;
using ProdActivity.Domain.Repositories;

namespace ProdActivity.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ///StoreResourcesData();

            RetrieveResourcesData();

        }

        private void RetrieveResourcesData()
        {

            EngineeringResourcesRepository engineeringResourcesRepository = new();
            List<IEngineeringResource> engineeringResources = engineeringResourcesRepository.GetAll();

            IEngineeringResource srinivas = engineeringResources[0];

            DesignActivity newActivity = new(1)
            {
                ActivityType = EngineeringActivityType.Design,
                InitiatedOn = DateTime.Now,
                ProjectType = ProjectType.Order,
                Description = "Bridge Design 33m Thickener",
                CurrentStatus = CompletionStatus.OnTrack
            };

            _ = newActivity.AllocatedResources.Add(srinivas);

            newActivity.SetCompletionInHours(72);

            srinivas.Activities.Add(newActivity);



        }

        private void StoreResourcesData()
        {
            ///var serializedData = jsonDataSerializer.Serialize(GetEngineeringResources());

            ///File.WriteAllText(path, serializedData);
        }

        private List<IEngineeringResource> GetEngineeringResources()
        {
            List<IEngineeringResource> engineeringResources = new()
            {
                new LeadEngineer(5941241) { FirstName = "Srinivasa Rao", LastName = "Masanam" },
                new Engineer(5941241) { FirstName = "Harish", LastName = "Ramachandran" },
                new Engineer(5941241) { FirstName = "Ragavendiran", LastName = "Murugan" },
                new Engineer(5941241) { FirstName = "Dinesh Kumar", LastName = "Sukumaran" },
                new Drafter(5941241) { FirstName = "Vinayaka", LastName = "Shinde" },
                new Drafter(5941241) { FirstName = "Vinayaka", LastName = "Shinde" },
                new Drafter(5941241) { FirstName = "Vinayaka", LastName = "Shinde" },
                new Drafter(5941241) { FirstName = "Vinayaka", LastName = "Shinde" }
            };

            return engineeringResources;
        }




    }
}
