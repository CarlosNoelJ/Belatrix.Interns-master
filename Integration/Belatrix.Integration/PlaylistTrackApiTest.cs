using Belatrix.Integration.ApiClients;
using Belatrix.Integration.Models;
using FluentAssertions;
using NUnit.Framework;

namespace Belatrix.Integration
{
    public class PlaylistTrackApiTest
    {
        private PlaylistTrackApiClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new PlaylistTrackApiClient();
        }

        [Test]
        [Order(1)]
        public void GetList_OkResponse()
        {
            var result = _client.GetPlaylistTrackList();

            result.Data.Should().AllBeOfType(typeof(PlaylistTrack)).And.HaveCountGreaterThan(1);
        }

        [Test]
        [Order(2)]
        public void GetListId_OkResponse()
        {
            var result = _client.GetPlaylistTrackById();

            result.Data.Should().BeOfType(typeof(PlaylistTrack));
        }

        [Test]
        [Order(3)]
        public void Post_OkResponse()
        {
            var result = _client.PostPlaylistTrack();


            result.Data.Should().Be(1);
        }

        [Test]
        [Order(4)]
        public void Put_OkResponse()
        {
            var result = _client.PutPlaylistTrack();

            result.Data.Should().Be(1);
        }

        [Test]
        [Order(5)]
        public void Delete_OkResponse()
        {
            var result = _client.DeletePlaylistTrack();

            result.Data.Should().Be(1);
        }
    }
}
