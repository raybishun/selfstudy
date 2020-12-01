using HttpClientIntroConsoleApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientIntroConsoleApp
{
    class Program
    {
        static readonly string _requestUri = "https://jsonplaceholder.typicode.com/todos";
        static readonly HttpClient _client = new HttpClient();

        static async Task Main(string[] args)
        {
            await ShowToDoListAsync();
            await ShowToDoListDeserializedAsync();
        }

        static async Task ShowToDoListAsync()
        {
            Console.WriteLine(await GetToDoListAsync());
        }

        static async Task<string> GetToDoListAsync()
        {
            return await _client.GetStringAsync(_requestUri);
        }


        // ====================================================================
        // Deserialized JSON
        // ====================================================================
        static async Task ShowToDoListDeserializedAsync()
        {
            List<ToDo> todoList = await GetToDoListDeserializedAsync();

            foreach (var todo in todoList)
            {
                Console.WriteLine(todo.ToString());
            }
        }

        static async Task<List<ToDo>> GetToDoListDeserializedAsync()
        {
            string results = await _client.GetStringAsync(_requestUri);

            return JsonConvert.DeserializeObject<List<ToDo>>(results);
        }
    }
}
