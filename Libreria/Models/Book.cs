using Microsoft.AspNetCore.Hosting;
using System.Text.Json;

namespace Libreria.Models
{
    public class Book
    {
        public string isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string price { get; set; }
        public string photo { get; set; }

        public static List<Book> GetBooks(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Book>>(jsonString);
        }
    }
}
