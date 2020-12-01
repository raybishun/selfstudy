using System;
using System.Collections.Generic;
using System.Text;

namespace HttpClientIntroConsoleApp.Models
{
    class ToDo
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }

        public override string ToString()
        {
            return $"{UserId}, {Id}, {Title}, {Completed}";
        }
    }
}
