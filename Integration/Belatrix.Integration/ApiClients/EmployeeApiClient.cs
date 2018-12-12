using Belatrix.Integration.Models;
using RestSharp;
using System.Collections.Generic;

namespace Belatrix.Integration.ApiClients
{
    class EmployeeApiClient : ChinookApiClient
    {
        internal IRestResponse<List<Employee>> GetEmployeeList()
        {
            var url = "/api/Employee";
            var apiRequest = new RestRequest(url, Method.GET);
            return Execute<List<Employee>>(apiRequest);
        }

        internal IRestResponse<Employee> GetEmployeeById()
        {
            var url = "/api/Employee/1";
            var apiRequest = new RestRequest(url, Method.GET);

            return Execute<Employee>(apiRequest);
        }

        internal IRestResponse<int> PostEmployee()
        {
            var url = "/api/Employee/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.POST);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new {
                lastName = "Bonaparte",
                firstName = "CHACALON",
                title = "General Manager",
                reportsTo = 5,
                birthDate = "1962-02-18T00:00:00",
                hireDate = "2002-08-14T00:00:00",
                address = "11120 Jasper Ave NW",
                city = "Edmonton",
                state = "AB",
                country = "Canada",
                postalCode = "T5K 2N1",
                phone = "+1 (780) 428-9482",
                fax = "+1 (780) 428-3457",
                email = "andrew@chinookcorp.com",
            });
            
            
            return Execute<int>(apiRequest);
        }

        internal IRestResponse<int> PutEmployee()
        {
            var url = "/api/Employee/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.PUT);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new
            {
                employeeId = 9,
                lastName = "Bonaparte",
                firstName = "CHACALON",
                title = "General Manager",
                reportsTo = 5,
                birthDate = "1962-02-18T00:00:00",
                hireDate = "2002-08-14T00:00:00",
                address = "11120 Jasper Ave NW",
                city = "Edmonton",
                state = "AB",
                country = "Canada",
                postalCode = "T5K 2N1",
                phone = "+1 (780) 428-9482",
                fax = "+1 (780) 428-3457",
                email = "andrew@chinookcorp.com",
            });


            return Execute<int>(apiRequest);
        }
        internal IRestResponse<int> DeleteEmployee()
        {
            var url = "/api/Employee/";

            // Cuando se anida, no se le da propiedades
            var apiRequest = new RestRequest(url, Method.DELETE);

            apiRequest.RequestFormat = DataFormat.Json;
            apiRequest.AddBody(new { EmployeeId = 9 });


            return Execute<int>(apiRequest);
        }
    }
}
