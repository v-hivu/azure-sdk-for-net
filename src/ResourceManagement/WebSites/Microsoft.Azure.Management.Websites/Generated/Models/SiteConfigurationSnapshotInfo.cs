// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Azure;
    using Management;
    using WebSites;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A snapshot of a web app configuration.
    /// </summary>
    [JsonTransformation]
    public partial class SiteConfigurationSnapshotInfo : Resource
    {
        /// <summary>
        /// Initializes a new instance of the SiteConfigurationSnapshotInfo
        /// class.
        /// </summary>
        public SiteConfigurationSnapshotInfo() { }

        /// <summary>
        /// Initializes a new instance of the SiteConfigurationSnapshotInfo
        /// class.
        /// </summary>
        /// <param name="location">Resource Location.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="time">The time the snapshot was taken.</param>
        /// <param name="siteConfigurationSnapshotInfoId">The id of the
        /// snapshot</param>
        public SiteConfigurationSnapshotInfo(string location, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), System.DateTime? time = default(System.DateTime?), int? siteConfigurationSnapshotInfoId = default(int?))
            : base(location, id, name, kind, type, tags)
        {
            Time = time;
            SiteConfigurationSnapshotInfoId = siteConfigurationSnapshotInfoId;
        }

        /// <summary>
        /// Gets the time the snapshot was taken.
        /// </summary>
        [JsonProperty(PropertyName = "properties.time")]
        public System.DateTime? Time { get; protected set; }

        /// <summary>
        /// Gets the id of the snapshot
        /// </summary>
        [JsonProperty(PropertyName = "properties.id")]
        public int? SiteConfigurationSnapshotInfoId { get; protected set; }

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

