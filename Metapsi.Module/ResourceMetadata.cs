namespace Metapsi.Syntax
{
    public class ResourceMetadata
    {
        public string PackageName { get; set; }
        public string PackageVersion { get; set; }
        public string LogicalName { get; set; }
        public string FileHash { get; set; }
    }

    public static class ResourceMetadataExtensions
    {
        public static string GetIdentifierPath(this ResourceMetadata resourceMetadata)
        {
            var resourceIdentifier = $"/{resourceMetadata.PackageName}/{resourceMetadata.PackageVersion}/{resourceMetadata.LogicalName}";
            return resourceIdentifier;
        }

        public static string GetDefaultHttpPath(this ResourceMetadata resourceMetadata)
        {
            var withDefaults = new ResourceMetadata()
            {
                PackageName = resourceMetadata.PackageName,
                PackageVersion = resourceMetadata.PackageVersion,
                LogicalName = resourceMetadata.LogicalName,
                FileHash = resourceMetadata.FileHash
            };

            if (string.IsNullOrWhiteSpace(withDefaults.PackageName)) withDefaults.PackageName = "-";
            if (string.IsNullOrWhiteSpace(withDefaults.PackageVersion)) withDefaults.PackageVersion = "0";

            var relativePath = withDefaults.LogicalName.Trim('/');

            var defaultResourcePath = $"/r/{withDefaults.PackageName}/{withDefaults.PackageVersion}/{relativePath}";
            if (!string.IsNullOrWhiteSpace(withDefaults.FileHash))
                defaultResourcePath += $"?h={withDefaults.FileHash}";

            return defaultResourcePath;
        }
    }
}