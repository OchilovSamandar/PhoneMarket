namespace PhoneMarket.Dto
{
    public class ApiResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public object Object { get; set; }

        public ApiResponse(string message, bool success, object @object)
        {
            Message = message;
            Success = success;
            Object = @object;
        }

        public ApiResponse(string message, bool success)
        {
            Message = message;
            Success = success;
        }
    }
}
