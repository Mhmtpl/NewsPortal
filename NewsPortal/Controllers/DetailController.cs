using Microsoft.AspNetCore.Mvc;
using NewsPortal.Services.Contract;

namespace NewsPortal.Controllers
{
    public class DetailController : Controller
    {
        private readonly INewsService _newsService;

        public DetailController(INewsService newsService)
        {
            _newsService = newsService;
        }

        public async Task<IActionResult> Index(string itemId)
        {
            var detailResponse = await _newsService.GetNewsDetailAsync();

            if (detailResponse != null && detailResponse.Data != null && detailResponse.Data.NewsDetail != null)
            {
                var newsDetail = detailResponse.Data.NewsDetail;

                return View(newsDetail);
            }

            return View("Error"); // Eğer detay alınamazsa Error.cshtml görünümünü göster
        }
    }
}
