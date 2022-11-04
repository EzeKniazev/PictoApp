using AppQEEP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppQEEP.Services //ESTE ELEMENTO DE CLASE NO TIENE RELEVANCIA PARA EL PROYECTO - SE PODRA ELIMINAR MAS ADELANTE.
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Primer elemento", Description="Esta es una descripción del artículo." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Segundo artículo", Description="Esta es una descripción del artículo." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Tercer artículo", Description="Esta es una descripción del artículo." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Cuarto artículo", Description="Esta es una descripción del artículo." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Quinto artículo", Description="Esta es una descripción del artículo." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sexto artículo", Description="Esta es una descripción del artículo." }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}