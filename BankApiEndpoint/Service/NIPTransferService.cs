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
                    return null;

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
    }
}
