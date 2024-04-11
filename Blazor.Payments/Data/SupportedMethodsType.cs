using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data
{
	public enum SupportedMethodsType
	{
		BobBucks,
		ApplePay,
		SamsungPay,
		GooglePay,
		Facebook,
		Custom = 0,
	}
}
