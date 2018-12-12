using Belatrix.Integration.Models;
using RestSharp;
using System.Collections.Generic;

namespace Belatrix.Integration.ApiClients
{
    class CustomerApiClient: ChinookApiClient
    {
        internal IRestResponse<List<Customer>> GetCustomerList()
        {
            var url = "/api/Customer";
            var apiRequest = new RestRequest(url, Method.GET);
            return Execute<List<Customer>>(apiRequest);
        }

        internal IRestResponse<Customer> GetCustomerById()
        {
            var url = "/api/Customer/1";
            var apiRequest = new RestRequest(url, Method.GET);

            return Execute<Customer>(apiRequest);
        }

        internal IRestResponse<int> PostCustomer()
        {
            var url = "/api/Customer/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.POST);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { firstName = "Huaralino",
                lastName = "Gonçalves",
                company = "Embraer - Empresa Brasileira de Aeronáutica S.A.",
                address = "Av. Brigadeiro Faria Lima, 2170",
                city = "São José dos Campos",
                state = "SP",
                country = "Brazil",
                postalCode = "12227-000",
                phone = "+55 (12) 3923-5555",
                fax = "+55 (12) 3923-5566",
                email = "luisg@embraer.com.br",
                supportRepId = 3
            });
            
            return Execute<int>(apiRequest);
        }

        internal IRestResponse<int> PutCustomer()
        {
            var url = "/api/Customer/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.PUT);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new
            {
                customerId= 60,
                firstName = "Huaralino",
                lastName = "Gonçalves",
                company = "Embraer - Empresa Brasileira de Aeronáutica S.A.",
                address = "Av. Brigadeiro Faria Lima, 2170",
                city = "São José dos Campos",
                state = "SP",
                country = "Brazil",
                postalCode = "12227-000",
                phone = "+55 (12) 3923-5555",
                fax = "+55 (12) 3923-5566",
                email = "luisg@embraer.com.br",
                supportRepId = 3
            });


            return Execute<int>(apiRequest);
        }
        internal IRestResponse<int> DeleteCustomer()
        {
            var url = "/api/Customer/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.DELETE);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { CustomerId = 60 });


            return Execute<int>(apiRequest);
        }
    }
}
