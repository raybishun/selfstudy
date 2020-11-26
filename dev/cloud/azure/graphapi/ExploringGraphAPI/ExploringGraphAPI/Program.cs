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
            return "eyJ0eXAiOiJKV1QiLCJub25jZSI6Ii1JNUtGNTlxMDlrUVhaZmhKcTJZNjdTeDluaGJXdjhSOG9fMnc2UWpsMG8iLCJhbGciOiJSUzI1NiIsIng1dCI6ImtnMkxZczJUMENUaklmajRydDZKSXluZW4zOCIsImtpZCI6ImtnMkxZczJUMENUaklmajRydDZKSXluZW4zOCJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTAwMDAtYzAwMC0wMDAwMDAwMDAwMDAiLCJpc3MiOiJodHRwczovL3N0cy53aW5kb3dzLm5ldC8xODBkMGFiMy0zMjBmLTQ5NzktODQxYS1hNzU5MDEwNWUzYTIvIiwiaWF0IjoxNjA2MzYzODkwLCJuYmYiOjE2MDYzNjM4OTAsImV4cCI6MTYwNjM2Nzc5MCwiYWNjdCI6MCwiYWNyIjoiMSIsImFjcnMiOlsidXJuOnVzZXI6cmVnaXN0ZXJzZWN1cml0eWluZm8iLCJ1cm46bWljcm9zb2Z0OnJlcTEiLCJ1cm46bWljcm9zb2Z0OnJlcTIiLCJ1cm46bWljcm9zb2Z0OnJlcTMiLCJjMSIsImMyIiwiYzMiLCJjNCIsImM1IiwiYzYiLCJjNyIsImM4IiwiYzkiLCJjMTAiLCJjMTEiLCJjMTIiLCJjMTMiLCJjMTQiLCJjMTUiLCJjMTYiLCJjMTciLCJjMTgiLCJjMTkiLCJjMjAiLCJjMjEiLCJjMjIiLCJjMjMiLCJjMjQiLCJjMjUiXSwiYWlvIjoiQVNRQTIvOFJBQUFBd0hPZDQxNmVIM05ETnh2cGNML3p4TlFzMk1EN2hWQWxBRkRKWjFLV2xKRT0iLCJhbXIiOlsicHdkIl0sImFwcF9kaXNwbGF5bmFtZSI6IkdyYXBoIGV4cGxvcmVyIChvZmZpY2lhbCBzaXRlKSIsImFwcGlkIjoiZGU4YmM4YjUtZDlmOS00OGIxLWE4YWQtYjc0OGRhNzI1MDY0IiwiYXBwaWRhY3IiOiIwIiwiZmFtaWx5X25hbWUiOiJCaXNodW4iLCJnaXZlbl9uYW1lIjoiUmF5IiwiaWR0eXAiOiJ1c2VyIiwiaXBhZGRyIjoiMjQuMTAyLjExMy4xOTciLCJuYW1lIjoiUmF5IEJpc2h1biIsIm9pZCI6IjU4MDBjZjNkLWQzMDEtNDQ2Yy1iZWU2LWEwNjM4ZGZjYzQyNyIsInBsYXRmIjoiMyIsInB1aWQiOiIxMDAzMjAwMDQ5RTg0RTFEIiwicmgiOiIwLkFUY0Fzd29OR0E4eWVVbUVHcWRaQVFYam9yWElpOTc1MmJGSXFLMjNTTnB5VUdRM0FBMC4iLCJzY3AiOiJDYWxlbmRhcnMuUmVhZFdyaXRlIENvbnRhY3RzLlJlYWRXcml0ZSBGaWxlcy5SZWFkV3JpdGUuQWxsIE1haWwuUmVhZFdyaXRlIE1haWwuU2VuZCBOb3Rlcy5SZWFkV3JpdGUuQWxsIG9wZW5pZCBQZW9wbGUuUmVhZCBwcm9maWxlIFNlY3VyaXR5RXZlbnRzLlJlYWQuQWxsIFNlY3VyaXR5RXZlbnRzLlJlYWRXcml0ZS5BbGwgU2l0ZXMuUmVhZFdyaXRlLkFsbCBUYXNrcy5SZWFkV3JpdGUgVXNlci5SZWFkIFVzZXIuUmVhZEJhc2ljLkFsbCBVc2VyLlJlYWRXcml0ZSBlbWFpbCIsInNpZ25pbl9zdGF0ZSI6WyJpbmtub3dubnR3ayJdLCJzdWIiOiJWdHJZVlpmZHk0ZU05XzV1dHVBREx0cjZEUlB5dy1wQU43RXp1c045YXZBIiwidGVuYW50X3JlZ2lvbl9zY29wZSI6Ik5BIiwidGlkIjoiMTgwZDBhYjMtMzIwZi00OTc5LTg0MWEtYTc1OTAxMDVlM2EyIiwidW5pcXVlX25hbWUiOiJyYXkuYmlzaHVuQGJpdHNieXRlcy5jb20iLCJ1cG4iOiJyYXkuYmlzaHVuQGJpdHNieXRlcy5jb20iLCJ1dGkiOiJydkJJSjhBNWZFT3VGUTJHR0xyZkFBIiwidmVyIjoiMS4wIiwid2lkcyI6WyIxOTRhZTRjYi1iMTI2LTQwYjItYmQ1Yi02MDkxYjM4MDk3N2QiLCJlODYxMWFiOC1jMTg5LTQ2ZTgtOTRlMS02MDIxM2FiMWY4MTQiLCI2MmU5MDM5NC02OWY1LTQyMzctOTE5MC0wMTIxNzcxNDVlMTAiLCJiNzlmYmY0ZC0zZWY5LTQ2ODktODE0My03NmIxOTRlODU1MDkiXSwieG1zX3N0Ijp7InN1YiI6Imdhb3RXUi1Oc0I3Nmktek90N3JPeFBxVkZPMkhiN0VJaWY2Z0hvSmtoaG8ifSwieG1zX3RjZHQiOjE1NTg4Mjc3OTF9.W5Wbl_00H1gLPcR0leUnQrfiPuycfRuvFDqTojr7bv4Q9mlQ0RYDwxyVJGQHUzolNxj0-6De_RzB91QrHqlufAwZ2GlOKV-OPmYXqkuRZkhX9wI6Ty22mNGEsXeWAp0k-shdxR1F2g2onN48fn8gZ62R-Ff9c1yKPIjWSBBg9Rj0dGSHsA5Y14DSDSoCwuydCS7LPdQttRof-dq0knV36K47WgS7jr0kM2FG7PakPPXT8HW4aFqznFOuB-4g59TZ-CNvayF-AfS_-E_VhbFbApCRR2wLv_hHe9cmc-zyN_QTwWi6c1fiSeerEKWStKEY8px4b6ykceR2e1tg8gka5w";
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
