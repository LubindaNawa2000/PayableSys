using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using AccountPay;
using AccountPay.Services;
using AccountPay.Shared;

namespace AccountPay.Services
{
    public class PaymentService
    {
        private readonly HttpClient _httpClient;

        public PaymentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Payment>> GetPaymentsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Payment>>("api/Payments") ?? new List<Payment>();
        }

        public async Task<Payment> GetPaymentAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Payment>($"api/Payments/{id}") ?? new Payment();
        }

        public async Task CreatePaymentAsync(Payment Payment)
        {
            await _httpClient.PostAsJsonAsync("api/Payments", Payment);
        }

        public async Task UpdatePaymentAsync(Payment Payment)
        {
            await _httpClient.PutAsJsonAsync($"api/Payments/{Payment.PaymentId}", Payment);
        }

        public async Task DeletePaymentAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/Payments/{id}");
        }
    }
}