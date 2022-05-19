using System.Collections.Generic;
using System.IO;

using ProdActivity.Domain.Base;
using ProdActivity.Domain.Interfaces;
using ProdActivity.Domain.Mappers;
using ProdActivity.Domain.Services;

using SRi.XamlUIThickenerApp.DataAccess;

namespace ProdActivity.Domain.Repositories
{
    public class EngineeringResourcesRepository
    {
        private const string _fileName = @"EngineeringResources.json";

        private readonly JsonDataSerializer<List<EngineeringResource>> _jsonDataSerializer = new();

        public EngineeringResourcesRepository()
        {

        }

        public List<IEngineeringResource> GetAll()
        {
            string fileFullPath = Path.Combine(FileServiceProvider.GetDataDirectory(), _fileName);

            return ClassToInterfaceMapper<EngineeringResource, IEngineeringResource>.Map(_jsonDataSerializer.Deserialiaze(fileFullPath));
        }

    }
}
