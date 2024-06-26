﻿using System.Threading.Tasks;
using Blazor.Payments.Data;
using Microsoft.JSInterop;

namespace Blazor.Payments.Contracts
{
	public interface IPaymentRequest
	{
		/// <summary>
		/// Initiate a Web Payment
		/// </summary>
		/// <param name="paymentMethods"></param>
		/// <param name="paymentDetails"></param>
		/// <param name="paymentOptions"></param>
		/// <returns></returns>
		Task Show(IJSRuntime jsRuntime);
	}
}
