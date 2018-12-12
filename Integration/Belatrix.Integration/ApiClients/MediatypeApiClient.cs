using Belatrix.Integration.Models;
using RestSharp;
using System.Collections.Generic;

namespace Belatrix.Integration.ApiClients
{
    class MediaTypeApiClient : ChinookApiClient
    {
        internal IRestResponse<List<MediaType>> GetMediaTypeList()
        {
            var url = "/api/MediaType";
            var apiRequest = new RestRequest(url, Method.GET);
            return Execute<List<MediaType>>(apiRequest);
        }

        internal IRestResponse<MediaType> GetMediaTypeById()
        {
            var url = "/api/MediaType/1";
            var apiRequest = new RestRequest(url, Method.GET);

            return Execute<MediaType>(apiRequest);
        }

        internal IRestResponse<int> PostMediaType()
        {
            var url = "/api/MediaType/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.POST);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { name = "Huaralino" });
            
            return Execute<int>(apiRequest);
        }

        internal IRestResponse<int> PutMediaType()
        {
            var url = "/api/MediaType/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.PUT);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { MediaTypeId = 6, name = "negroide" });


            return Execute<int>(apiRequest);
        }
        internal IRestResponse<int> DeleteMediaType()
        {
            var url = "/api/MediaType/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.DELETE);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { MediaTypeId = 6 });


            return Execute<int>(apiRequest);
        }
    }
}
