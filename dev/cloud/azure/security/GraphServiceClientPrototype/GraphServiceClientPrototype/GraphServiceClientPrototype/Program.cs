using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
using Microsoft.Graph;

namespace GraphServiceClientPrototype
{
    class Program
    {
        static string _accessToken = string.Empty;

        static void Main(string[] args)
        {
            GetTokenViaGraphExplorer();
            GetUnFilteredMessages();
            GetFilteredMessages();
            SendMail();
        }

        static void GetTokenViaGraphExplorer()
        {
            // Graph Explorer: https://developer.microsoft.com/en-us/graph/graph-explorer

            string path = @"C:\SecureStore\AzureTenant.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            _accessToken = lines[0];
        }

        static GraphServiceClient GraphClient(string accessToken)
        {
            return new GraphServiceClient(new DelegateAuthenticationProvider(async request =>
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("bearer", accessToken);
            }));
        }

        static void GetUnFilteredMessages(int qty = 5)
        {
            var graphServiceClient = GraphClient(_accessToken);

            try
            {
                var messages = graphServiceClient.Me.Messages.Request().Top(qty).GetAsync().Result;
                
                foreach (var message in messages)
                {
                    Console.WriteLine($"{message.SentDateTime} \t {message.Subject}");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        static void GetFilteredMessages(int qty = 3)
        {
            var graphServiceClient = GraphClient(_accessToken);

            try
            {
                var messages = graphServiceClient.Me.Messages.Request()
                .Select(m => new { m.Subject, m.SentDateTime })
                .Filter("hasAttachments eq true")
                .Expand(m => m.Attachments)
                .Top(qty)
                .GetAsync().Result;

                foreach (var message in messages)
                {
                    Console.WriteLine($"{message.SentDateTime} \t {message.Subject}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void SendMail()
        {
            var graphServiceClient = GraphClient(_accessToken);

            var myMessage = new Message()
            {
                ToRecipients = new List<Recipient> { new Recipient()
                    {
                        EmailAddress = new EmailAddress() { Address = "john_smith@e-mail.com" }
                    }
                },
                Subject = "Hello from GraphAPI",
                Body = new ItemBody()
                {
                    ContentType = BodyType.Text,
                    Content = "Hello from Graph from way back in January 29, 2019. Please update me..."
                }
            };

            // graphServiceClient.Me.SendMail(myMessage).Request().PostAsync();
            var request = graphServiceClient.Me.SendMail(myMessage).Request().GetHttpRequestMessage();

            var httpClient = new HttpClient();
            httpClient.SendAsync(request);
        }
    }
}

// References
// 1. Graph Explorer: https://developer.microsoft.com/en-us/graph/graph-explorer
// 2. Overview of Microsoft Graph: https://docs.microsoft.com/en-us/graph/overview
// 3. Microsoft Graph REST API v1.0 reference: https://docs.microsoft.com/en-us/graph/api/overview?view=graph-rest-1.0
// 4. Decode Token: https://jwt.ms/