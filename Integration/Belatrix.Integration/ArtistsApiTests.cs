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
        public void GetList_OkResponse()
        {
            var result = _client.GetArtistsList();

            result.Data.Should().AllBeOfType(typeof(Artists)).And.HaveCountGreaterThan(1);
        }

        [Test]
        public void GetListId_OkResponse()
        {
            var result = _client.GetAtistById();

            result.Data.Should().BeOfType(typeof(Artists));
        }

        [Test]
        public void Post_OkResponse()
        {
            var result = _client.PostArtist();

            result.Data.Should().Be(1);
        }

        [Test]
        public void Put_OkResponse()
        {
            var result = _client.PutArtist();

            result.Data.Should().Be(1);
        }

        [Test]
        public void Delete_OkResponse()
        {
            var result = _client.DeleteArtist();

            result.Data.Should().Be(1);
        }
    }
}