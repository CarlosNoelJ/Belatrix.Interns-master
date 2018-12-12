using Belatrix.Integration.ApiClients;
using Belatrix.Integration.Models;
using FluentAssertions;
using NUnit.Framework;

namespace Belatrix.Integration
{
    public class PlaylistApitest
    {
        private PlaylistApiClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new PlaylistApiClient();
        }

        [Test]
        [Order(1)]
        public void GetList_OkResponse()
        {
            var result = _client.GetPlaylistList();

            result.Data.Should().AllBeOfType(typeof(Playlist)).And.HaveCountGreaterThan(1);
        }

        [Test]
        [Order(2)]
        public void GetListId_OkResponse()
        {
            var result = _client.GetPlaylistById();

            result.Data.Should().BeOfType(typeof(Playlist));
        }

        [Test]
        [Order(3)]
        public void Post_OkResponse()
        {
            var result = _client.PostPlaylist();

            result.Data.Should().Be(1);
        }

        [Test]
        [Order(4)]
        public void Put_OkResponse()
        {
            var result = _client.PutPlaylist();

            result.Data.Should().Be(1);
        }

        [Test]
        [Order(5)]
        public void Delete_OkResponse()
        {
            var result = _client.DeletePlaylist();

            result.Data.Should().Be(1);
        }
    }
}
