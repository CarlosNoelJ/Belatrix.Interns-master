using Belatrix.Integration.Models;
using RestSharp;
using System.Collections.Generic;

namespace Belatrix.Integration.ApiClients
{
    class AlbumApiClient : ChinookApiClient
    {
        internal IRestResponse<List<Album>> GetAlbumList()
        {
            var url = "/api/Album";
            var apiRequest = new RestRequest(url, Method.GET);
            return Execute<List<Album>>(apiRequest);
        }

        internal IRestResponse<Album> GetAlbumById()
        {
            var url = "/api/Album/1";
            var apiRequest = new RestRequest(url, Method.GET);
            //albumId
            //title
            //artistId
            return Execute<Album>(apiRequest);
        }

        internal IRestResponse<int> PostAlbum()
        {
            var url = "/api/Album/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.POST);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { title = "Huaralino", artistId =1 });

            return Execute<int>(apiRequest);
        }

        internal IRestResponse<int> PutAlbum()
        {
            var url = "/api/Album/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.PUT);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { albumId =348, title = "Huaralino", artistId = 2 });


            return Execute<int>(apiRequest);
        }
        internal IRestResponse<int> DeleteAlbum()
        {
            var url = "/api/Album/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.DELETE);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { albumId = 348 });


            return Execute<int>(apiRequest);
        }
    }
}
