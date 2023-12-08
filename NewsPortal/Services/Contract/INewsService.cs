using NewsPortal.Models;

namespace NewsPortal.Services.Contract
{
    public interface INewsService
    {
        Task<DetailResponse> GetNewsDetailAsync();
        Task<HomepageResponse> GetHomepageDataAsync();
    }
}
