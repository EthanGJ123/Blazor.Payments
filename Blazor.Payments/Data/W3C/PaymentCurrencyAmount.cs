namespace Blazor.Payments.Data
{
	public class PaymentCurrencyAmount
	{
		public PaymentCurrencyAmount(
			string currency,
			string value)
		{
			this.currency = currency;
			this.value = value;
		}

		public string currency { get; set; }
		public string value { get; set;  }

		public static PaymentCurrencyAmount operator +(PaymentCurrencyAmount a, PaymentCurrencyAmount b)
		{
			if(a.currency != b.currency)
				throw new System.Exception("The two amounts were in different currencies. This should be handled by the payment method");
			var aValue = double.Parse(a.value);
			var bValue = double.Parse(b.value);
			return new PaymentCurrencyAmount(a.currency, (aValue + bValue).ToString());
		}
	}
}
