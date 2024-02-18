namespace CRMSampleApp.Models
{
    public class Response
    {
        public int StatusCode { get; set; }

        public string Message { get; set; }

        public object  Data { get; set; }

        public Boolean IsSuccess { get; set; }

        public Response() { 
        
            StatusCode = 200;
            Message = string.Empty;
            Data = new object();
            IsSuccess = false;
        }
    }
}
