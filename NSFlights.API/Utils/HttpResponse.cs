namespace Sales.API.Utils
{
    public class HttpResponse<T>
    {
        public bool IsSuccess { get; set; }
        public T Value { get; set; }
        public string Message { get; set; }
    }
}
