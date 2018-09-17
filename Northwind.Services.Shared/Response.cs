using System;
using System.Collections.Generic;

namespace Northwind.Services.Shared
{
    public class Response
    {
        public List<Response> Downstream { get; set; }

        public DateTime Timestamp { get; set; }

        public string Endpoint { get; set; }

        public int Version { get; set; }

        public Response()
        {
            Timestamp = DateTime.Now;
        }

        public Response(string endpoint, int version)
        {
            Timestamp = DateTime.Now;

            Endpoint = endpoint;

            Version = version;
        }
    }

    public class Response<T> : Response
    {
        public T Data { get; set; }

        public Response()
        {
        }

        public Response(string endpoint, int version)
            : base(endpoint, version)
        {
        }
    }
}