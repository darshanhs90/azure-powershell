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

namespace Microsoft.Azure.Management.Sql.LegacySdk.Models
{
    /// <summary>
    /// Represents the properties of an Azure SQL Database Elastic Pool
    /// Database Activity.
    /// </summary>
    public partial class ElasticPoolDatabaseActivityProperties
    {
        private string _currentElasticPoolName;
        
        /// <summary>
        /// Optional. Gets the name of the current Elastic Pool the database is
        /// in if available.
        /// </summary>
        public string CurrentElasticPoolName
        {
            get { return this._currentElasticPoolName; }
            set { this._currentElasticPoolName = value; }
        }
        
        private string _currentServiceObjectiveName;
        
        /// <summary>
        /// Optional. Gets the name of the current service objective if
        /// available.
        /// </summary>
        public string CurrentServiceObjectiveName
        {
            get { return this._currentServiceObjectiveName; }
            set { this._currentServiceObjectiveName = value; }
        }
        
        private string _databaseName;
        
        /// <summary>
        /// Optional. Gets the database name.
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }
        
        private System.DateTime? _endTime;
        
        /// <summary>
        /// Optional. Gets the time the operation finished.
        /// </summary>
        public System.DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private int? _errorCode;
        
        /// <summary>
        /// Optional. Gets the error code if available.
        /// </summary>
        public int? ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }
        
        private string _errorMessage;
        
        /// <summary>
        /// Optional. Gets the error message if available.
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }
        
        private int? _errorSeverity;
        
        /// <summary>
        /// Optional. Gets the error severity if available.
        /// </summary>
        public int? ErrorSeverity
        {
            get { return this._errorSeverity; }
            set { this._errorSeverity = value; }
        }
        
        private string _operation;
        
        /// <summary>
        /// Optional. Gets the operation name.
        /// </summary>
        public string Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }
        
        private Guid _operationId;
        
        /// <summary>
        /// Optional. Gets the unique operation ID.
        /// </summary>
        public Guid OperationId
        {
            get { return this._operationId; }
            set { this._operationId = value; }
        }
        
        private int? _percentComplete;
        
        /// <summary>
        /// Optional. Gets the percentage complete if available.
        /// </summary>
        public int? PercentComplete
        {
            get { return this._percentComplete; }
            set { this._percentComplete = value; }
        }
        
        private string _requestedElasticPoolName;
        
        /// <summary>
        /// Optional. Gets the name for the Elastic Pool the database is moving
        /// into if available.
        /// </summary>
        public string RequestedElasticPoolName
        {
            get { return this._requestedElasticPoolName; }
            set { this._requestedElasticPoolName = value; }
        }
        
        private string _requestedServiceObjectiveName;
        
        /// <summary>
        /// Optional. Gets the name of the requested service objective if
        /// available.
        /// </summary>
        public string RequestedServiceObjectiveName
        {
            get { return this._requestedServiceObjectiveName; }
            set { this._requestedServiceObjectiveName = value; }
        }
        
        private string _serverName;
        
        /// <summary>
        /// Optional. Gets the name of the Azure Sql Database Server the
        /// Elastic Pool is in.
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }
        
        private System.DateTime? _startTime;
        
        /// <summary>
        /// Optional. Gets the time the operation started.
        /// </summary>
        public System.DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Optional. Gets the current state of the operation.
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ElasticPoolDatabaseActivityProperties class.
        /// </summary>
        public ElasticPoolDatabaseActivityProperties()
        {
        }
    }
}
