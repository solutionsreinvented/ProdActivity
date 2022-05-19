﻿using ProdActivity.Domain.Enums;
using ProdActivity.Domain.Interfaces;
using ProdActivity.Domain.Stores;

namespace ProdActivity.Domain.Models
{
    public class Change : PropertyStore
    {
        public Change()
        {

        }

        public int Serial { get => Get<int>(); set => Set(value); }

        public ScheduleChangeReason RescheduleReason { get => Get(ScheduleChangeReason.PriorityChange); set => Set(value); }

        public IEngineeringActivity AffectedActivity { get => Get<IEngineeringActivity>(); set => Set(value); }

        public IEngineeringActivity SupercedingActivity { get => Get<IEngineeringActivity>(); set => Set(value); }

    }
}
