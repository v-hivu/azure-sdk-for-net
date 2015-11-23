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
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Hyak.Common.Internals;
using Microsoft.Azure.Management.SiteRecovery;
using Microsoft.Azure.Management.SiteRecovery.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.SiteRecovery
{
    /// <summary>
    /// Definition of alert settings operations for the Site Recovery extension.
    /// </summary>
    internal partial class AlertSettingsOperations : IServiceOperations<SiteRecoveryManagementClient>, IAlertSettingsOperations
    {
        /// <summary>
        /// Initializes a new instance of the AlertSettingsOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal AlertSettingsOperations(SiteRecoveryManagementClient client)
        {
            this._client = client;
        }
        
        private SiteRecoveryManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.SiteRecovery.SiteRecoveryManagementClient.
        /// </summary>
        public SiteRecoveryManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Updates the alert settings for the vault.
        /// </summary>
        /// <param name='alertSettingsName'>
        /// Required. Alert Settings name.
        /// </param>
        /// <param name='input'>
        /// Required. Configure Alerts Request.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Model class for alerts response.
        /// </returns>
        public async Task<AlertSettingsResponse> ConfigureAsync(string alertSettingsName, ConfigureAlertSettingsRequest input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            if (alertSettingsName == null)
            {
                throw new ArgumentNullException("alertSettingsName");
            }
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("alertSettingsName", alertSettingsName);
                tracingParameters.Add("input", input);
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "ConfigureAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/Subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(this.Client.ResourceGroupName);
            url = url + "/providers/";
            url = url + Uri.EscapeDataString(this.Client.ResourceNamespace);
            url = url + "/";
            url = url + Uri.EscapeDataString(this.Client.ResourceType);
            url = url + "/";
            url = url + Uri.EscapeDataString(this.Client.ResourceName);
            url = url + "/replicationAlertSettings/";
            url = url + Uri.EscapeDataString(alertSettingsName);
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2015-11-10");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Put;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept-Language", customRequestHeaders.Culture);
                httpRequest.Headers.Add("x-ms-client-request-id", customRequestHeaders.ClientRequestId);
                httpRequest.Headers.Add("x-ms-version", "2015-01-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                JToken requestDoc = null;
                
                JObject configureAlertSettingsRequestValue = new JObject();
                requestDoc = configureAlertSettingsRequestValue;
                
                if (input.Properties != null)
                {
                    JObject propertiesValue = new JObject();
                    configureAlertSettingsRequestValue["properties"] = propertiesValue;
                    
                    if (input.Properties.SendToSubscriptionAdmin != null)
                    {
                        propertiesValue["sendToSubscriptionAdmin"] = input.Properties.SendToSubscriptionAdmin;
                    }
                    
                    if (input.Properties.SendToSubscriptionCoAdmins != null)
                    {
                        propertiesValue["sendToSubscriptionCoAdmins"] = input.Properties.SendToSubscriptionCoAdmins;
                    }
                    
                    if (input.Properties.CustomEmailAddresses != null)
                    {
                        if (input.Properties.CustomEmailAddresses is ILazyCollection == false || ((ILazyCollection)input.Properties.CustomEmailAddresses).IsInitialized)
                        {
                            JArray customEmailAddressesArray = new JArray();
                            foreach (string customEmailAddressesItem in input.Properties.CustomEmailAddresses)
                            {
                                customEmailAddressesArray.Add(customEmailAddressesItem);
                            }
                            propertiesValue["customEmailAddresses"] = customEmailAddressesArray;
                        }
                    }
                    
                    if (input.Properties.Locale != null)
                    {
                        propertiesValue["locale"] = input.Properties.Locale;
                    }
                }
                
                requestContent = requestDoc.ToString(Newtonsoft.Json.Formatting.Indented);
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    AlertSettingsResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new AlertSettingsResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        JToken alertSettingsResponseValue = responseDoc["AlertSettingsResponse"];
                        if (alertSettingsResponseValue != null && alertSettingsResponseValue.Type != JTokenType.Null)
                        {
                            AlertSettingsResponse alertSettingsResponseInstance = new AlertSettingsResponse();
                            
                            JToken valueValue = alertSettingsResponseValue["value"];
                            if (valueValue != null && valueValue.Type != JTokenType.Null)
                            {
                                AlertSettings valueInstance = new AlertSettings();
                                alertSettingsResponseInstance.Alert = valueInstance;
                                
                                JToken propertiesValue2 = valueValue["properties"];
                                if (propertiesValue2 != null && propertiesValue2.Type != JTokenType.Null)
                                {
                                    AlertSettingsProperties propertiesInstance = new AlertSettingsProperties();
                                    valueInstance.Properties = propertiesInstance;
                                    
                                    JToken sendToSubscriptionAdminValue = propertiesValue2["sendToSubscriptionAdmin"];
                                    if (sendToSubscriptionAdminValue != null && sendToSubscriptionAdminValue.Type != JTokenType.Null)
                                    {
                                        string sendToSubscriptionAdminInstance = ((string)sendToSubscriptionAdminValue);
                                        propertiesInstance.SendToSubscriptionAdmin = sendToSubscriptionAdminInstance;
                                    }
                                    
                                    JToken sendToSubscriptionCoAdminsValue = propertiesValue2["sendToSubscriptionCoAdmins"];
                                    if (sendToSubscriptionCoAdminsValue != null && sendToSubscriptionCoAdminsValue.Type != JTokenType.Null)
                                    {
                                        string sendToSubscriptionCoAdminsInstance = ((string)sendToSubscriptionCoAdminsValue);
                                        propertiesInstance.SendToSubscriptionCoAdmins = sendToSubscriptionCoAdminsInstance;
                                    }
                                    
                                    JToken customEmailAddressesArray2 = propertiesValue2["customEmailAddresses"];
                                    if (customEmailAddressesArray2 != null && customEmailAddressesArray2.Type != JTokenType.Null)
                                    {
                                        foreach (JToken customEmailAddressesValue in ((JArray)customEmailAddressesArray2))
                                        {
                                            propertiesInstance.CustomEmailAddresses.Add(((string)customEmailAddressesValue));
                                        }
                                    }
                                    
                                    JToken serverIdValue = propertiesValue2["serverId"];
                                    if (serverIdValue != null && serverIdValue.Type != JTokenType.Null)
                                    {
                                        string serverIdInstance = ((string)serverIdValue);
                                        propertiesInstance.ServerId = serverIdInstance;
                                    }
                                    
                                    JToken localeValue = propertiesValue2["locale"];
                                    if (localeValue != null && localeValue.Type != JTokenType.Null)
                                    {
                                        string localeInstance = ((string)localeValue);
                                        propertiesInstance.Locale = localeInstance;
                                    }
                                }
                                
                                JToken idValue = valueValue["id"];
                                if (idValue != null && idValue.Type != JTokenType.Null)
                                {
                                    string idInstance = ((string)idValue);
                                    valueInstance.Id = idInstance;
                                }
                                
                                JToken nameValue = valueValue["name"];
                                if (nameValue != null && nameValue.Type != JTokenType.Null)
                                {
                                    string nameInstance = ((string)nameValue);
                                    valueInstance.Name = nameInstance;
                                }
                                
                                JToken typeValue = valueValue["type"];
                                if (typeValue != null && typeValue.Type != JTokenType.Null)
                                {
                                    string typeInstance = ((string)typeValue);
                                    valueInstance.Type = typeInstance;
                                }
                                
                                JToken locationValue = valueValue["location"];
                                if (locationValue != null && locationValue.Type != JTokenType.Null)
                                {
                                    string locationInstance = ((string)locationValue);
                                    valueInstance.Location = locationInstance;
                                }
                                
                                JToken tagsSequenceElement = ((JToken)valueValue["tags"]);
                                if (tagsSequenceElement != null && tagsSequenceElement.Type != JTokenType.Null)
                                {
                                    foreach (JProperty property in tagsSequenceElement)
                                    {
                                        string tagsKey = ((string)property.Name);
                                        string tagsValue = ((string)property.Value);
                                        valueInstance.Tags.Add(tagsKey, tagsValue);
                                    }
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Get the list of events under the vault.
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Model class for list alerts response.
        /// </returns>
        public async Task<AlertSettingsListResponse> ListAsync(CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/Subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(this.Client.ResourceGroupName);
            url = url + "/providers/";
            url = url + Uri.EscapeDataString(this.Client.ResourceNamespace);
            url = url + "/";
            url = url + Uri.EscapeDataString(this.Client.ResourceType);
            url = url + "/";
            url = url + Uri.EscapeDataString(this.Client.ResourceName);
            url = url + "/replicationAlertSettings";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2015-11-10");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept-Language", customRequestHeaders.Culture);
                httpRequest.Headers.Add("x-ms-client-request-id", customRequestHeaders.ClientRequestId);
                httpRequest.Headers.Add("x-ms-version", "2015-01-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    AlertSettingsListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new AlertSettingsListResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        JToken alertSettingsListResponseValue = responseDoc["AlertSettingsListResponse"];
                        if (alertSettingsListResponseValue != null && alertSettingsListResponseValue.Type != JTokenType.Null)
                        {
                            AlertSettingsListResponse alertSettingsListResponseInstance = new AlertSettingsListResponse();
                            
                            JToken valueArray = alertSettingsListResponseValue["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    AlertSettings alertSettingsInstance = new AlertSettings();
                                    alertSettingsListResponseInstance.Alerts.Add(alertSettingsInstance);
                                    
                                    JToken propertiesValue = valueValue["properties"];
                                    if (propertiesValue != null && propertiesValue.Type != JTokenType.Null)
                                    {
                                        AlertSettingsProperties propertiesInstance = new AlertSettingsProperties();
                                        alertSettingsInstance.Properties = propertiesInstance;
                                        
                                        JToken sendToSubscriptionAdminValue = propertiesValue["sendToSubscriptionAdmin"];
                                        if (sendToSubscriptionAdminValue != null && sendToSubscriptionAdminValue.Type != JTokenType.Null)
                                        {
                                            string sendToSubscriptionAdminInstance = ((string)sendToSubscriptionAdminValue);
                                            propertiesInstance.SendToSubscriptionAdmin = sendToSubscriptionAdminInstance;
                                        }
                                        
                                        JToken sendToSubscriptionCoAdminsValue = propertiesValue["sendToSubscriptionCoAdmins"];
                                        if (sendToSubscriptionCoAdminsValue != null && sendToSubscriptionCoAdminsValue.Type != JTokenType.Null)
                                        {
                                            string sendToSubscriptionCoAdminsInstance = ((string)sendToSubscriptionCoAdminsValue);
                                            propertiesInstance.SendToSubscriptionCoAdmins = sendToSubscriptionCoAdminsInstance;
                                        }
                                        
                                        JToken customEmailAddressesArray = propertiesValue["customEmailAddresses"];
                                        if (customEmailAddressesArray != null && customEmailAddressesArray.Type != JTokenType.Null)
                                        {
                                            foreach (JToken customEmailAddressesValue in ((JArray)customEmailAddressesArray))
                                            {
                                                propertiesInstance.CustomEmailAddresses.Add(((string)customEmailAddressesValue));
                                            }
                                        }
                                        
                                        JToken serverIdValue = propertiesValue["serverId"];
                                        if (serverIdValue != null && serverIdValue.Type != JTokenType.Null)
                                        {
                                            string serverIdInstance = ((string)serverIdValue);
                                            propertiesInstance.ServerId = serverIdInstance;
                                        }
                                        
                                        JToken localeValue = propertiesValue["locale"];
                                        if (localeValue != null && localeValue.Type != JTokenType.Null)
                                        {
                                            string localeInstance = ((string)localeValue);
                                            propertiesInstance.Locale = localeInstance;
                                        }
                                    }
                                    
                                    JToken idValue = valueValue["id"];
                                    if (idValue != null && idValue.Type != JTokenType.Null)
                                    {
                                        string idInstance = ((string)idValue);
                                        alertSettingsInstance.Id = idInstance;
                                    }
                                    
                                    JToken nameValue = valueValue["name"];
                                    if (nameValue != null && nameValue.Type != JTokenType.Null)
                                    {
                                        string nameInstance = ((string)nameValue);
                                        alertSettingsInstance.Name = nameInstance;
                                    }
                                    
                                    JToken typeValue = valueValue["type"];
                                    if (typeValue != null && typeValue.Type != JTokenType.Null)
                                    {
                                        string typeInstance = ((string)typeValue);
                                        alertSettingsInstance.Type = typeInstance;
                                    }
                                    
                                    JToken locationValue = valueValue["location"];
                                    if (locationValue != null && locationValue.Type != JTokenType.Null)
                                    {
                                        string locationInstance = ((string)locationValue);
                                        alertSettingsInstance.Location = locationInstance;
                                    }
                                    
                                    JToken tagsSequenceElement = ((JToken)valueValue["tags"]);
                                    if (tagsSequenceElement != null && tagsSequenceElement.Type != JTokenType.Null)
                                    {
                                        foreach (JProperty property in tagsSequenceElement)
                                        {
                                            string tagsKey = ((string)property.Name);
                                            string tagsValue = ((string)property.Value);
                                            alertSettingsInstance.Tags.Add(tagsKey, tagsValue);
                                        }
                                    }
                                }
                            }
                            
                            JToken nextLinkValue = alertSettingsListResponseValue["nextLink"];
                            if (nextLinkValue != null && nextLinkValue.Type != JTokenType.Null)
                            {
                                string nextLinkInstance = ((string)nextLinkValue);
                                alertSettingsListResponseInstance.NextLink = nextLinkInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
