//using System;
//using Microsoft.JSInterop;
//using System.Threading.Tasks;

//public class AuthenticationService
//{
//    private readonly IJSRuntime jsRuntime;
//    public event Action OnAuthStateChanged;

//    public AuthenticationService(IJSRuntime jsRuntime)
//    {
//        this.jsRuntime = jsRuntime;
//    }

//    public async Task<bool> IsUserLoggedInAsync()
//    {
//        var token = await jsRuntime.InvokeAsync<string>("localStorage.getItem", "jwtToken");
//        return !string.IsNullOrEmpty(token);
//    }

//    public async Task LoginAsync(string token)
//    {
//        await jsRuntime.InvokeVoidAsync("localStorage.setItem", "jwtToken", token);
//        NotifyAuthStateChanged();
//    }

//    public async Task LogoutAsync()
//    {
//        await jsRuntime.InvokeVoidAsync("localStorage.removeItem", "jwtToken");
//    }
//}
//}

