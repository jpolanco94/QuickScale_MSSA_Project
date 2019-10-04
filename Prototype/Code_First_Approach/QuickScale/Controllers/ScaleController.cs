using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using QuickScale.Models;
using Microsoft.AspNetCore.Authorization;


namespace QuickScale.Controllers
{
    public class ScaleController : Controller
    {
        private QuickScaleDBContext _context;
        private IScaleRepository repository;
        public ScaleController(IScaleRepository repo, QuickScaleDBContext context)
        {
            repository = repo;
            _context = context;
        }
        [Authorize]
        public ViewResult List() => View(repository.Scales);
        [HttpGet]
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