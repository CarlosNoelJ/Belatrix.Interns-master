using Belatrix.Integration.Models;
using RestSharp;
using System.Collections.Generic;

namespace Belatrix.Integration.ApiClients
{
    class GenreApiClient: ChinookApiClient
    {
        internal IRestResponse<List<Genre>> GetGenreList()
        {
            var url = "/api/genre";
            var apiRequest = new RestRequest(url, Method.GET);
            return Execute<List<Genre>>(apiRequest);
        }

        internal IRestResponse<Genre> GetGenreById()
        {
            var url = "/api/genre/1";
            var apiRequest = new RestRequest(url, Method.GET);

            return Execute<Genre>(apiRequest);
        }

        internal IRestResponse<int> PostGenre()
        {
            var url = "/api/genre/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.POST);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { name = "Huaralino" });

            return Execute<int>(apiRequest);
        }

        internal IRestResponse<int> PutGenre()
        {
            var url = "/api/genre/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.PUT);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { genreId = 26, name = "negroide" });


            return Execute<int>(apiRequest);
        }
        internal IRestResponse<int> DeleteGenre()
        {
            var url = "/api/genre/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.DELETE);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { genreId = 26 });


            return Execute<int>(apiRequest);
        }
    }
}
