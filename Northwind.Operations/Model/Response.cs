namespace Northwind.Operations.Model
{
    public class Response
    {
        public string Message { get; set; }

        public bool Error { get; set; }

        public Response()
        {
            Message = "OK";
        }
    }

    public class Response<T> : Response
    {
        public T Result { get; set; }
    }
}