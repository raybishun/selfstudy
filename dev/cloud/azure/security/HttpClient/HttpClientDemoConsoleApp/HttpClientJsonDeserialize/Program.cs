using HttpClientJsonDeserialize.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HttpClientJsonDeserialize
{
    class Program
    {
        static readonly string requestUri = "https://jsonplaceholder.typicode.com/todos";

        static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            
        }

        static async Task ShowToDoListDeserializedAsync()
        {
            List<Todo> todoList = await GetToDoListDeserializedAsync();

            foreach (var todo in todoList)
            {
                Console.WriteLine(todo.ToString());
            }
        }

        static async Task<List<Todo>> GetToDoListDeserializedAsync()
        {
            string results = await client.GetStringAsync(requestUri);

            return JsonConvert.DeserializeObject<List<Todo>>(results);
        }
    }
}
