using Blazored.LocalStorage;

namespace AppBuilder.Services;

public sealed class ThemeService(ILocalStorageService storage)
{
    private const string Key = "app.theme.isDark";

    public bool IsDark { get; private set; }

    public event Action? Changed;

    public async Task InitializeAsync()
    {
        IsDark = await storage.GetItemAsync<bool>(Key);
        Changed?.Invoke();
    }

    public async Task SetDarkAsync(bool value)
    {
        IsDark = value;
        await storage.SetItemAsync(Key, value);
        Changed?.Invoke();
    }

    public async Task ToggleAsync()
        => await SetDarkAsync(!IsDark);
}