using System.Text.Json;
using BlazorDex.Models;
using System.Text;
using Microsoft.JSInterop;



namespace BlazorDex.Util
{

public class HeroStateService
{
    public Hero? Hero { get; private set; }
    public event Action? OnChange;

    private readonly IJSRuntime _jsRuntime;

    public HeroStateService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
        LoadHeroFromLocalStorage();
    }

    public async void SetHero(Hero hero)
    {
        Hero = hero;
        NotifyStateChanged();
        await SaveHeroToLocalStorage(hero);
    }

    private async Task SaveHeroToLocalStorage(Hero hero)
    {
        var heroJson = JsonSerializer.Serialize(hero);
        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "hero", heroJson);
    }

    private async void LoadHeroFromLocalStorage()
    {
        var heroJson = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "hero");
        if (!string.IsNullOrEmpty(heroJson))
        {
            Hero = JsonSerializer.Deserialize<Hero>(heroJson);
            NotifyStateChanged();
        }
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}

    public class HeroClient
    {
        public HttpClient Client { get; set; }

        public HeroClient(HttpClient client)
        {
            this.Client = client;
        }

  public async Task UpdateHero(Hero hero)
{
    var heroJson = JsonSerializer.Serialize(hero);
    var content = new StringContent(heroJson, Encoding.UTF8, "application/json");

    var response = await this.Client.PutAsync($"https://backend.momotech.al/api/heroes/{hero.Id}", content);
    // var response = await this.Client.PutAsync($"https://kreshnik-api.onrender.com/api/heroes/{hero.Id}", content);


    if (!response.IsSuccessStatusCode)
    {
        throw new Exception($"Failed to update hero. Status code: {response.StatusCode}");
    }
}

 public async Task DeleteAccount(int userId)
    {
        var response = await this.Client.DeleteAsync($"https://backend.momotech.al/api/heroes/{userId}");
        // var response = await this.Client.DeleteAsync($"https://kreshnik-api.onrender.com/api/users/{userId}");

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Failed to delete account. Status code: {response.StatusCode}");
        }
    }


    }
}
