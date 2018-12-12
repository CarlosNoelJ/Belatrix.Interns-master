using Belatrix.Integration.ApiClients;
using Belatrix.Integration.Models;
using FluentAssertions;
using NUnit.Framework;

namespace Belatrix.Integration
{
    public class ArtistsApiTests
    {
        private ArtistsApiClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new ArtistsApiClient();
        }

        [Test]
        [Order(1)]
        public void GetList_OkResponse()
        {
            var result = _client.GetArtistsList();

            result.Data.Should().AllBeOfType(typeof(Artists)).And.HaveCountGreaterThan(1);
        }

        [Test]
        [Order(2)]
        public void GetListId_OkResponse()
        {
            var result = _client.GetAtistById();

            result.Data.Should().BeOfType(typeof(Artists));
        }

        [Test]
        [Order(3)]
        public void Post_OkResponse()
        {
            var result = _client.PostArtist();

            result.Data.Should().Be(1);
        }

        [Test]
        [Order(4)]
        public void Put_OkResponse()
        {
            var result = _client.PutArtist();

            result.Data.Should().Be(1);
        }

        [Test]
        [Order(5)]
        public void Delete_OkResponse()
        {
            var result = _client.DeleteArtist();

            result.Data.Should().Be(1);
        }
    }
}