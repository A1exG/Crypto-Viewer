using CryptoViewer.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptoViewer.Library.API
{
    public class CryptoEndpoint : ICryptoEndpoint
    {
        private IAPIHelper _apiHelper;
        public CryptoEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }


        public async Task<List<CurrencyLimit>> GetAll()
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("/api/currency_limits"))
            {
                if (response.IsSuccessStatusCode)
                {
                    //var result = await response.Content.ReadAsStringAsync(); ReadAsAsync<List<CurrencyLimit>>();
                    return null;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
