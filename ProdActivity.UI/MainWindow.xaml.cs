using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

using Newtonsoft.Json;

using ProdActivity.Domain.Enums;
using ProdActivity.Domain.Extensions;
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

            DateTime dateTime = new(2022, 05, 19, 9, 10, 0);

            var holidays = GetHolidaysList();

            MessageBox.Show($"Next business hour: {dateTime.NextBusinessHour(90, holidays)}");

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

        private HashSet<DateTime> GetHolidaysList()
        {
            return new HashSet<DateTime>()
            {
                new DateTime(2022, 01, 01),
                new DateTime(2022, 01, 26),
                new DateTime(2022, 03, 01),
                new DateTime(2022, 04, 15),
                new DateTime(2022, 05, 01),
                new DateTime(2022, 08, 15),
                new DateTime(2022, 08, 31),
                new DateTime(2022, 10, 02),
                new DateTime(2022, 10, 04),
                new DateTime(2022, 10, 05),
                new DateTime(2022, 10, 24),
                new DateTime(2022, 10, 26),
                new DateTime(2022, 11, 01)
            };
        }


    }
}
