using Newtonsoft.Json;
using System;

namespace BankApiEndpoint.Models
{


    public class GetBvnDetailsRequest
    {
        [JsonProperty("bvn")]
        public string Bvn { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

    }
    public class BvnDetailsResponse
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("mobileNumber")]
        public string MobileNumber { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }

        [JsonProperty("responseCode")]
        public string ResponseCode { get; set; }
    }
    public class BvnDetailsFailedResponse
    {
        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }

        [JsonProperty("responseCode")]
        public string ResponseCode { get; set; }
    }

    public class NIPAccountRequest
    {
        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("beneficiaryBank")]
        public string BeneficiaryBank { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
    public class NIPAccountResponse
    {
        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        [JsonProperty("transactionReference")]
        public string TransactionReference { get; set; }

        [JsonProperty("bvn")]
        public string Bvn { get; set; }

        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("responseCode")]
        public string ResponseCode { get; set; }
    }

    public class NIPFundTransferRequest
    {
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

        [JsonProperty("transactionReference")]
        public Guid TransactionReference { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
    public class NIPFundTransferSucessResponse
    {
        [JsonProperty("transactionReference")]
        public string TransactionReference { get; set; }

        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }

        [JsonProperty("responseCode")]
        public string ResponseCode { get; set; }
    }
    public class RoNIPFundTransferFailedResponseot
    {
        [JsonProperty("transactionReference")]
        public string TransactionReference { get; set; }

        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }

        [JsonProperty("responseCode")]
        public string ResponseCode { get; set; }
    }

    public class NIPTransactionStatusRequest
    {
        [JsonProperty("transactionReference")]
        public string TransactionReference { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
    public class NIPTransactionStatusResponse
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("recipientBankCode")]
        public string RecipientBankCode { get; set; }

        [JsonProperty("recipientAccountNumber")]
        public string RecipientAccountNumber { get; set; }

        [JsonProperty("transactionReference")]
        public string TransactionReference { get; set; }

        [JsonProperty("transactionDateTime")]
        public string TransactionDateTime { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }

        [JsonProperty("responseCode")]
        public string ResponseCode { get; set; }
    }
    public class NIPTransactionStatusFailedResponse
    {
        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }

        [JsonProperty("responseCode")]
        public string ResponseCode { get; set; }
    }
    // start
    public class ProvidusFundTransferRequest
    {
        [JsonProperty("creditAccount")]
        public string CreditAccount { get; set; }

        [JsonProperty("debitAccount")]
        public string DebitAccount { get; set; }

        [JsonProperty("transactionAmount")]
        public string TransactionAmount { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("narration")]
        public string Narration { get; set; }

        [JsonProperty("transactionReference")]
        public string TransactionReference { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string PassWord { get; set; }
    }
    public class ProvidusFundTransferSucessResponse
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("transactionReference")]
        public string TransactionReference { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }

        [JsonProperty("responseCode")]
        public string ResponseCode { get; set; }
    }
    public class ProvidusFundTransferFailedResponse
    {
        [JsonProperty("transactionReference")]
        public string TransactionReference { get; set; }

        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }

        [JsonProperty("responseCode")]
        public string ResponseCode { get; set; }
    }

    public class GetProvidusTransactionStatusRequest
    {
        [JsonProperty("transactionReference")]
        public string TransactionReference { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
    public class GetProvidusTransactionStatusSuccessResponse
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("ceditAccount")]
        public string CreditAccount { get; set; }

        [JsonProperty("debitAccount")]
        public string DebitAccount { get; set; }

        [JsonProperty("transactionReference")]
        public string TransactionReference { get; set; }

        [JsonProperty("transactionDateTime")]
        public string TransactionDateTime { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }

        [JsonProperty("responseCode")]
        public string ResponseCode { get; set; }
    }
    public class GetProvidusTransactionStatusFailedResponse
    {
        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }

        [JsonProperty("responseCode")]
        public string ResponseCode { get; set; }
    }

}

