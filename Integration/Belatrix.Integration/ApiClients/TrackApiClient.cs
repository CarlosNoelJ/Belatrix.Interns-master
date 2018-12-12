using Belatrix.Integration.Models;
using RestSharp;
using System.Collections.Generic;

namespace Belatrix.Integration.ApiClients
{
    class TrackApiClient : ChinookApiClient
    {
        internal IRestResponse<List<Track>> GetTrackList()
        {
            var url = "/api/Track";
            var apiRequest = new RestRequest(url, Method.GET);
            return Execute<List<Track>>(apiRequest);
        }

        internal IRestResponse<Track> GetTrackById()
        {
            var url = "/api/Track/1";
            var apiRequest = new RestRequest(url, Method.GET);

            return Execute<Track>(apiRequest);
        }

        internal IRestResponse<int> PostTrack()
        {
            var url = "/api/Track/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.POST);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { name = "Huaralino", albumId = 319, mediaTypeId = 2, genreId = 1, composer = "John Dowland", milliseconds = 253281 , bytes = 11170334 , unitPrice = 0.99 });

            return Execute<int>(apiRequest);
        }

        internal IRestResponse<int> PutTrack()
        {
            var url = "/api/Track/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.PUT);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { trackId=3504 , name = "negroide", albumId = 319, mediaTypeId = 2, genreId = 1, composer = "John Dowland", milliseconds = 253281, bytes = 11170334, unitPrice = 0.99 });


            return Execute<int>(apiRequest);
        }
        internal IRestResponse<int> DeleteTrack()
        {
            var url = "/api/Track/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.DELETE);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { TrackId = 3504 });


            return Execute<int>(apiRequest);
        }
    }
}
