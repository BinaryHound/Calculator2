using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RestSharp;
using Newtonsoft.Json;
using Calculator2.API_Models;

namespace Calculator2
{
    public static class DeskShellAPI
    {
        private static string Post<T>(string path, T data)
        {
            try
            {
                var client = new RestClient(ConfigurationManager.AppSettings["LocalURL"]);
                var request = new RestRequest(path, Method.POST);

                request.Parameters.Clear();
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", JsonConvert.SerializeObject(data), ParameterType.RequestBody);

                return client.Execute(request).Content;
            }
            catch (Exception ex)
            {                
                return null;
            }
        }

        public static string Register(User user)
        {
            return Post("/Register", user);
        }
    }
}
