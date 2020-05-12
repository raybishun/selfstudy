using Microsoft.Graph;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace GraphApiUnitTest
{
    [TestClass]
    public class UnitTest
    {
        private static readonly string sessionToken = "";

        private static readonly GraphServiceClient graphServiceClient = new GraphServiceClient(
            new DelegateAuthenticationProvider(
                async httpRequestMessage =>
                {
                    httpRequestMessage.Headers.Authorization =
                    new AuthenticationHeaderValue("Bearer", sessionToken);
                }));

        [TestMethod]
        public void TestGetMessages()
        {
            // var messages = graphServiceClient.Me.Messages.Request().GetAsync().Result;
            // var messages = graphServiceClient.Me.Messages.Request().Top(10).GetAsync().Result;
            var messages = graphServiceClient.Me.Messages.Request()
                .Select(m => new { m.SentDateTime, m.Subject })
                // .Filter("hasAttachments eq true")
                // .Expand(m => m.Attachments)
                .Top(10)
                .GetAsync().Result;

            foreach (var message in messages)
            {
                Console.WriteLine($"{message.SentDateTime}\t{message.Subject}");
            }
        }

        [TestMethod]
        public void TestSendMail()
        {
            var message = new Message()
            {
                ToRecipients = new List<Recipient>
                {
                    new Recipient()
                    {
                        EmailAddress = new EmailAddress() { Address = "peter.parker@contoso.com" }
                    }
                },
                Subject = "Hello",
                Body = new ItemBody()
                {
                    ContentType = BodyType.Text,
                    Content = "This is a test..."
                }
            };

            graphServiceClient.Me.SendMail(message).Request().PostAsync();

            // HttpRequestMessage httpRequestMessage = graphServiceClient.Me.SendMail(message).Request().GetHttpRequestMessage();
            // HttpClient httpClient = new HttpClient();
            // httpClient.SendAsync(httpRequestMessage);
        }
    }
}
