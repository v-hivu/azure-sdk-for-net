// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Analytics;
    using Azure;
    using DataLake;
    using Management;
    using Azure;
    using Management;
    using DataLake;
    using Analytics;
    using Newtonsoft.Json;
    using Rest;
    using Rest.Serialization;
    using System.Linq;

    /// <summary>
    /// Data Lake Store account information.
    /// </summary>
    [JsonTransformation]
    public partial class DataLakeStoreAccountInfo : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the DataLakeStoreAccountInfo class.
        /// </summary>
        public DataLakeStoreAccountInfo() { }

        /// <summary>
        /// Initializes a new instance of the DataLakeStoreAccountInfo class.
        /// </summary>
        /// <param name="name">Resource name</param>
        /// <param name="id">Resource Id</param>
        /// <param name="type">Resource type</param>
        /// <param name="suffix">the optional suffix for the Data Lake Store
        /// account.</param>
        public DataLakeStoreAccountInfo(string name, string id = default(string), string type = default(string), string suffix = default(string))
            : base(name, id, type)
        {
            Suffix = suffix;
        }

        /// <summary>
        /// Gets or sets the optional suffix for the Data Lake Store account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.suffix")]
        public string Suffix { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}



