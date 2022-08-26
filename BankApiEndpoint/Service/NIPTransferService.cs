using BankApiEndpoint.Interface;
using BankApiEndpoint.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BankApiEndpoint.Service
{
    public class NIPTransferService : IService
    {
        private readonly AppSettings _config;
        private readonly HttpClient _client;

        public NIPTransferService(IOptions<AppSettings> config)
        {
            _config = config.Value;
            _client = new HttpClient();
        }

        public async Task<BvnDetailsResponse> GetBVNDetails(GetBvnDetailsRequest getBvnDetails)
        {
            string url = string.Concat(_config.BaseUrl, _config.GetBvnDetails);
            var request = new StringContent(JsonConvert.SerializeObject(getBvnDetails), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(url, request);
            if(response.IsSuccessStatusCode)
            {
                var stringResponse =  await response.Content.ReadAsStringAsync();
                var bvnDetails = JsonConvert.DeserializeObject<BvnDetailsResponse>(stringResponse);
                if(bvnDetails == null || bvnDetails.ResponseCode != "00")
                {
                    return null;
                }
                else
                {
                    return bvnDetails;
                }               
            }
            return new BvnDetailsResponse
            {
                ResponseCode = "00",
                ResponseMessage = "SUCCESSFUL",
                
                
            };
        }
        public async Task<NIPAccountResponse> GetNIPAccountDeatials(NIPAccountRequest accountRequest)
        {
            string Url = string.Concat(_config.BaseUrl, _config.GetNIPAccount);
            var requst = new StringContent(JsonConvert.SerializeObject(accountRequest), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(Url,requst);
            if(response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();
                var accountDetail = JsonConvert.DeserializeObject<NIPAccountResponse>(stringResponse);
                if(accountDetail == null || accountDetail.ResponseCode != "00")
                {
                    //No success response
                    return null;

                }
                else
                {
                    return accountDetail;
                }
            }
            return new NIPAccountResponse
            {
                ResponseCode = "20",
                ResponseMessage = "Failed"
            };
        }
        public async Task<NIPFundTransferSucessResponse> NIPFundTransfer(NIPFundTransfer fundTransfer)
        {
            string Url = string.Concat(_config.BaseUrl, _config.NIPFundTransfer);
            var requst = new StringContent(JsonConvert.SerializeObject(fundTransfer), Encoding.UTF8, "application/json");
            //another method call SendAsync --- take any HTTp verb
            HttpRequestMessage req = new()
            {
                RequestUri = new Uri(Url),
                Method = HttpMethod.Post,
                Content = requst

            };
            var response = await _client.SendAsync(req);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();
                var accountDetail = JsonConvert.DeserializeObject<NIPFundTransferSucessResponse>(stringResponse);
                if (accountDetail == null || accountDetail.ResponseCode != "00")
                {
                    //No success response
                    return accountDetail;

                }
                else
                {
                    return accountDetail;
                }
            }
            return new NIPFundTransferSucessResponse
            {
                ResponseCode = "20",
                ResponseMessage = "Failed"
            };

        }
        public async Task<NIPTransactionStatusResponse> GetNIPTransactionStatus(NIPTransactionStatusRequest transactionStatus)
        {
            string Url = string.Concat(_config.BaseUrl, _config.GetNIPTransactionStatus);
            var requst = new StringContent(JsonConvert.SerializeObject(transactionStatus), Encoding.UTF8, "application/json");
            //another method call SendAsync --- take any HTTp verb
            HttpRequestMessage req = new()
            {
                RequestUri = new Uri(Url),
                Method = HttpMethod.Post,
                Content = requst

            };
            var response = await _client.SendAsync(req);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();
                var statusRequest = JsonConvert.DeserializeObject<NIPTransactionStatusResponse>(stringResponse);
                if (statusRequest == null || statusRequest.ResponseCode != "32")
                {
                    //No success response
                    return null;

                }
                else
                {
                    return statusRequest;
                }
            }
            return new NIPTransactionStatusResponse
            {
                ResponseCode = "01",
                ResponseMessage = "Transaction does not exist."
            };

           
        }

        // Endpoints for Providus bank to another bank starts here

        public async Task<GetNIPBanksModel> GetNIPBanks()
        {
            var url = string.Format("http://154.113.16.142:8882/postingrest/GetNIPBanks");

            var result = new GetNIPBanksModel();

            var response = await _client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = System.Text.Json.JsonSerializer.Deserialize<GetNIPBanksModel>(stringResponse, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }
            return result;
        }

        public async Task<ProvidusFundTransferSucessResponse> ProvidusFundTransfer(ProvidusFundTransfer fundTransfer)
        {
            string Url = string.Concat(_config.BaseUrl, "/ProvidusFundTransfer");
            var request = new StringContent(JsonConvert.SerializeObject(fundTransfer), Encoding.UTF8, "application/json");
            //another method call SendAsync --- take any HTTp verb
            HttpRequestMessage req = new HttpRequestMessage
            {
                RequestUri = new Uri(Url),
                Method = HttpMethod.Post,
                Content = request

            };
            var response = await _client.SendAsync(req);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();
                var accountDetail = JsonConvert.DeserializeObject<ProvidusFundTransferSucessResponse>(stringResponse);
                if (accountDetail == null || accountDetail.ResponseCode != "00")
                {
                    //No success response
                    return accountDetail;

                }
                else
                {
                    return accountDetail;
                }
            }
            return new ProvidusFundTransferSucessResponse
            {
                ResponseCode = "7709",
                ResponseMessage = " Transaction Failed"
            };
        }


        public async Task<GetProvidusTransactionStatusSuccessResponse> GetProvidusTransactionStatus(GetProvidusTransactionStatus statusRequest)
        {
            string Url = string.Concat(_config.BaseUrl, _config.ProvidusFundTransfer);
            var request = new StringContent(JsonConvert.SerializeObject(statusRequest), Encoding.UTF8, "application/json");
            //another method call SendAsync --- take any HTTp verb
            HttpRequestMessage req = new HttpRequestMessage
            {
                RequestUri = new Uri(Url),
                Method = HttpMethod.Post,
                Content = request

            };
            var response = await _client.SendAsync(req);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();
                var accountDetail = JsonConvert.DeserializeObject<GetProvidusTransactionStatusSuccessResponse>(stringResponse);
                if (accountDetail == null || accountDetail.ResponseCode != "00")
                {
                    //No success response
                    return null;

                }
                else
                {
                    return accountDetail;
                }
            }
            return new GetProvidusTransactionStatusSuccessResponse
            {
                ResponseCode = "01",
                ResponseMessage = "Transaction does not exist"
            };
        }



    }
}
