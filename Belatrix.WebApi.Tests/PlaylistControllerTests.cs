using AutoFixture;
using Belatrix.Models;
using Belatrix.Repository;
using Belatrix.WebApi.Controllers;
using Moq;
using NUnit.Framework;
using System.Linq;

namespace Belatrix.WebApi.Tests
{
    public class PlaylistControllerTests
    {
        private PlaylistController _playlist;

        [SetUp]
        public void Setup()
        {
            _playlist = new PlaylistController(CreateUnitOfWork());
        }



        private IUnitOfWork CreateUnitOfWork()
        {
            var fixture = new Fixture();
            var playlist = fixture.Build<Playlist>().Without(p => p.PlaylistTrack).CreateMany<Playlist>(100).ToList();

            var playListRepository = new Mock<IRepository<Playlist>>();

            playListRepository.Setup(x => x.Add(It.Is<Playlist>(p => p.PlaylistId == 1))).Returns(1);

            var unit = new Mock<IUnitOfWork>();
            unit.Setup(x => x.Playlist).Returns(playListRepository.Object);

            return unit.Object;
        }
    }
}
