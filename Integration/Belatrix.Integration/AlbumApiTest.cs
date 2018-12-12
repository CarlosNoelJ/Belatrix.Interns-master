﻿using Belatrix.Integration.ApiClients;
using Belatrix.Integration.Models;
using FluentAssertions;
using NUnit.Framework;

namespace Belatrix.Integration
{
    public class AlbumApiTest
    {
        private AlbumApiClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new AlbumApiClient();
        }

        [Test]
        public void GetList_OkResponse()
        {
            var result = _client.GetAlbumList();

            result.Data.Should().AllBeOfType(typeof(Album)).And.HaveCountGreaterThan(1);
        }

        [Test]
        public void GetListId_OkResponse()
        {
            var result = _client.GetAlbumById();

            result.Data.Should().BeOfType(typeof(Album));
        }

        [Test]
        public void Post_OkResponse()
        {
            var result = _client.PostAlbum();

            result.Data.Should().Be(1);
        }

        [Test]
        public void Put_OkResponse()
        {
            var result = _client.PutAlbum();

            result.Data.Should().Be(1);
        }

        [Test]
        public void Delete_OkResponse()
        {
            var result = _client.DeleteAlbum();

            result.Data.Should().Be(1);
        }
    }
}
