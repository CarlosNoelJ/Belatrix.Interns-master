using Belatrix.Integration.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Belatrix.Integration.ApiClients
{
    class PlaylistTrackApiClient : ChinookApiClient
    {
        internal IRestResponse<List<PlaylistTrack>> GetPlaylistTrackList()
        {
            var url = "/api/PlaylistTrack";
            var apiRequest = new RestRequest(url, Method.GET);
            return Execute<List<PlaylistTrack>>(apiRequest);
        }

        internal IRestResponse<PlaylistTrack> GetPlaylistTrackById()
        {
            var url = "/api/PlaylistTrack/1";
            var apiRequest = new RestRequest(url, Method.GET);

            return Execute<PlaylistTrack>(apiRequest);
        }

        internal IRestResponse<int> PostPlaylistTrack()
        {
            var url = "/api/PlaylistTrack/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.POST);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new {
                playlistId = 17,
                trackId = 597,
            });
            
            return Execute<int>(apiRequest);
        }

        internal IRestResponse<int> PutPlaylistTrack()
        {
            var url = "/api/PlaylistTrack/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.PUT);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new
            {
                playlistId = 17,
                trackId = 596,
            });


            return Execute<int>(apiRequest);
        }
        internal IRestResponse<int> DeletePlaylistTrack()
        {
            var url = "/api/PlaylistTrack/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.DELETE);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new
            {
                playlistId = 17
            });


            return Execute<int>(apiRequest);
        }
    }
}
