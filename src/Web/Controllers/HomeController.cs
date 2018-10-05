using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Octokit;
using Octokit.Internal;
using Web.Models;
using Web.ViewModel;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ////var profile = OnGet();
            string gitHubName = User.FindFirst(c => c.Type == ClaimTypes.Name)?.Value;
            string gitHubLogin = User.FindFirst(c => c.Type == "urn:github:login")?.Value;
            string gitHubUrl = User.FindFirst(c => c.Type == "urn:github:url")?.Value;
            string githubAvater = User.FindFirst(c => c.Type == "urn:github:avatar")?.Value;
            //string accessToken = "";
            return View();
        }
    }
}