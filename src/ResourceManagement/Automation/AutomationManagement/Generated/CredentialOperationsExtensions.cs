// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    public static partial class CredentialOperationsExtensions
    {
        /// <summary>
        /// Create a credential.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the create or update
        /// credential operation.
        /// </param>
        /// <returns>
        /// The response model for the create or update credential operation.
        /// </returns>
        public static CredentialCreateOrUpdateResponse CreateOrUpdate(this ICredentialOperations operations, string resourceGroupName, string automationAccount, CredentialCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICredentialOperations)s).CreateOrUpdateAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create a credential.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the create or update
        /// credential operation.
        /// </param>
        /// <returns>
        /// The response model for the create or update credential operation.
        /// </returns>
        public static Task<CredentialCreateOrUpdateResponse> CreateOrUpdateAsync(this ICredentialOperations operations, string resourceGroupName, string automationAccount, CredentialCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete the credential.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='credentialName'>
        /// Required. The name of credential.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this ICredentialOperations operations, string resourceGroupName, string automationAccount, string credentialName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICredentialOperations)s).DeleteAsync(resourceGroupName, automationAccount, credentialName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete the credential.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='credentialName'>
        /// Required. The name of credential.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this ICredentialOperations operations, string resourceGroupName, string automationAccount, string credentialName)
        {
            return operations.DeleteAsync(resourceGroupName, automationAccount, credentialName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the credential identified by credential name.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='credentialName'>
        /// Required. The name of credential.
        /// </param>
        /// <returns>
        /// The response model for the get credential operation.
        /// </returns>
        public static CredentialGetResponse Get(this ICredentialOperations operations, string resourceGroupName, string automationAccount, string credentialName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICredentialOperations)s).GetAsync(resourceGroupName, automationAccount, credentialName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the credential identified by credential name.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='credentialName'>
        /// Required. The name of credential.
        /// </param>
        /// <returns>
        /// The response model for the get credential operation.
        /// </returns>
        public static Task<CredentialGetResponse> GetAsync(this ICredentialOperations operations, string resourceGroupName, string automationAccount, string credentialName)
        {
            return operations.GetAsync(resourceGroupName, automationAccount, credentialName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve a list of credentials.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list credential operation.
        /// </returns>
        public static CredentialListResponse List(this ICredentialOperations operations, string resourceGroupName, string automationAccount)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICredentialOperations)s).ListAsync(resourceGroupName, automationAccount);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a list of credentials.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list credential operation.
        /// </returns>
        public static Task<CredentialListResponse> ListAsync(this ICredentialOperations operations, string resourceGroupName, string automationAccount)
        {
            return operations.ListAsync(resourceGroupName, automationAccount, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve next list of credentials.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list credential operation.
        /// </returns>
        public static CredentialListResponse ListNext(this ICredentialOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICredentialOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve next list of credentials.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list credential operation.
        /// </returns>
        public static Task<CredentialListResponse> ListNextAsync(this ICredentialOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Update a credential.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the patch credential operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Patch(this ICredentialOperations operations, string resourceGroupName, string automationAccount, CredentialPatchParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICredentialOperations)s).PatchAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Update a credential.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the patch credential operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> PatchAsync(this ICredentialOperations operations, string resourceGroupName, string automationAccount, CredentialPatchParameters parameters)
        {
            return operations.PatchAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
    }
}
