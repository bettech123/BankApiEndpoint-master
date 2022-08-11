using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace BankApiEndpoint.Models
{
    public class NIPFundTransfer
    {
        [Key]
        [JsonProperty("transactionReference")]
        public Guid TransactionReference { get; set; }
        [JsonProperty("beneficiaryAccountName")]
        public string BeneficiaryAccountName { get; set; }

        [JsonProperty("transactionAmount")]
        public double TransactionAmount { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("narration")]
        public string Narration { get; set; }

        [JsonProperty("sourceAccountName")]
        public string SourceAccountName { get; set; }

        [JsonProperty("beneficiaryAccountNumber")]
        public string BeneficiaryAccountNumber { get; set; }

        [JsonProperty("beneficiaryBank")]
        public string BeneficiaryBank { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
