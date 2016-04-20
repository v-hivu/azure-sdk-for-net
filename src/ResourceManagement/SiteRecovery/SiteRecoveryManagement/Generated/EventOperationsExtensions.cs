// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.SiteRecovery;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery
{
    public static partial class EventOperationsExtensions
    {
        /// <summary>
        /// Get the list of events under the vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IEventOperations.
        /// </param>
        /// <param name='eventName'>
        /// Required. Filter for the events to be fetched.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// Model class for event response.
        /// </returns>
        public static EventResponse Get(this IEventOperations operations, string eventName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IEventOperations)s).GetAsync(eventName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the list of events under the vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IEventOperations.
        /// </param>
        /// <param name='eventName'>
        /// Required. Filter for the events to be fetched.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// Model class for event response.
        /// </returns>
        public static Task<EventResponse> GetAsync(this IEventOperations operations, string eventName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetAsync(eventName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the list of events under the vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IEventOperations.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Filter for the events to be fetched.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list events operation.
        /// </returns>
        public static EventListResponse List(this IEventOperations operations, EventQueryParameter parameters, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IEventOperations)s).ListAsync(parameters, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the list of events under the vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.SiteRecovery.IEventOperations.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Filter for the events to be fetched.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The response model for the list events operation.
        /// </returns>
        public static Task<EventListResponse> ListAsync(this IEventOperations operations, EventQueryParameter parameters, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListAsync(parameters, customRequestHeaders, CancellationToken.None);
        }
    }
}