using Belatrix.Integration.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Belatrix.Integration.ApiClients
{
    class InvoiceLineApiClient : ChinookApiClient
    {
        internal IRestResponse<List<InvoiceLine>> GetInvoiceLineList()
        {
            var url = "/api/InvoiceLine";
            var apiRequest = new RestRequest(url, Method.GET);
            return Execute<List<InvoiceLine>>(apiRequest);
        }

        internal IRestResponse<InvoiceLine> GetInvoiceLineById()
        {
            var url = "/api/InvoiceLine/1";
            var apiRequest = new RestRequest(url, Method.GET);

            return Execute<InvoiceLine>(apiRequest);
        }

        internal IRestResponse<int> PostInvoiceLine()
        {
            var url = "/api/InvoiceLine/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.POST);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new {
                invoiceId = 1,
                trackId = 5,
                unitPrice = 15.99,
                quantity = 1,
            });
                
            return Execute<int>(apiRequest);
        }

        internal IRestResponse<int> PutInvoiceLine()
        {
            var url = "/api/InvoiceLine/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.PUT);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new
            {
                invoiceLineId = 2241,
                invoiceId = 1,
                trackId = 5,
                unitPrice = 15.99,
                quantity = 1,
            });


            return Execute<int>(apiRequest);
        }
        internal IRestResponse<int> DeleteInvoiceLine()
        {
            var url = "/api/InvoiceLine/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.DELETE);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { InvoiceLineId = 2241 });


            return Execute<int>(apiRequest);
        }
    }
}
