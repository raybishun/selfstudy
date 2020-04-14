namespace WebServiceAutomation.Model
{
    public class RestResponse
    {
        public int StatusCode { get; set; }
        public string ResponseContent { get; set; }

        public override string ToString()
        {
            return $"StatusCode: {StatusCode} ResponseContent: {ResponseContent}";
        }
    }
}
