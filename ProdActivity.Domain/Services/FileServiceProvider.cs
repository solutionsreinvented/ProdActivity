namespace ProdActivity.Domain.Services
{
    public static class FileServiceProvider
    {
        private static readonly string _dataDirectoryPath = @"C:\Users\srini\source\local-source\ProdActivity\ProdActivity.Domain\Data\";

        public static string GetDataDirectory() => _dataDirectoryPath;
    }
}
