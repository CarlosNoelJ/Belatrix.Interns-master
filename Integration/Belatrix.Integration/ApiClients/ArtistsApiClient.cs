using Belatrix.Integration.Models;
using RestSharp;
using System.Collections.Generic;

namespace Belatrix.Integration.ApiClients
{
    class ArtistsApiClient: ChinookApiClient
    {
        internal IRestResponse<List<Artists>> GetArtistsList()
        {
            var url = "/api/artists";
            var apiRequest = new RestRequest(url, Method.GET);

            return Execute<List<Artists>>(apiRequest);
        }

        internal IRestResponse<Artists> GetAtistById()
        {
            var url = "/api/artists/1";
            var apiRequest = new RestRequest(url,Method.GET);

            return Execute<Artists>(apiRequest);
        }

        internal IRestResponse<int> PostArtist()
        {
            var url = "/api/artists/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.POST);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { name ="Tongo"});
            
            
            return Execute<int>(apiRequest);
        }

        internal IRestResponse<int> PutArtist()
        {
            var url = "/api/artists/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.PUT);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { artistid = 278, name = "Sin Bandera" });


            return Execute<int>(apiRequest);
        }
        internal IRestResponse<int> DeleteArtist()
        {
            var url = "/api/artists/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.DELETE);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { artistid = 278});


            return Execute<int>(apiRequest);
        }
    }
}
