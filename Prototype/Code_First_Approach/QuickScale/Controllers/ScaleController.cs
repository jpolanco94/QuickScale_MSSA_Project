using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickScale.Models;

namespace QuickScale.Controllers
{
    public class ScaleController : Controller
    {
        private QuickScaleDBContext _context;
        //public ScaleController(QuickScaleDBContext context)
        //{
        //    _context = context;
        //}
        private IScaleRepository repository;
        public ScaleController(IScaleRepository repo, QuickScaleDBContext context)
        {
            repository = repo;
            _context = context;
        }
        public ViewResult List() => View(repository.Scales);
        [HttpGet]
        public ViewResult Add() => View();
        [HttpPost]
        public ViewResult Add(Scale scale)
        {
            _context.Scales.Add(scale);
            _context.SaveChanges();
            return View();
        }
    }
}