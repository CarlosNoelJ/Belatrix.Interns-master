using Belatrix.Integration.ApiClients;
using Belatrix.Integration.Models;
using FluentAssertions;
using NUnit.Framework;

namespace Belatrix.Integration
{
    public class MediaTypeApiTest
    {
        private MediaTypeApiClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new MediaTypeApiClient();
        }

        [Test]
        [Order(1)]
        public void GetList_OkResponse()
        {
            var result = _client.GetMediaTypeList();

            result.Data.Should().AllBeOfType(typeof(MediaType)).And.HaveCountGreaterThan(1);
        }

        [Test]
        [Order(2)]
        public void GetListId_OkResponse()
        {
            var result = _client.GetMediaTypeById();

            result.Data.Should().BeOfType(typeof(MediaType));
        }

        [Test]
        [Order(3)]
        public void Post_OkResponse()
        {
            var result = _client.PostMediaType();


            result.Data.Should().Be(1);
        }

        [Test]
        [Order(4)]
        public void Put_OkResponse()
        {
            var result = _client.PutMediaType();

            result.Data.Should().Be(1);
        }

        [Test]
        [Order(5)]
        public void Delete_OkResponse()
        {
            var result = _client.DeleteMediaType();

            result.Data.Should().Be(1);
        }
    }
}
