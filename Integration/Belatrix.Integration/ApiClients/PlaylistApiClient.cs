using Belatrix.Integration.Models;
using RestSharp;
using System.Collections.Generic;

namespace Belatrix.Integration.ApiClients
{
    class PlaylistApiClient : ChinookApiClient
    {
        internal IRestResponse<List<Playlist>> GetPlaylistList()
        {
            var url = "/api/Playlists";
            var apiRequest = new RestRequest(url, Method.GET);
            return Execute<List<Playlist>>(apiRequest);
        }

        internal IRestResponse<Playlist> GetPlaylistById()
        {
            var url = "/api/Playlists/1";
            var apiRequest = new RestRequest(url, Method.GET);

            return Execute<Playlist>(apiRequest);
        }

        internal IRestResponse<int> PostPlaylist()
        {
            var url = "/api/Playlists/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.POST);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { name = "Huaralino" });

            return Execute<int>(apiRequest);
        }

        internal IRestResponse<int> PutPlaylist()
        {
            var url = "/api/Playlists/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.PUT);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { PlaylistId = 20, name = "negroide" });


            return Execute<int>(apiRequest);
        }
        internal IRestResponse<int> DeletePlaylist()
        {
            var url = "/api/Playlists/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.DELETE);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { PlaylistId = 20 });


            return Execute<int>(apiRequest);
        }
    }
}
