using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Blazor.Payments
{
	public static class WebPaymentHelper
	{
		public static Task<bool> CanMakePayment(IJSRuntime jsRuntime)
		{
			return PaymentJSInterop.CanMakePayment(jsRuntime);
		}
	}
}
