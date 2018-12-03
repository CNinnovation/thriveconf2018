using Books.Shared;
using Microsoft.AspNetCore.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Books.BlazorClient.Services
{
    public class BooksClientService
    {
        private readonly HttpClient _httpClient;
        public BooksClientService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<IEnumerable<Book>> GetBooksAsync(string uri)
        {
            var books = await _httpClient.GetJsonAsync<IEnumerable<Book>>(uri);
            return books;
        }
    }
}
