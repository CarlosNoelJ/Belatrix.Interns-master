using Belatrix.Integration.ApiClients;
using Belatrix.Integration.Models;
using FluentAssertions;
using NUnit.Framework;


namespace Belatrix.Integration
{
    public  class  EmployeeApiTest
    {
        private EmployeeApiClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new EmployeeApiClient();
        }

        [Test]
        [Order(1)]
        public void GetList_OkResponse()
        {
            var result = _client.GetEmployeeList();

            result.Data.Should().AllBeOfType(typeof(Employee)).And.HaveCountGreaterThan(1);
        }

        [Test]
        [Order(2)]
        public void GetListId_OkResponse()
        {
            var result = _client.GetEmployeeById();

            result.Data.Should().BeOfType(typeof(Employee));
        }

        [Test]
        [Order(3)]
        public void Post_OkResponse()
        {
            var result = _client.PostEmployee();

            result.Data.Should().Be(1);
        }

        [Test]
        [Order(4)]
        public void Put_OkResponse()
        {
            var result = _client.PutEmployee();

            result.Data.Should().Be(1);
        }

        [Test]
        [Order(5)]
        public void Delete_OkResponse()
        {
            var result = _client.DeleteEmployee();

            result.Data.Should().Be(1);
        }
    }
}