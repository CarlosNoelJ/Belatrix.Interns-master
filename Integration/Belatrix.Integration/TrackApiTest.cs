using Belatrix.Integration.ApiClients;
using Belatrix.Integration.Models;
using FluentAssertions;
using NUnit.Framework;


namespace Belatrix.Integration
{
    public class TrackApiTest
    {
        private TrackApiClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new TrackApiClient();
        }

        [Test]
        [Order(1)]
        public void GetList_OkResponse()
        {
            var result = _client.GetTrackList();

            result.Data.Should().AllBeOfType(typeof(Track)).And.HaveCountGreaterThan(1);
        }

        [Test]
        [Order(2)]
        public void GetListId_OkResponse()
        {
            var result = _client.GetTrackById();

            result.Data.Should().BeOfType(typeof(Track));
        }

        [Test]
        [Order(3)]
        public void Post_OkResponse()
        {
            var result = _client.PostTrack();

            result.Data.Should().Be(1);
        }

        [Test]
        [Order(4)]
        public void Put_OkResponse()
        {
            var result = _client.PutTrack();

            result.Data.Should().Be(1);
        }

        [Test]
        [Order(5)]
        public void Delete_OkResponse()
        {
            var result = _client.DeleteTrack();

            result.Data.Should().Be(1);
        }
    }
}
