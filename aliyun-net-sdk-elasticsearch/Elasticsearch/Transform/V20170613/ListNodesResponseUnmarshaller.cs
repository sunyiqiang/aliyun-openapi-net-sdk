/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListNodesResponseUnmarshaller
    {
        public static ListNodesResponse Unmarshall(UnmarshallerContext context)
        {
			ListNodesResponse listNodesResponse = new ListNodesResponse();

			listNodesResponse.HttpResponse = context.HttpResponse;
			listNodesResponse.RequestId = context.StringValue("ListNodes.RequestId");

			ListNodesResponse.ListNodes_Headers headers = new ListNodesResponse.ListNodes_Headers();
			headers.XTotalCount = context.IntegerValue("ListNodes.Headers.X-Total-Count");
			listNodesResponse.Headers = headers;

			List<ListNodesResponse.ListNodes_ResultItem> listNodesResponse_result = new List<ListNodesResponse.ListNodes_ResultItem>();
			for (int i = 0; i < context.Length("ListNodes.Result.Length"); i++) {
				ListNodesResponse.ListNodes_ResultItem resultItem = new ListNodesResponse.ListNodes_ResultItem();
				resultItem.EcsInstanceId = context.StringValue("ListNodes.Result["+ i +"].ecsInstanceId");
				resultItem.EcsInstanceName = context.StringValue("ListNodes.Result["+ i +"].ecsInstanceName");
				resultItem.Status = context.StringValue("ListNodes.Result["+ i +"].status");
				resultItem.OsType = context.StringValue("ListNodes.Result["+ i +"].osType");
				resultItem.CloudAssistantStatus = context.StringValue("ListNodes.Result["+ i +"].cloudAssistantStatus");
				resultItem.AgentStatus = context.StringValue("ListNodes.Result["+ i +"].agentStatus");

				List<ListNodesResponse.ListNodes_ResultItem.ListNodes_TagsItem> resultItem_tags = new List<ListNodesResponse.ListNodes_ResultItem.ListNodes_TagsItem>();
				for (int j = 0; j < context.Length("ListNodes.Result["+ i +"].Tags.Length"); j++) {
					ListNodesResponse.ListNodes_ResultItem.ListNodes_TagsItem tagsItem = new ListNodesResponse.ListNodes_ResultItem.ListNodes_TagsItem();
					tagsItem.TagKey = context.StringValue("ListNodes.Result["+ i +"].Tags["+ j +"].tagKey");
					tagsItem.TagValue = context.StringValue("ListNodes.Result["+ i +"].Tags["+ j +"].tagValue");

					resultItem_tags.Add(tagsItem);
				}
				resultItem.Tags = resultItem_tags;

				List<ListNodesResponse.ListNodes_ResultItem.ListNodes_IpAddressItem> resultItem_ipAddress = new List<ListNodesResponse.ListNodes_ResultItem.ListNodes_IpAddressItem>();
				for (int j = 0; j < context.Length("ListNodes.Result["+ i +"].IpAddress.Length"); j++) {
					ListNodesResponse.ListNodes_ResultItem.ListNodes_IpAddressItem ipAddressItem = new ListNodesResponse.ListNodes_ResultItem.ListNodes_IpAddressItem();
					ipAddressItem.Host = context.StringValue("ListNodes.Result["+ i +"].IpAddress["+ j +"].host");
					ipAddressItem.IpType = context.StringValue("ListNodes.Result["+ i +"].IpAddress["+ j +"].ipType");

					resultItem_ipAddress.Add(ipAddressItem);
				}
				resultItem.IpAddress = resultItem_ipAddress;

				listNodesResponse_result.Add(resultItem);
			}
			listNodesResponse.Result = listNodesResponse_result;
        
			return listNodesResponse;
        }
    }
}
