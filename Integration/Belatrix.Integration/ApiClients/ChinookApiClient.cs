using RestSharp;
using System;

namespace Belatrix.Integration.ApiClients
{
    public class ChinookApiClient
    {
        protected string host = "http://localhost:5000";

        protected IRestResponse<T> Execute<T>(RestRequest request) where T: new()
        {
            var client = new RestClient
            {
                BaseUrl = new Uri(host)
            };

            var response = client.Execute<T>(request);
            ThrowException(response);

            return response;
        }

        protected IRestResponse Execute(RestRequest request)
        {
            var client = new RestClient
            {
                BaseUrl = new Uri(host)
            };

            var response = client.Execute(request);
            ThrowException(response);

            return response;
        }

        private void ThrowException(IRestResponse response)
        {
            if (response.ErrorException != null)
            {
                var apiException = new ApplicationException("There is an error ",response.ErrorException);

                throw apiException;
            }
        }
    }
}