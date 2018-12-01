using Belatrix.Models;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Belatrix.Repository.SqlServer.Tests
{
    public class ArtistRepositoryTest
    {
        private UnitOfWork _unit;

        [SetUp]
        public void Setup()
        {
            _unit = new UnitOfWork(new ChinookContext(
                new DbContextOptionsBuilder<ChinookContext>().UseMySQL<ChinookContext>("server=localhost;port=3306;userid=root;password=Ydaleu92;database=chinook;").Options
                ));
        }

        //[Test]
        public void Artist_GoodData_Insert()
        {
            // Arrange
            var artist = new Artist
            {
                Name = "Toño Centella"
            };

            // Act
            var result = _unit.Artists.Add(artist);

            // Assert
            result.Should().BeGreaterThan(0);
        }
    }
}
