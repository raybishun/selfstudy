using Microsoft.Graph;
using System;
using System.Net.Http.Headers;

namespace ExploringGraphAPI
{
    class Program
    {
        // Use Graph Explorer to get your token: https://developer.microsoft.com/en-us/graph/graph-explorer
        static readonly string _accessToken = "eyJ0eXAiOiJKV1QiLCJub25jZSI6ImVNVFEtRWJvZ2FISS1nV0NrZHJVZ3pyX09udUlTSFJhOVF3TmdSblUxeTgiLCJhbGciOiJSUzI1NiIsIng1dCI6ImtnMkxZczJUMENUaklmajRydDZKSXluZW4zOCIsImtpZCI6ImtnMkxZczJUMENUaklmajRydDZKSXluZW4zOCJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTAwMDAtYzAwMC0wMDAwMDAwMDAwMDAiLCJpc3MiOiJodHRwczovL3N0cy53aW5kb3dzLm5ldC8xODBkMGFiMy0zMjBmLTQ5NzktODQxYS1hNzU5MDEwNWUzYTIvIiwiaWF0IjoxNjA2MzYwMzczLCJuYmYiOjE2MDYzNjAzNzMsImV4cCI6MTYwNjM2NDI3MywiYWNjdCI6MCwiYWNyIjoiMSIsImFjcnMiOlsidXJuOnVzZXI6cmVnaXN0ZXJzZWN1cml0eWluZm8iLCJ1cm46bWljcm9zb2Z0OnJlcTEiLCJ1cm46bWljcm9zb2Z0OnJlcTIiLCJ1cm46bWljcm9zb2Z0OnJlcTMiLCJjMSIsImMyIiwiYzMiLCJjNCIsImM1IiwiYzYiLCJjNyIsImM4IiwiYzkiLCJjMTAiLCJjMTEiLCJjMTIiLCJjMTMiLCJjMTQiLCJjMTUiLCJjMTYiLCJjMTciLCJjMTgiLCJjMTkiLCJjMjAiLCJjMjEiLCJjMjIiLCJjMjMiLCJjMjQiLCJjMjUiXSwiYWlvIjoiQVNRQTIvOFJBQUFBNm8vTEgrbVRFVkEzckVyS3hpZ0RQTEtzaG1HaTVNRWx3RkxNSVNyQ243Zz0iLCJhbXIiOlsicHdkIl0sImFwcF9kaXNwbGF5bmFtZSI6IkdyYXBoIGV4cGxvcmVyIChvZmZpY2lhbCBzaXRlKSIsImFwcGlkIjoiZGU4YmM4YjUtZDlmOS00OGIxLWE4YWQtYjc0OGRhNzI1MDY0IiwiYXBwaWRhY3IiOiIwIiwiZmFtaWx5X25hbWUiOiJCaXNodW4iLCJnaXZlbl9uYW1lIjoiUmF5IiwiaWR0eXAiOiJ1c2VyIiwiaXBhZGRyIjoiMjQuMTAyLjExMy4xOTciLCJuYW1lIjoiUmF5IEJpc2h1biIsIm9pZCI6IjU4MDBjZjNkLWQzMDEtNDQ2Yy1iZWU2LWEwNjM4ZGZjYzQyNyIsInBsYXRmIjoiMyIsInB1aWQiOiIxMDAzMjAwMDQ5RTg0RTFEIiwicmgiOiIwLkFUY0Fzd29OR0E4eWVVbUVHcWRaQVFYam9yWElpOTc1MmJGSXFLMjNTTnB5VUdRM0FBMC4iLCJzY3AiOiJDYWxlbmRhcnMuUmVhZFdyaXRlIENvbnRhY3RzLlJlYWRXcml0ZSBGaWxlcy5SZWFkV3JpdGUuQWxsIE1haWwuUmVhZFdyaXRlIE1haWwuU2VuZCBOb3Rlcy5SZWFkV3JpdGUuQWxsIG9wZW5pZCBQZW9wbGUuUmVhZCBwcm9maWxlIFNlY3VyaXR5RXZlbnRzLlJlYWQuQWxsIFNlY3VyaXR5RXZlbnRzLlJlYWRXcml0ZS5BbGwgU2l0ZXMuUmVhZFdyaXRlLkFsbCBUYXNrcy5SZWFkV3JpdGUgVXNlci5SZWFkIFVzZXIuUmVhZEJhc2ljLkFsbCBVc2VyLlJlYWRXcml0ZSBlbWFpbCIsInNpZ25pbl9zdGF0ZSI6WyJpbmtub3dubnR3ayJdLCJzdWIiOiJWdHJZVlpmZHk0ZU05XzV1dHVBREx0cjZEUlB5dy1wQU43RXp1c045YXZBIiwidGVuYW50X3JlZ2lvbl9zY29wZSI6Ik5BIiwidGlkIjoiMTgwZDBhYjMtMzIwZi00OTc5LTg0MWEtYTc1OTAxMDVlM2EyIiwidW5pcXVlX25hbWUiOiJyYXkuYmlzaHVuQGJpdHNieXRlcy5jb20iLCJ1cG4iOiJyYXkuYmlzaHVuQGJpdHNieXRlcy5jb20iLCJ1dGkiOiJCc1k0dVhmYmswRzA3WGNIRjlfVkFBIiwidmVyIjoiMS4wIiwid2lkcyI6WyIxOTRhZTRjYi1iMTI2LTQwYjItYmQ1Yi02MDkxYjM4MDk3N2QiLCJlODYxMWFiOC1jMTg5LTQ2ZTgtOTRlMS02MDIxM2FiMWY4MTQiLCI2MmU5MDM5NC02OWY1LTQyMzctOTE5MC0wMTIxNzcxNDVlMTAiLCJiNzlmYmY0ZC0zZWY5LTQ2ODktODE0My03NmIxOTRlODU1MDkiXSwieG1zX3N0Ijp7InN1YiI6Imdhb3RXUi1Oc0I3Nmktek90N3JPeFBxVkZPMkhiN0VJaWY2Z0hvSmtoaG8ifSwieG1zX3RjZHQiOjE1NTg4Mjc3OTF9.mCXKyaJT00FroXlPQVOOrE04nDf4v622pgynwgnK85kuCVqKidTiBotfBRcvpi6Xle5W4FXH1703dvHmkcwimd6ee9lJYZS5h7rTIzC6Si22PgZjieIlVDPedtiylWzmxNUpFiNvKxLhBDXbIdsw-pI-SXP0TUo6pb4hHDYB8tHZOFxYvQSSLs-TE5E_QEv2Vm7zuqv3PhDJNA5PPwslKIqK2fxFLivKuZxrrRBVkA7WMnZvj2oPZwtAgnmcgM54n8l8FaV6HsoFQ9XvLoDwdLdHLlBUkCNL2fgpcwFSh_n7Ojjy4CWXH0B8Ob43IxxW10jBZbGSCECd01I8atfsIw";

        static readonly GraphServiceClient _client = new GraphServiceClient(new DelegateAuthenticationProvider(async request => {
            request.Headers.Authorization = new AuthenticationHeaderValue("bearer", _accessToken);
        }));

        static void Main(string[] args)
        {
            GetUnFilteredMessages();
            GetFilteredMessages();
            SendMessage();
        }

        static void GetUnFilteredMessages(int qty = 5)
        {
            var messages = _client.Me.Messages.Request().Top(qty).GetAsync().Result;

            foreach (var message in messages)
            {
                Console.WriteLine($"{message.SentDateTime} \t {message.Subject}");
            }
        }

        static void GetFilteredMessages(int qty = 3)
        {
            var messages = _client.Me.Messages.Request()
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

        static void SendMessage()
        {

        }
    }
}
