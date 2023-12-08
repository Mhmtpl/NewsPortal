namespace NewsPortal.Models
{
    public class HomepageResponse
    {
        public int ErrorCode { get; set; }
        public object ErrorMessage { get; set; }
        public List<HomepageData> Data { get; set; }
    }
}
