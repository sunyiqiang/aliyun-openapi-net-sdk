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
using Aliyun.Acs.reid.Model.V20190928;

namespace Aliyun.Acs.reid.Transform.V20190928
{
    public class PullTryOnShoesEventResponseUnmarshaller
    {
        public static PullTryOnShoesEventResponse Unmarshall(UnmarshallerContext context)
        {
			PullTryOnShoesEventResponse pullTryOnShoesEventResponse = new PullTryOnShoesEventResponse();

			pullTryOnShoesEventResponse.HttpResponse = context.HttpResponse;
			pullTryOnShoesEventResponse.StoreId = context.LongValue("PullTryOnShoesEvent.StoreId");
			pullTryOnShoesEventResponse.RequestId = context.StringValue("PullTryOnShoesEvent.RequestId");
			pullTryOnShoesEventResponse.Success = context.BooleanValue("PullTryOnShoesEvent.Success");
			pullTryOnShoesEventResponse.StartTs = context.LongValue("PullTryOnShoesEvent.StartTs");
			pullTryOnShoesEventResponse.DynamicMessage = context.StringValue("PullTryOnShoesEvent.DynamicMessage");
			pullTryOnShoesEventResponse.ErrorCode = context.StringValue("PullTryOnShoesEvent.ErrorCode");
			pullTryOnShoesEventResponse.ErrorMessage = context.StringValue("PullTryOnShoesEvent.ErrorMessage");
			pullTryOnShoesEventResponse.TryOnShoesEventCount = context.IntegerValue("PullTryOnShoesEvent.TryOnShoesEventCount");
			pullTryOnShoesEventResponse.PageNumber = context.IntegerValue("PullTryOnShoesEvent.PageNumber");
			pullTryOnShoesEventResponse.Message = context.StringValue("PullTryOnShoesEvent.Message");
			pullTryOnShoesEventResponse.Code = context.StringValue("PullTryOnShoesEvent.Code");
			pullTryOnShoesEventResponse.TotalCount = context.LongValue("PullTryOnShoesEvent.TotalCount");
			pullTryOnShoesEventResponse.DynamicCode = context.StringValue("PullTryOnShoesEvent.DynamicCode");
			pullTryOnShoesEventResponse.SkuId = context.StringValue("PullTryOnShoesEvent.SkuId");
			pullTryOnShoesEventResponse.PageSize = context.IntegerValue("PullTryOnShoesEvent.PageSize");
        
			return pullTryOnShoesEventResponse;
        }
    }
}
