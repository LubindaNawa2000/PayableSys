using System.Net.Http.Json;
using AccountPay;


namespace AccountPay.Services
{
    public class InvoiceService
    {
        private readonly HttpClient _httpClient;

        public InvoiceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Invoice>> GetInvoicesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Invoice>>("api/invoices") ?? new List<Invoice>();
        }

        public async Task<Invoice> GetInvoiceAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Invoice>($"api/invoices/{id}") ?? new Invoice();
        }

        public async Task CreateInvoiceAsync(Invoice invoice)
        {
            await _httpClient.PostAsJsonAsync("api/invoices", invoice);
        }

        public async Task UpdateInvoiceAsync(Invoice invoice)
        {
            await _httpClient.PutAsJsonAsync($"api/invoices/{invoice.InvoiceId}", invoice);
        }

        public async Task DeleteInvoiceAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/invoices/{id}");
        }
    }
}