using NewsPortal.Models;
using NewsPortal.Services.Contract;
using Newtonsoft.Json;

namespace NewsPortal.Services
{
    public class NewsService : INewsService
    {
        private readonly IHttpClientFactory _clientFactory;

        public NewsService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<DetailResponse> GetNewsDetailAsync()
        {
            var client = _clientFactory.CreateClient();
            var response = await client.GetAsync("https://www.turkmedya.com.tr/detay.json");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<DetailResponse>(content);
            }

            return null;
        }

        public async Task<HomepageResponse> GetHomepageDataAsync()
        {
            var client = _clientFactory.CreateClient();
            var response = await client.GetAsync("https://www.turkmedya.com.tr/anasayfa.json");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<HomepageResponse>(content);
            }

            return null;
        }
    }
}
