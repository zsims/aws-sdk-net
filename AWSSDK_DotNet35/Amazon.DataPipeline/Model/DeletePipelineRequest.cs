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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Container for the parameters to the DeletePipeline operation.
    /// Permanently deletes a pipeline, its pipeline definition and its run history. You
    /// cannot query or restore a deleted pipeline. AWS Data Pipeline will attempt to cancel
    /// instances associated with the pipeline that are currently being processed by task
    /// runners. Deleting a pipeline cannot be undone. 
    /// 
    ///  
    /// <para>
    ///  To temporarily pause a pipeline instead of deleting it, call <a>SetStatus</a> with
    /// the status set to Pause on individual components. Components that are paused by <a>SetStatus</a>
    /// can be resumed. 
    /// </para>
    /// </summary>
    public partial class DeletePipelineRequest : AmazonDataPipelineRequest
    {
        private string _pipelineId;

        /// <summary>
        /// Gets and sets the property PipelineId. 
        /// <para>
        /// The identifier of the pipeline to be deleted.
        /// </para>
        /// </summary>
        public string PipelineId
        {
            get { return this._pipelineId; }
            set { this._pipelineId = value; }
        }

        // Check to see if PipelineId property is set
        internal bool IsSetPipelineId()
        {
            return this._pipelineId != null;
        }

    }
}