/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// Container for the parameters to the ListRequestedServiceQuotaChangeHistoryByQuota operation.
    /// Requests a list of the changes to specific service quotas. This command provides additional
    /// granularity over the <code>ListRequestedServiceQuotaChangeHistory</code> command.
    /// Once a quota change request has reached <code>CASE_CLOSED, APPROVED,</code> or <code>DENIED</code>,
    /// the history has been kept for 90 days.
    /// </summary>
    public partial class ListRequestedServiceQuotaChangeHistoryByQuotaRequest : AmazonServiceQuotasRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _quotaCode;
        private string _serviceCode;
        private RequestStatus _status;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// (Optional) Limits the number of results that you want to include in the response.
        /// If you don't include this parameter, the response defaults to a value that's specific
        /// to the operation. If additional items exist beyond the specified maximum, the <code>NextToken</code>
        /// element is present and has a value (isn't null). Include that value as the <code>NextToken</code>
        /// request parameter in the call to the operation to get the next part of the results.
        /// You should check <code>NextToken</code> after every operation to ensure that you receive
        /// all of the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// (Optional) Use this parameter in a request if you receive a <code>NextToken</code>
        /// response in a previous request that indicates that there's more output available.
        /// In a subsequent call, set it to the value of the previous call's <code>NextToken</code>
        /// response to indicate where the output should continue from.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property QuotaCode. 
        /// <para>
        /// Specifies the service quota that you want to use
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string QuotaCode
        {
            get { return this._quotaCode; }
            set { this._quotaCode = value; }
        }

        // Check to see if QuotaCode property is set
        internal bool IsSetQuotaCode()
        {
            return this._quotaCode != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// Specifies the service that you want to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ServiceCode
        {
            get { return this._serviceCode; }
            set { this._serviceCode = value; }
        }

        // Check to see if ServiceCode property is set
        internal bool IsSetServiceCode()
        {
            return this._serviceCode != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the status value of the quota increase request.
        /// </para>
        /// </summary>
        public RequestStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}