using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using InfluencerAPI.Models.OrdersDTO;
using InfluencerApp.Model.Order;
using InfluencerApp.Services;

namespace InfluencerApp.Pages;

public partial class Order
{

    [Inject]
    public HttpClient HttpClient { get; set; } = default!;

    [Inject]
    public IJSRuntime JsRuntime { get; set; } = default!;

    private List<Product>? _products;
    private IEnumerable<Product[]>? _productChunksOf4;

    //protected override async Task OnInitializedAsync()
    //{
    //    _products = await HttpClient.GetFromJsonAsync<List<Product>>($"{APIs._baseUrl}/products");
    //    //_products = await HttpClient.GetFromJsonAsync<List<Product>>($"{APIs._baseUrl}/products");

    //    if (_products is not null)
    //    {
    //        _productChunksOf4 = _products.Chunk(4);
    //    }
    //}

    private async Task OnClickBtnBuyNowAsync(List<Product> product)
    {
        var response = await HttpClient.PostAsJsonAsync($"{APIs._baseUrl}/checkout", product);

        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        var checkoutOrderResponse = JsonConvert.DeserializeObject<CheckoutOrderResponse>(responseBody);

        // Opens up Stripe.
        await JsRuntime.InvokeVoidAsync("checkout", checkoutOrderResponse.PubKey, checkoutOrderResponse.SessionId);
    }
}
