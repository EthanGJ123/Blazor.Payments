using System.Text.Json.Serialization;

namespace Blazor.Payments.Data
{
    public class PaymentMerchantInfo
    {
        [JsonPropertyName("merchantId")]
        public string MerchantId { get; set; }

        [JsonPropertyName("merchantName")]
        public string MerchantName { get; set; }

        // Add any other properties as needed

        public PaymentMerchantInfo(string merchantId, string merchantName)
        {
            MerchantId = merchantId;
            MerchantName = merchantName;
        }
    }
}
