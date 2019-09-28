using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickScale.Models;

namespace QuickScale.Controllers
{
    public class AccountController : Controller
    {
        private QuickScaleDBContext _context;
        private IUserRepository repository;
        public AccountController(QuickScaleDBContext context, IUserRepository repo)
        {
            repository = repo;
            _context = context;
        }
        public ViewResult ListAccounts() => View(repository.Users);
        [HttpGet]
        public ViewResult CreateAccount() => View();
        [HttpPost]
        public ViewResult CreateAccount(User users)
        {
            string password = users.Password;
            users.Password = Encryption.CreateMD5(password);
            _context.Users.Add(users);
            _context.SaveChanges();
            return View();
        }

    }
}