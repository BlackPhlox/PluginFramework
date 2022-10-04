using System;
using NuGet.Common;
using Weikio.NugetDownloader;
using Weikio.PluginFramework.Abstractions;
using Weikio.PluginFramework.Catalogs.NuGet;
using Weikio.PluginFramework.TypeFinding;

namespace Weikio.PluginFramework.Catalogs.NuGet
{
    public class NugetFeedPluginCatalogOptions
    {
        /// <summary>
        /// Gets or sets the function which is used to create the logger for Nuget activities
        /// </summary>
        public Func <ILogger> LoggerFactory { get; set; } = Defaults.LoggerFactory;
        
        /// <summary>
        /// Gets or sets the <see cref="TypeFinderOptions"/>. 
        /// </summary>
        public TypeFinderOptions TypeFinderOptions { get; set; } = new TypeFinderOptions();

        /// <summary>
        /// Gets or sets how the plugin names and version should be defined. <seealso cref="PluginNameOptions"/>.
        /// </summary>
        public PluginNameOptions PluginNameOptions { get; set; } = Defaults.PluginNameOptions;
        
        /// <summary>
        /// Gets or sets if Plugin Framework should take care of package caching. In some cases Nuget will download already downloaded package. This flag
        /// tries to make sure that the package is downloaded only once. Note: Requires that PackagesFolder is set
        /// </summary>
        public bool ForcePackageCaching { get; set; } = false;
        
        public static class Defaults
        {
            /// <summary>
            /// Gets or sets the default function which is used to create the logger for PluginLoadContextOptions
            /// </summary>
            public static Func<ILogger> LoggerFactory { get; set; } = () => new ConsoleLogger();
            
            public static PluginNameOptions PluginNameOptions { get; set; } = new PluginNameOptions();
        }
    }
}
