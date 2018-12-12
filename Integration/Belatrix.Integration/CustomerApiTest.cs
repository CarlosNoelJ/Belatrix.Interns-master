using Belatrix.Integration.ApiClients;
using Belatrix.Integration.Models;
using FluentAssertions;
using NUnit.Framework;

namespace Belatrix.Integration
{
    public class CustomerApiTest
    {
        private CustomerApiClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new CustomerApiClient();
        }

        [Test]
        [Order(1)]
        public void GetList_OkResponse()
        {
            var result = _client.GetCustomerList();

            result.Data.Should().AllBeOfType(typeof(Customer)).And.HaveCountGreaterThan(1);
        }

        [Test]
        [Order(2)]
        public void GetListId_OkResponse()
        {
            var result = _client.GetCustomerById();

            result.Data.Should().BeOfType(typeof(Customer));
        }

        [Test]
        [Order(3)]
        public void Post_OkResponse()
        {
            var result = _client.PostCustomer();

            result.Data.Should().Be(1);
        }

        [Test]
        [Order(4)]
        public void Put_OkResponse()
        {
            var result = _client.PutCustomer();

            result.Data.Should().Be(1);
        }

        [Test]
        [Order(5)]
        public void Delete_OkResponse()
        {
            var result = _client.DeleteCustomer();

            result.Data.Should().Be(1);
        }
    }
}
