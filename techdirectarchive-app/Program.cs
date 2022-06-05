// See https://aka.ms/new-console-template for more information

using System.Threading.Tasks;
using Microsoft.Identity.Client;

using System;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace techdirectarchiveapp
{
    class Program
    {
        private const string _clientId = "87421527-0815-43b2-a2ef-bc0a8e90ac8e";
        private const string _tenantId = "21cef452-6ccc-4171-9420-b34ecb234499";

        public static async Task Main(string[] args)
        {
            var app = PublicClientApplicationBuilder
                .Create(_clientId)
                .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
                .WithRedirectUri("http://localhost")
                .Build();
            string[] scopes = { "user.read" };
            AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();

            Console.WriteLine($"Token:\t{result.AccessToken}");
        }
    }
}





