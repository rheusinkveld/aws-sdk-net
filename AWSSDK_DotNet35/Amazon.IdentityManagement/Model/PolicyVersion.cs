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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about a version of a managed policy.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a>CreatePolicyVersion</a>, <a>GetPolicyVersion</a>,
    /// and <a>ListPolicyVersions</a> actions. 
    /// </para>
    ///  
    /// <para>
    /// For more information about managed policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
    /// Policies and Inline Policies</a> in the <i>Using IAM</i> guide. 
    /// </para>
    /// </summary>
    public partial class PolicyVersion
    {
        private DateTime? _createDate;
        private string _document;
        private bool? _isDefaultVersion;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the policy version was created.
        /// </para>
        /// </summary>
        public DateTime CreateDate
        {
            get { return this._createDate.GetValueOrDefault(); }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Document. 
        /// <para>
        /// The policy document.
        /// </para>
        ///  
        /// <para>
        /// The policy document is returned in the response to the <a>GetPolicyVersion</a> operation.
        /// It is not included in the response to the <a>ListPolicyVersions</a> operation. 
        /// </para>
        /// </summary>
        public string Document
        {
            get { return this._document; }
            set { this._document = value; }
        }

        // Check to see if Document property is set
        internal bool IsSetDocument()
        {
            return this._document != null;
        }

        /// <summary>
        /// Gets and sets the property IsDefaultVersion. 
        /// <para>
        /// Specifies whether the policy version is set as the policy's default version.
        /// </para>
        /// </summary>
        public bool IsDefaultVersion
        {
            get { return this._isDefaultVersion.GetValueOrDefault(); }
            set { this._isDefaultVersion = value; }
        }

        // Check to see if IsDefaultVersion property is set
        internal bool IsSetIsDefaultVersion()
        {
            return this._isDefaultVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The identifier for the policy version.
        /// </para>
        ///  
        /// <para>
        /// Policy version identifiers always begin with <code>v</code> (always lowercase). When
        /// a policy is created, the first policy version is <code>v1</code>. 
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}