using Microsoft.AspNetCore.Mvc;
using NewsPortal.Models;
using System.Diagnostics;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewsPortal.Services.Contract;

namespace NewsPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly INewsService _newsService;

        public HomeController(INewsService newsService)
        {
            _newsService = newsService;
        }

        public async Task<IActionResult> Index(string categoryId = null, string keyword = null, int page = 1)
        {
            const int pageSize = 5;

            var homepageData = await _newsService.GetHomepageDataAsync();

            if (homepageData != null && homepageData.Data != null && homepageData.Data.Any())
            {
                var allNewsItems = homepageData.Data.SelectMany(d => d.ItemList).ToList();


                if (!string.IsNullOrEmpty(keyword))
                {
                    allNewsItems = allNewsItems.Where(item => item.Title?.Contains(keyword, StringComparison.OrdinalIgnoreCase) ?? false).ToList();
                    ViewBag.Keyword = keyword;
                }

                if (!string.IsNullOrEmpty(categoryId))
                {
                    allNewsItems = allNewsItems.Where(item => item.Category?.CategoryId == categoryId).ToList();
                    ViewBag.CategoryId = categoryId;
                }
                var distinctCategories = allNewsItems
                  .Select(item => item.Category)
                  .GroupBy(category => category.CategoryId)
                  .Select(group => group.First())
                  .ToList();

                ViewBag.Categories = distinctCategories;
                var totalCount = allNewsItems.Count;

                var paginatedNewsItems = allNewsItems.Skip((page - 1) * pageSize)
                                                    .Take(pageSize)
                                                    .ToList();

                var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

                var pageList = new PageList
                {
                    NewsItems = paginatedNewsItems,
                    CurrentPage = page,
                    TotalPages = totalPages,
                    CategoryFilter = categoryId,
                    KeywordFilter = keyword
                };

                return View(pageList);
            }

            return View();
        }
    }
}