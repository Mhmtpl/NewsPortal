namespace NewsPortal.Models
{
    public class HomepageData
    {
        public string SectionType { get; set; }
        public string RepeatType { get; set; }
        public int ItemCountInRow { get; set; }
        public bool LazyLoadingEnabled { get; set; }
        public bool TitleVisible { get; set; }
        public object Title { get; set; }
        public object TitleColor { get; set; }
        public string TitleBgColor { get; set; }
        public string SectionBgColor { get; set; }
        public List<NewsItem> ItemList { get; set; }
    }
}
