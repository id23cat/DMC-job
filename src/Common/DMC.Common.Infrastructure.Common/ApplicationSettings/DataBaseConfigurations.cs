using DMC.Common.Infrastructure.Common.Enums;

namespace DMC.Common.Infrastructure.Common.ApplicationSettings
{
    public class DataBaseConfigurations
    {
        public string ConnectionString { get; set; }

        public DbProviderType Provider { get; set; }
    }
}