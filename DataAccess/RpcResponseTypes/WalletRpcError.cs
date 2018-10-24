﻿// ******************************* Module Header *******************************
// Module Name: WalletRpcError.cs
// Project:     StakeMasterDataAccess
// Copyright (c) Michael Goldfinger.
// 
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND,
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// *****************************************************************************

namespace StakeMaster.DataAccess.RpcResponseTypes
{
	using Newtonsoft.Json;

	internal sealed class WalletRpcError
	{
		[JsonProperty(PropertyName = "code")]
		public int Code { get; set; }

		[JsonProperty(PropertyName = "message")]
		public string Message { get; set; }
	}
}
