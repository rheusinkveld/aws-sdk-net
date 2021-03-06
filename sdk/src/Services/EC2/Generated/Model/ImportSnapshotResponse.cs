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
 * Do not modify this file. This file is generated from the ec2-2016-09-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Contains the output for ImportSnapshot.
    /// </summary>
    public partial class ImportSnapshotResponse : AmazonWebServiceResponse
    {
        private string _description;
        private string _importTaskId;
        private SnapshotTaskDetail _snapshotTaskDetail;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the import snapshot task.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ImportTaskId. 
        /// <para>
        /// The ID of the import snapshot task.
        /// </para>
        /// </summary>
        public string ImportTaskId
        {
            get { return this._importTaskId; }
            set { this._importTaskId = value; }
        }

        // Check to see if ImportTaskId property is set
        internal bool IsSetImportTaskId()
        {
            return this._importTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotTaskDetail. 
        /// <para>
        /// Information about the import snapshot task.
        /// </para>
        /// </summary>
        public SnapshotTaskDetail SnapshotTaskDetail
        {
            get { return this._snapshotTaskDetail; }
            set { this._snapshotTaskDetail = value; }
        }

        // Check to see if SnapshotTaskDetail property is set
        internal bool IsSetSnapshotTaskDetail()
        {
            return this._snapshotTaskDetail != null;
        }

    }
}