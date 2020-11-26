using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Graph;

namespace ExploringGraphAPI
{
    class Program
    {

        static void Main(string[] args)
        {
            GetUnFilteredMessages();
            GetFilteredMessages();
            SendMail();
        }

        static string GetToken()
        {
            // Use Graph Explorer to get your temporary token: https://developer.microsoft.com/en-us/graph/graph-explorer
            return "";
        }

        static GraphServiceClient Client(string accessToken)
        {
            return new GraphServiceClient(new DelegateAuthenticationProvider(async request =>
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("bearer", accessToken);
            }));
        }

        static void GetUnFilteredMessages(int qty = 5)
        {
            var graphServiceClient = Client(GetToken());

            var messages = graphServiceClient.Me.Messages.Request().Top(qty).GetAsync().Result;

            foreach (var message in messages)
            {
                Console.WriteLine($"{message.SentDateTime} \t {message.Subject}");
            }
        }

        static void GetFilteredMessages(int qty = 3)
        {
            var graphServiceClient = Client(GetToken());

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

        static void SendMail()
        {
            var graphServiceClient = Client(GetToken());

            var myMessage = new Message()
            {
                ToRecipients = new List<Recipient> { new Recipient()
                    {
                        EmailAddress = new EmailAddress() { Address = "ray.bishun@bitsbytes.com" }
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
// 1. https://developer.microsoft.com/en-us/graph/graph-explorer
// 2. https://docs.microsoft.com/en-us/graph/overview
// 3. https://docs.microsoft.com/en-us/graph/api/overview?view=graph-rest-1.0
// 3. https://www.youtube.com/watch?v=1ytDvWdOMpI&t=1s
