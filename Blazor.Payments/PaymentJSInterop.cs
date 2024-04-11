using Blazor.Payments.Data;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Blazor.Payments
{
	internal static class PaymentJSInterop
	{
		public static async Task<bool> CanMakePayment(IJSRuntime jsRuntime)
		{
			return await jsRuntime.InvokeAsync<bool>(
				   "blazorPaymentsInterop.canMakePayment");
		}

		public static async Task Show(IJSRuntime jsRuntime, PaymentMethod[] paymentMethods, PaymentDetailsBase paymentDetails, PaymentOptions paymentOptions)
		{
			await jsRuntime.InvokeAsync<object>(
				"blazorPaymentsInterop.showPayment",
				paymentMethods,
				paymentDetails,
				paymentOptions);
		}

	}
}
