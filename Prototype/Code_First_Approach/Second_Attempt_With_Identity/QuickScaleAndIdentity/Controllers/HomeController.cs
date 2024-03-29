﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using QuickScaleAndIdentity.Models;

namespace QuickScaleAndIdentity.Controllers
{
    public class HomeController : Controller
    {
        private ISavedFretBoardRepository repository;
        private AppIdentityDbContext context;
        public HomeController(ISavedFretBoardRepository repo, AppIdentityDbContext ctx)
        {
            repository = repo;
            context = ctx;
        }
        public ViewResult Index()
        {
            int? results = repository.SavedFretBoards.Where(name => String.Equals(name.Username.ToLower(), User.Identity.Name.ToLower())).Count();
            if (results == 0)
            {
                return View("Other");
            }
            else
            {
                return View(repository.SavedFretBoards.Where(
                    r => r.Username.ToLower() == User.Identity.Name.ToLower()));
            }
        }

        [HttpPost]
        public ViewResult DeleteScale(SavedFretBoard fretboard)
        {
            try 
            {
                context.SavedFretBoards.Remove(fretboard);
                context.SaveChanges();
                return View();
            }
            catch (Exception)
            {
                return View();
            }
        }
        //public IActionResult Index() => View(GetData(nameof(Index)));

        public IActionResult HomePage() => View();        
        public IActionResult OtherAction() => View("Index", GetData(nameof(OtherAction)));

        private Dictionary<string, object> GetData(string actionName) =>new Dictionary<string, object>
        {
            ["Action"] = actionName,
            ["User"] = HttpContext.User.Identity.Name,
            ["Authenticated"] = HttpContext.User.Identity.IsAuthenticated,
            ["Auth Type"] = HttpContext.User.Identity.AuthenticationType,
            ["In Users Role"] = HttpContext.User.IsInRole("Users")
        };
    }
}