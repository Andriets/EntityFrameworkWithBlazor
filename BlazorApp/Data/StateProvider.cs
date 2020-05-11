using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class StateProvider : AuthenticationStateProvider
    {
        private ISessionStorageService _sessionStorageService;
        public StateProvider(ISessionStorageService sessionStorageService)
        {
            _sessionStorageService = sessionStorageService;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var emailAddress = await _sessionStorageService.GetItemAsync<string>("emailAddress");
            ClaimsIdentity identity;
            if (emailAddress != null)
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, emailAddress),
                }, "apiauth_type");
            }
            else
            {
                identity = new ClaimsIdentity();
            }


            var user = new ClaimsPrincipal(identity);

            /*var identity = new ClaimsIdentity();

            var user = new ClaimsPrincipal(identity);*/

            return await Task.FromResult(new AuthenticationState(user));
        }

        public void MarkUserAsAuthenticated(string email)
        {
            var identity = new ClaimsIdentity(new[]
            {
               new Claim(ClaimTypes.Name, email),
            }, "apiauth_type");
            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public void MarkUserAsLoggedOut()
        {
            _sessionStorageService.RemoveItemAsync("emailAddress");

            var identity = new ClaimsIdentity();

            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
}
