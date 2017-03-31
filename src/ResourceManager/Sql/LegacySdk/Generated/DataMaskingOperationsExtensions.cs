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
using Microsoft.Azure;
using Microsoft.Azure.Management.Sql.LegacySdk;
using Microsoft.Azure.Management.Sql.LegacySdk.Models;

namespace Microsoft.Azure.Management.Sql.LegacySdk
{
    /// <summary>
    /// The Windows Azure SQL Database management API provides a RESTful set of
    /// web services that interact with Windows Azure SQL Database services to
    /// manage your databases. The API enables users to create, retrieve,
    /// update, and delete databases and servers.
    /// </summary>
    public static partial class DataMaskingOperationsExtensions
    {
        /// <summary>
        /// Creates or updates an Azure SQL Database data masking policy
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDataMaskingOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database for which the data
        /// masking rule applies.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for createing or updating a
        /// firewall rule.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse CreateOrUpdatePolicy(this IDataMaskingOperations operations, string resourceGroupName, string serverName, string databaseName, DataMaskingPolicyCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDataMaskingOperations)s).CreateOrUpdatePolicyAsync(resourceGroupName, serverName, databaseName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates or updates an Azure SQL Database data masking policy
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDataMaskingOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database for which the data
        /// masking rule applies.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for createing or updating a
        /// firewall rule.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> CreateOrUpdatePolicyAsync(this IDataMaskingOperations operations, string resourceGroupName, string serverName, string databaseName, DataMaskingPolicyCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdatePolicyAsync(resourceGroupName, serverName, databaseName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Creates or updates an Azure SQL Database Server Firewall rule.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDataMaskingOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database for which the data
        /// masking rule applies.
        /// </param>
        /// <param name='dataMaskingRule'>
        /// Required. The name of the Azure SQL Database data masking rule.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for createing or updating a data
        /// masking rule.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse CreateOrUpdateRule(this IDataMaskingOperations operations, string resourceGroupName, string serverName, string databaseName, string dataMaskingRule, DataMaskingRuleCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDataMaskingOperations)s).CreateOrUpdateRuleAsync(resourceGroupName, serverName, databaseName, dataMaskingRule, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates or updates an Azure SQL Database Server Firewall rule.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDataMaskingOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database for which the data
        /// masking rule applies.
        /// </param>
        /// <param name='dataMaskingRule'>
        /// Required. The name of the Azure SQL Database data masking rule.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for createing or updating a data
        /// masking rule.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> CreateOrUpdateRuleAsync(this IDataMaskingOperations operations, string resourceGroupName, string serverName, string databaseName, string dataMaskingRule, DataMaskingRuleCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateRuleAsync(resourceGroupName, serverName, databaseName, dataMaskingRule, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes an Azure SQL Server data masking rule.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDataMaskingOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database for which the data
        /// masking rule applies.
        /// </param>
        /// <param name='dataMaskingRule'>
        /// Required. The name of the Azure SQL Database  data masking rule.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IDataMaskingOperations operations, string resourceGroupName, string serverName, string databaseName, string dataMaskingRule)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDataMaskingOperations)s).DeleteAsync(resourceGroupName, serverName, databaseName, dataMaskingRule);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes an Azure SQL Server data masking rule.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDataMaskingOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database for which the data
        /// masking rule applies.
        /// </param>
        /// <param name='dataMaskingRule'>
        /// Required. The name of the Azure SQL Database  data masking rule.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IDataMaskingOperations operations, string resourceGroupName, string serverName, string databaseName, string dataMaskingRule)
        {
            return operations.DeleteAsync(resourceGroupName, serverName, databaseName, dataMaskingRule, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns an Azure SQL Database data masking policy.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDataMaskingOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database for which the data
        /// masking policy applies.
        /// </param>
        /// <returns>
        /// Represents the response to a data masking policy get request.
        /// </returns>
        public static DataMaskingPolicyGetResponse GetPolicy(this IDataMaskingOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDataMaskingOperations)s).GetPolicyAsync(resourceGroupName, serverName, databaseName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns an Azure SQL Database data masking policy.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDataMaskingOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database for which the data
        /// masking policy applies.
        /// </param>
        /// <returns>
        /// Represents the response to a data masking policy get request.
        /// </returns>
        public static Task<DataMaskingPolicyGetResponse> GetPolicyAsync(this IDataMaskingOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return operations.GetPolicyAsync(resourceGroupName, serverName, databaseName, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns a list of Azure SQL Database data masking rules.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDataMaskingOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database for which the data
        /// masking rules applies.
        /// </param>
        /// <returns>
        /// Represents the response to a List data masking rules request.
        /// </returns>
        public static DataMaskingRuleListResponse List(this IDataMaskingOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDataMaskingOperations)s).ListAsync(resourceGroupName, serverName, databaseName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns a list of Azure SQL Database data masking rules.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDataMaskingOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database for which the data
        /// masking rules applies.
        /// </param>
        /// <returns>
        /// Represents the response to a List data masking rules request.
        /// </returns>
        public static Task<DataMaskingRuleListResponse> ListAsync(this IDataMaskingOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return operations.ListAsync(resourceGroupName, serverName, databaseName, CancellationToken.None);
        }
    }
}
