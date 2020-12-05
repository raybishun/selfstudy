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

        static async Task Main(string[] args)
        {
            List<Todo> todoList = await GetToDoListAsync();

            foreach (var todo in todoList)
            {
                Console.WriteLine(todo.ToString());
            }
        }

        static async Task<List<Todo>> GetToDoListAsync()
        {
            string jsonResult = await client.GetStringAsync(requestUri);

            return JsonConvert.DeserializeObject<List<Todo>>(jsonResult);
        }
    }
}
