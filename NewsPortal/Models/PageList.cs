namespace NewsPortal.Models
{
    public class PageList
    {
        public List<NewsItem> NewsItems { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string CategoryFilter { get; set; }
        public string KeywordFilter { get; set; }
    }
}
