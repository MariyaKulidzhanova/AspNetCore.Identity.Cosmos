﻿using Microsoft.Extensions.Options;
using Mobsites.AspNetCore.Identity.Cosmos;

namespace Extended.Cosmos.Identity.Razor.Sample_2._2.Extensions
{
    /// <summary>
    ///     Represents a new instance of an extended Cosmos storage provider which inherits <see cref="CosmosStorageProvider"/>. 
    ///     Since the class is register for dependency injection, it can be passed into any constructor where desired.
    /// </summary>
    public class ExtendedCosmosStorageProvider : CosmosStorageProvider
    {
        public ExtendedCosmosStorageProvider(IOptions<CosmosStorageProviderOptions> optionsAccessor) : base(optionsAccessor)
        {
            // ToDo: Add members for handling other application model types not directly related to identity.
            //       And/or have other application model types implement the ICosmosStorageType interface so that base members, such as CreateAsync, can be used for them as well.
        }
    }
}
