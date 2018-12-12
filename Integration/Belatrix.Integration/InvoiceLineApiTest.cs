using Belatrix.Integration.ApiClients;
using Belatrix.Integration.Models;
using FluentAssertions;
using NUnit.Framework;


namespace Belatrix.Integration
{
    public class InvoiceLineApiTest
    {
        private InvoiceLineApiClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new InvoiceLineApiClient();
        }

        [Test]
        [Order(1)]
        public void GetList_OkResponse()
        {
            var result = _client.GetInvoiceLineList();

            result.Data.Should().AllBeOfType(typeof(InvoiceLine)).And.HaveCountGreaterThan(1);
        }

        [Test]
        [Order(2)]
        public void GetListId_OkResponse()
        {
            var result = _client.GetInvoiceLineById();

            result.Data.Should().BeOfType(typeof(InvoiceLine));
        }

        [Test]
        [Order(3)]
        public void Post_OkResponse()
        {
            var result = _client.PostInvoiceLine();


            result.Data.Should().Be(1);
        }

        [Test]
        [Order(4)]
        public void Put_OkResponse()
        {
            var result = _client.PutInvoiceLine();

            result.Data.Should().Be(1);
        }

        [Test]
        [Order(5)]
        public void Delete_OkResponse()
        {
            var result = _client.DeleteInvoiceLine();

            result.Data.Should().Be(1);
        }
    }
}
