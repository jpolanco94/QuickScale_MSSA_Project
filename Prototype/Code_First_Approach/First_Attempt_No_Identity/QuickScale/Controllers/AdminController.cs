using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickScale.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace QuickScale.Controllers
{
    //[Authorize]
    public class AdminController : Controller
    {
        private QuickScaleDBContext _context;
        private IUserRepository repository;
        public AdminController(IUserRepository repo, UserManager<AppUser> usrMgr, QuickScaleDBContext ctx)
        {
            _context = ctx;
            userManager = usrMgr;
            repository = repo;
        }
        //Chapter 12 
        [Authorize]
        public ViewResult ListAccounts() => View(repository.Users);

        [HttpPost]
        [Authorize]
        public IActionResult Delete(int userID)
        {
            User deletedUser = repository.DeleteUser(userID);
            if(deletedUser != null)
            {
                TempData["message"] = $"{deletedUser.Username} was deleted";
            }
            return RedirectToAction("ListAccounts");
        }
        //Chapter 28
        private UserManager<AppUser> userManager;
        public ViewResult Index() => View(userManager.Users);

        public ViewResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(CreateModel model, User userDB)
        {
            userDB.Username = model.Name;
            userDB.Password = model.Password;
            try
            {
                _context.Users.Add(userDB);
                _context.SaveChanges();
                if (ModelState.IsValid)
                {
                    AppUser user = new AppUser
                    {
                        UserName = model.Name,
                        Email = model.Email
                    };
                    IdentityResult result = await userManager.CreateAsync(user, model.Password);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        foreach (IdentityError error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
                return View(model);
            }
            catch(Exception)
            {
                //Do Something
                return View();
            }
        }
    }
}