using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
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
        #region constructor

        private readonly IAsyncRepository<Repositories> _repoRepository;
        private readonly IAsyncRepository<Owner> _ownerRepository;
        protected IReadOnlyList<Repository> Repositories;
        protected User user;
        public HomeController(IAsyncRepository<Repositories> asyncRepository,
            IAsyncRepository<Owner> ownerRepository
            )
        {
            this._repoRepository = asyncRepository;
            this._ownerRepository = ownerRepository;
        }
        #endregion
        #region Public Action

        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
               string accessToken = await HttpContext.GetTokenAsync("access_token");
               var github = new GitHubClient(new ProductHeaderValue("GitTopperApp"));
               github.Credentials = new Credentials(accessToken);
               user = await github.User.Current();
                if(user != null) { 
                await InsertOrUpdateUser(user);
                }
                Repositories = await github.Repository.GetAllForCurrent();
                if(Repositories != null) { 
                foreach(var item in Repositories) {
                        var repo = _repoRepository.GetByIdAsync(item.Id);
                        if(repo != null && repo.Id == item.Id)
                        {
                           await _repoRepository.UpdateAsync(MapRepo(item));
                        }
                        else { 
                            await _repoRepository.AddAsync(MapRepo(item));
                        }
                    }
                }

            }
            return View();
        }
#endregion 
#region private area 
        private Repositories MapRepo(Repository item)
        {
            Repositories repos = new Repositories()
            {
                Id = item.Id,
                NodeId = item.NodeId,
                Name = item.Name,
                FullName = item.FullName,
                IsPrivate = item.Private,
                OwnerId = item.Owner.Id,
                HtmlUrl = item.HtmlUrl,
                Description = item.Description,
                CreatedAt = item.CreatedAt,
                UpdatedAt = item.UpdatedAt,
                GitUrl = item.GitUrl,
                StargazersCount = item.StargazersCount,
                Language = item.Language,
                ForksCount = item.ForksCount,
                OpenIssuesCount = item.OpenIssuesCount,
                LicenseName = item.License.Name,
                DefaultBranch = item.DefaultBranch
            };
            return repos;
        }

        private async Task InsertOrUpdateUser(User user)
        {
            var getUser = await _ownerRepository.GetByIdAsync(user.Id);
            if (getUser != null && user.Id == getUser.Id)
            {
               await _ownerRepository.UpdateAsync(MapUserToOwner(user));
            }
            else
            {
               await _ownerRepository.AddAsync(MapUserToOwner(user));
            }
            
        }

        private Owner MapUserToOwner(User user)
        {
            var owner = new Owner()
            {
                Id = user.Id,
                Login = user.Login,
                NodeId = user.NodeId,
                AvatarUrl = user.AvatarUrl,
                Name = user.Name,
                HtmlUrl = user.HtmlUrl,
                Bio = user.Bio,
                Company = user.Company,
                Blog = user.Blog,
                Location = user.Location,
                Email = user.Email,
                PublicRepos = user.PublicRepos,
                Hireable = user.Hireable,
                Followers = user.Followers,
                Following = user.Following,
                PublicGists = user.PublicGists,
                Collaborators = user.Collaborators
            };

            return owner;
}

#endregion private area
    }
}