using System.Text.Json.Serialization;

namespace Blazor.Payments.Data
{
    public class PaymentItem
    {
        public PaymentItem(
            string Label,
            PaymentCurrencyAmount Amount,
            bool Pending = false)
        {
            this.Label = Label;
            this.Amount = Amount;
            this.Pending = Pending;
        }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("amount")]
        public PaymentCurrencyAmount Amount { get; set; }

        [JsonPropertyName("pending")]
        public bool Pending { get; set; }
    }
}
