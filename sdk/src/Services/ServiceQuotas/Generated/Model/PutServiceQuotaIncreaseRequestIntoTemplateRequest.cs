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
    /// Container for the parameters to the PutServiceQuotaIncreaseRequestIntoTemplate operation.
    /// Defines and adds a quota to the service quota template. To add a quota to the template,
    /// you must provide the <code>ServiceCode</code>, <code>QuotaCode</code>, <code>AwsRegion</code>,
    /// and <code>DesiredValue</code>. Once you add a quota to the template, use <a>ListServiceQuotaIncreaseRequestsInTemplate</a>
    /// to see the list of quotas in the template.
    /// </summary>
    public partial class PutServiceQuotaIncreaseRequestIntoTemplateRequest : AmazonServiceQuotasRequest
    {
        private string _awsRegion;
        private double? _desiredValue;
        private string _quotaCode;
        private string _serviceCode;

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// Specifies the AWS Region for the quota. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string AwsRegion
        {
            get { return this._awsRegion; }
            set { this._awsRegion = value; }
        }

        // Check to see if AwsRegion property is set
        internal bool IsSetAwsRegion()
        {
            return this._awsRegion != null;
        }

        /// <summary>
        /// Gets and sets the property DesiredValue. 
        /// <para>
        /// Specifies the new, increased value for the quota. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10000000000)]
        public double DesiredValue
        {
            get { return this._desiredValue.GetValueOrDefault(); }
            set { this._desiredValue = value; }
        }

        // Check to see if DesiredValue property is set
        internal bool IsSetDesiredValue()
        {
            return this._desiredValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QuotaCode. 
        /// <para>
        /// Specifies the service quota that you want to use.
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

    }
}