using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickScale.Models;
using Microsoft.AspNetCore.Authorization;

namespace QuickScale.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IUserRepository repository;
        public AdminController(IUserRepository repo)
        {
            repository = repo;
        }
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
    }
}