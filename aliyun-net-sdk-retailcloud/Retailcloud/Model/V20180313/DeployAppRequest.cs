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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.retailcloud.Transform;
using Aliyun.Acs.retailcloud.Transform.V20180313;

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
    public class DeployAppRequest : RpcAcsRequest<DeployAppResponse>
    {
        public DeployAppRequest()
            : base("retailcloud", "2018-03-13", "DeployApp", "retailcloud", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? deployPacketId;

		private string deployPacketUrl;

		private int? totalPartitions;

		private string name;

		private string description;

		private long? envId;

		private string pauseType;

		private bool? armsFlag;

		public long? DeployPacketId
		{
			get
			{
				return deployPacketId;
			}
			set	
			{
				deployPacketId = value;
				DictionaryUtil.Add(QueryParameters, "DeployPacketId", value.ToString());
			}
		}

		public string DeployPacketUrl
		{
			get
			{
				return deployPacketUrl;
			}
			set	
			{
				deployPacketUrl = value;
				DictionaryUtil.Add(QueryParameters, "DeployPacketUrl", value);
			}
		}

		public int? TotalPartitions
		{
			get
			{
				return totalPartitions;
			}
			set	
			{
				totalPartitions = value;
				DictionaryUtil.Add(QueryParameters, "TotalPartitions", value.ToString());
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public long? EnvId
		{
			get
			{
				return envId;
			}
			set	
			{
				envId = value;
				DictionaryUtil.Add(QueryParameters, "EnvId", value.ToString());
			}
		}

		public string PauseType
		{
			get
			{
				return pauseType;
			}
			set	
			{
				pauseType = value;
				DictionaryUtil.Add(QueryParameters, "PauseType", value);
			}
		}

		public bool? ArmsFlag
		{
			get
			{
				return armsFlag;
			}
			set	
			{
				armsFlag = value;
				DictionaryUtil.Add(QueryParameters, "ArmsFlag", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeployAppResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeployAppResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
