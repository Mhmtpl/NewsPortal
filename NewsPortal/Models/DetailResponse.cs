namespace NewsPortal.Models
{
    public class DetailResponse
    {
        public int ErrorCode { get; set; }
        public object ErrorMessage { get; set; }
        public DetailData Data { get; set; }
    }
}
