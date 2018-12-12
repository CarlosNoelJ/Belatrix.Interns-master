using Belatrix.Integration.Models;
using RestSharp;
using System.Collections.Generic;


namespace Belatrix.Integration.ApiClients
{
    class InvoiceApiClient : ChinookApiClient
    {
        internal IRestResponse<List<Invoice>> GetInvoiceList()
        {
            var url = "/api/Invoice";
            var apiRequest = new RestRequest(url, Method.GET);
            return Execute<List<Invoice>>(apiRequest);
        }

        internal IRestResponse<Invoice> GetInvoiceById()
        {
            var url = "/api/Invoice/1";
            var apiRequest = new RestRequest(url, Method.GET);

            return Execute<Invoice>(apiRequest);
        }

        internal IRestResponse<int> PostInvoice()
        {
            var url = "/api/Invoice/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.POST);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new {
                customerId = 14,
                invoiceDate = "2009-01-06T00:00:00",
                billingAddress = "8210 111 ST NW",
                billingCity = "Edmonton",
                billingState = "AB",
                billingCountry = "Huaralino",
                billingPostalCode = "T6G 2C7",
                total = 8.91,
            });

           
            
            return Execute<int>(apiRequest);
        }

        internal IRestResponse<int> PutInvoice()
        {
            var url = "/api/Invoice/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.PUT);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new
            {
                invoiceId = 413,
                customerId = 14,
                invoiceDate = "2009-01-06T00:00:00",
                billingAddress = "8210 111 ST NW",
                billingCity = "Edmonton",
                billingState = "AB",
                billingCountry = "Negroide",
                billingPostalCode = "T6G 2C7",
                total = 8.91,
            });


            return Execute<int>(apiRequest);
        }
        internal IRestResponse<int> DeleteInvoice()
        {
            var url = "/api/Invoice/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.DELETE);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { InvoiceId = 413 });


            return Execute<int>(apiRequest);
        }
    }
}
