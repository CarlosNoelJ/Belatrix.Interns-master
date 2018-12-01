using Belatrix.Models;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Belatrix.Repository.SqlServer.Tests
{
    public class PlaylistRepositoryTests
    {
        private UnitOfWork _unit;

        [SetUp]
        public void Setup()
        {
            _unit = new UnitOfWork(new ChinookContext(
                new DbContextOptionsBuilder<ChinookContext>().UseMySQL<ChinookContext>("server=localhost;port=3306;userid=root;password=Ydaleu92;database=chinook;").Options
                ));
        }

       // [Test]
        public void Insert_GoodData_Return_One()
        {
            //Arrange
            var playlist = new Playlist
            {
                Name = "School of Rock"
            };

            //Act
            var result = _unit.Playlist.Add(playlist);

            //Assert
            result.Should().BeGreaterThan(0);
        }

        //[Test]
        public void Update_GoodDataReturn_True()
        {
            var playlist = new Playlist
            {
                PlaylistId = 20,
                Name = "School of the Death"
            };

            var result = _unit.Playlist.Update(playlist);

            result.Should().BeGreaterThan(0);
        }

        //[Test]
        public void Delete_GoodDataReturn_True()
        {
            var playlist = new Playlist
            {
                PlaylistId = 20
            };

            var result = _unit.Playlist.Delete(playlist);

            result.Should().BeGreaterThan(0);
        }
    }
}