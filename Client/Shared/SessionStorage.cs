using Microsoft.JSInterop;

namespace LANMessenger.Client.Shared
{
    public class SessionStorage : IDisposable
    {
        private readonly IJSRuntime js;
        public SessionStorage(IJSRuntime js)
        {
            this.js = js;
        }

        public async ValueTask<string> GetItem(string key)
        {
            return await js.InvokeAsync<string>("sessionStorage.getItem", key);
        }

        public async ValueTask SetItem(string key, string value)
        {
            await js.InvokeVoidAsync("sessionStorage.setItem", key, value);
        }

        public async ValueTask RemoveItem(string key)
        {
            await js.InvokeVoidAsync("sessionStorage.removeItem", key);
        }

        public async ValueTask RemoveItem(string key, string value)
        {
            await js.InvokeVoidAsync("sessionStorage.clear");
        }

        public void Dispose()
        {
        }
    }
}
