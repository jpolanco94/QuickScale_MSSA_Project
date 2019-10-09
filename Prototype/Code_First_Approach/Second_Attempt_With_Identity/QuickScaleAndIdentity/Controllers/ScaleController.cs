using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickScaleAndIdentity.Models;
using Microsoft.AspNetCore.Authorization;

namespace QuickScaleAndIdentity.Controllers
{
    public class ScaleController : Controller
    {
        private QuickScaleDbContext _context;
        private IScaleRepository repository;

        public ScaleController(IScaleRepository repo, QuickScaleDbContext context)
        {
            repository = repo;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult Add() => View();
        [HttpPost]
        public ViewResult Add(Scale scale)
        {
            try 
            {
                _context.Scales.Add(scale);
                _context.SaveChanges();
                return View();
            }
            catch(Exception)
            {
                return View();
            }
        }
    }
}