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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SQS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetQueueUrl Request Marshaller
    /// </summary>       
    public class GetQueueUrlRequestMarshaller : IMarshaller<IRequest, GetQueueUrlRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetQueueUrlRequest)input);
        }
    
        public IRequest Marshall(GetQueueUrlRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SQS");
            request.Parameters.Add("Action", "GetQueueUrl");
            request.Parameters.Add("Version", "2012-11-05");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetQueueName())
                {
                    request.Parameters.Add("QueueName", StringUtils.FromString(publicRequest.QueueName));
                }
                if(publicRequest.IsSetQueueOwnerAWSAccountId())
                {
                    request.Parameters.Add("QueueOwnerAWSAccountId", StringUtils.FromString(publicRequest.QueueOwnerAWSAccountId));
                }
            }
            return request;
        }
    }
}