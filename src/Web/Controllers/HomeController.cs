using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Octokit;
using Octokit.Internal;
using Web.Models;
using Web.ViewModel;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public IReadOnlyList<Repository> Repositories { get; set; }
        public async Task<IActionResult> Index()
        {

            if (User.Identity.IsAuthenticated)
            {
               string gitHubLogin = User.FindFirst(c => c.Type == "urn:github:login")?.Value;
               string accessToken = await HttpContext.GetTokenAsync("access_token");
                var github = new GitHubClient(new ProductHeaderValue("GitTopperApp"));
                github.Credentials = new Credentials(accessToken);
                var user = await github.User.Current();
                Repositories = await github.Repository.GetAllForCurrent();
                foreach(var iteam in Repositories)
                {
                  string userUei =  iteam.Owner.HtmlUrl;
                    
                }

            }
            return View();
        }
    }
}