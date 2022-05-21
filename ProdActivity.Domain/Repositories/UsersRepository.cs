using System.Collections.Generic;
using System.IO;

using ProdActivity.Domain.Base;
using ProdActivity.Domain.Interfaces;
using ProdActivity.Domain.Mappers;
using ProdActivity.Domain.Services;

using SRi.XamlUIThickenerApp.DataAccess;

namespace ProdActivity.Domain.Repositories
{
    public class UsersRepository
    {
        private const string _fileName = @"users.json";

        private readonly JsonDataSerializer<List<User>> _jsonDataSerializer;

        public UsersRepository()
        {
            _jsonDataSerializer = new();
        }

        public List<IUser> GetAllUsers()
        {
            string fileFullPath = Path.Combine(FileServiceProvider.GetDataDirectory(), _fileName);

            return ClassToInterfaceMapper<User, IUser>.Map(_jsonDataSerializer.Deserialiaze(fileFullPath));
        }
    }
}
