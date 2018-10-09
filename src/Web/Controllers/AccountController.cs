using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IConfiguration _configuration;
        public AccountController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public async Task Login(string returnUrl = "/")
        {            
            await HttpContext.ChallengeAsync("GitHub", new AuthenticationProperties() { RedirectUri = returnUrl });
        }
    }
}