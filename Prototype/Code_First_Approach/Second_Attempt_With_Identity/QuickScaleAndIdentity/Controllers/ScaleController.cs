using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickScaleAndIdentity.Models;
using Microsoft.AspNetCore.Authorization;
using System.Threading;
using Microsoft.AspNetCore.Identity;
using System.Security.Principal;
using System.Security.Claims;

namespace QuickScaleAndIdentity.Controllers
{
    public class ScaleController : Controller
    {
        private AppIdentityDbContext _context;
        private ISavedFretBoardRepository repository;
        private UserManager<AppUser> userManager;

        public ScaleController(AppIdentityDbContext ctx, ISavedFretBoardRepository repo,
            UserManager<AppUser> userMgr)
        {
            _context = ctx;
            repository = repo;
            userManager = userMgr;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult SaveScale() => View();

        [HttpPost]
        public ViewResult SaveScale(SavedFretBoard fretboard)
        {
            try
            {
                fretboard.Id = userManager.GetUserId(User);
                fretboard.Username = User.Identity.Name;
                _context.SavedFretBoards.Add(fretboard);
                _context.SaveChanges();
                SavedFretBoardViewModel.AddSettings(fretboard);
                Thread.Sleep(15000);
                return View();
            }
            catch(Exception)
            {
                Thread.Sleep(15000);
                return View();
            }
        }

    }
}