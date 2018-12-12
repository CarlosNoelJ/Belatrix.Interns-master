using Belatrix.Integration.ApiClients;
using Belatrix.Integration.Models;
using FluentAssertions;
using NUnit.Framework;

namespace Belatrix.Integration
{
    public class InvoiceApiTest
    {
        private InvoiceApiClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new InvoiceApiClient();
        }

        [Test]
        [Order(1)]
        public void GetList_OkResponse()
        {
            var result = _client.GetInvoiceList();

            result.Data.Should().AllBeOfType(typeof(Invoice)).And.HaveCountGreaterThan(1);
        }

        [Test]
        [Order(2)]
        public void GetListId_OkResponse()
        {
            var result = _client.GetInvoiceById();

            result.Data.Should().BeOfType(typeof(Invoice));
        }

        [Test]
        [Order(3)]
        public void Post_OkResponse()
        {
            var result = _client.PostInvoice();

            result.Data.Should().Be(1);
        }

        [Test]
        [Order(4)]
        public void Put_OkResponse()
        {
            var result = _client.PutInvoice();

            result.Data.Should().Be(1);
        }

        [Test]
        [Order(5)]
        public void Delete_OkResponse()
        {
            var result = _client.DeleteInvoice();

            result.Data.Should().Be(1);
        }
    }
}
