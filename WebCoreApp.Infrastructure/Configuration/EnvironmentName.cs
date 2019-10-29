namespace WebCoreApp.Infrastructure.Configuration
{
    public static class EnvironmentName
    {
        /// <summary>Indicates that the current environment is for developing the application.</summary>
        public static readonly string Development = nameof(Development);

        /// <summary>Indicates that the current environment is for staging the application.</summary>
        public static readonly string Staging = nameof(Staging);

        /// <summary>Indicates that the current environment is for demoing the application.</summary>
        public static readonly string Demo = nameof(Demo);

        /// <summary>Indicates that the current environment is for live hosting of the application.</summary>
        public static readonly string Production = nameof(Production);
    }
}
