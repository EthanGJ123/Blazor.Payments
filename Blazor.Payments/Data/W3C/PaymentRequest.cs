using System.Threading.Tasks;
using Blazor.Payments.Contracts;
using Blazor.Payments.Data;
using Microsoft.JSInterop;

namespace Blazor.Payments
{
	public class PaymentRequest : IPaymentRequest
	{
		private readonly PaymentMethod[] _paymentMethods;
		private readonly PaymentDetailsInit _paymentDetails;
		private readonly PaymentOptions _paymentOptions;

		public PaymentRequest(
			PaymentMethod[] paymentMethods,
			PaymentDetailsInit paymentDetails,
			PaymentOptions paymentOptions = null)
		{
			_paymentMethods = paymentMethods;
			_paymentDetails = paymentDetails;
			_paymentOptions = paymentOptions;
		}

		public Task Show(IJSRuntime jsRuntime)
		{
			return PaymentJSInterop.Show(
                jsRuntime,
				_paymentMethods,
				_paymentDetails,
				_paymentOptions);
		}
	}
}
