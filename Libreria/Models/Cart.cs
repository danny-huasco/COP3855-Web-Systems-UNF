using System.Collections.Generic;
using System.Text.Json;
using Libreria.Models;

namespace Libreria.Models
{
    public class Cart
    {
        private List<Book> items;
        public List<Book> Items
        {
            get { return items; }
            set { items = value; }
        }
        public void GetItems()
        {
            var libros = Book.GetBooks("./wwwroot/cart.json");
            this.Items = libros;
        }
        public void AddItem(string isbn)
        {
            var books = Book.GetBooks("./wwwroot/libros.json");
            var cart = Book.GetBooks("./wwwroot/cart.json");
            this.Items = cart;
            var book = books.Find(x => x.isbn == isbn);

            this.items.Add(book);

            SaveItemsToFile(this.items, "./wwwroot/cart.json");
        }

        public void RemoveItem(string isbn)
        {
            var cart = Book.GetBooks("./wwwroot/cart.json");
            this.Items = cart;
            var del = this.items.Find(x => x.isbn == isbn);
            this.items.Remove(del);
            SaveItemsToFile(this.items, "./wwwroot/cart.json");
        }

        public double GetTotalPrice()
        {
            double total = 0;
            foreach (var item in this.items)
            {
                total += Convert.ToDouble(item.price);
            }
            return total;
        }

        public void ClearCart()
        {
            this.items.Clear();
            SaveItemsToFile(this.items, "./wwwroot/cart.json");
        }

        private void SaveItemsToFile(List<Book> items, string filePath)
        {
            var json = JsonSerializer.Serialize(items);
            File.WriteAllText(filePath, json);
        }
    }
}
