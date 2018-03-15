using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RestSharp;
using Newtonsoft.Json;
using Common;
using Common.Data;

namespace Calculator2
{
    public static class DeskShellAPI
    {
        private static APIResult Post<T>(string path, T data)
        {
            try
            {
                var client = new RestClient(ConfigurationManager.AppSettings["LocalURL"] ?? "");
                var request = new RestRequest(path, Method.POST);

                request.Parameters.Clear();
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", JsonConvert.SerializeObject(data), ParameterType.RequestBody);

                return (APIResult)JsonConvert.DeserializeObject(client.Execute(request).Content);
            }
            catch (Exception ex)
            {                
                return null;
            }
        }

        public static APIResult Register(UserRegistration user)
        {
            return Post("/Register", user);
        }

        public static APIResult Login(UserAuthentication user)
        {
            return Post("/Login", user);
        }
    }
}
