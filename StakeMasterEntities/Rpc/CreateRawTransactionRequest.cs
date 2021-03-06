﻿// ******************************* Module Header *******************************
// Module Name: CreateRawTransactionRequest.cs
// Project:     StakeMasterEntities
// Copyright (c) Michael Goldfinger.
// 
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND,
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// *****************************************************************************

namespace StakeMaster.Rpc
{
	using System.Collections.Generic;

	public sealed class CreateRawTransactionRequest
	{
		public CreateRawTransactionRequest(IList<CreateRawTransactionInput> inputs, IDictionary<string, decimal> outputs)
		{
			Inputs = inputs;
			Outputs = outputs;
		}

		public IList<CreateRawTransactionInput> Inputs { get; }
		public IDictionary<string, decimal> Outputs { get; }
	}
}
