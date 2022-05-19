namespace ProdActivity.Domain.Services
{
    public static class FileServiceProvider
    {
        private static string _dataDirectoryPath = @"C:\Source\ProdActivity\ProdActivity.Domain\Data\";

        public static string GetDataDirectory() => _dataDirectoryPath;
    }
}
