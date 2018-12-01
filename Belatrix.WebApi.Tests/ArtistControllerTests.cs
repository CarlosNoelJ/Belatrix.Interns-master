using AutoFixture;
using Belatrix.Models;
using Belatrix.Repository;
using Belatrix.WebApi.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Belatrix.WebApi.Tests
{
    public class ArtistControllerTests
    {
        private ArtistController _artist;
        [SetUp]
        public void Setup()
        {
            _artist = new ArtistController(CreateUnitOfWork());
        }

        [Test]
        public void Get_GoodData_OkResult()
        {
            // Arrange            

            // Act
            var request = _artist.GetAll() as OkObjectResult;
            var result = (List<Artist>)request.Value;

            // Assert
            result.Count.Should().BeGreaterThan(0);
        }

        [Test]
        public void Post_GoodData_TrueResult()
        {
            //var request = _artist.Add(NewArtist());
            var request = _artist.Add(NewArtist()) as OkObjectResult;
            var result = (int)request.Value;

            result.Should().BeGreaterThan(0);
        }

        [Test]
        public void Post_Null_BadDataRquest()
        {
            var result = _artist.Add(null);

            result.Should().BeOfType<BadRequestResult>();
        }

        [Test]
        public void Update_GoodData_TrueResult()
        {
            var request = _artist.Update(NewArtist()) as OkObjectResult;
            var result = (int)request.Value;

            result.Should().BeGreaterThan(0);
        }

        [Test]
        public void Delete_GoodData_TrueResult()
        {
            var request = _artist.Delete(NewArtist()) as OkObjectResult;
            var result = (int)request.Value;

            result.Should().BeGreaterThan(0);
        }

        private IUnitOfWork CreateUnitOfWork()
        {
            var fixture = new Fixture();
            var artist = fixture.Build<Artist>()
                .Without(a => a.Album)
                .CreateMany<Artist>(100).ToList();

            var artistRepository = new Mock<IRepository<Artist>>();
            artistRepository.Setup(x => x.Add(It.Is<Artist>(a => a.ArtistId == 1))).Returns(1);
            artistRepository.Setup(x => x.Update(It.Is<Artist>(a => a.ArtistId == 1))).Returns(1);
            artistRepository.Setup(x => x.Delete(It.Is<Artist>(a => a.ArtistId == 1))).Returns(1);
            artistRepository.Setup(x => x.GetList()).Returns(artist);

            var unit = new Mock<IUnitOfWork>();
            unit.Setup(x => x.Artists).Returns(artistRepository.Object);
            return unit.Object;
        }

        private Artist NewArtist()
        {
            return new Artist
            {
                ArtistId = 1,
                Name = "Rodrigo Noel"
            };
        }
    }
}