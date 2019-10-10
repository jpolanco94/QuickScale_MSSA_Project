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
        [HttpGet]
        public ViewResult Add() => View();
        [HttpPost]
        public ViewResult Add(Scale scale)
        {
            try 
            {
                _context.Scales.Add(scale);
                _context.SaveChanges();
                System.Threading.Thread.Sleep(15000);
                return View("Index");
            }
            catch(Exception)
            {
                System.Threading.Thread.Sleep(15000);
                return View("Index");
            }
        }
        public ViewResult SaveFretboard() => View();
        [HttpPost]
        public ViewResult SaveFretboard(SavedFretBoard savedFretBoard, Scale scale, User user)
        {
            //savedFretBoard.User.ID = user.ID;
            savedFretBoard.Scale.ScaleId = scale.ScaleId;
            try
            {
                _context.SavedFretBoards.Add(savedFretBoard);
                _context.SaveChanges();
                System.Threading.Thread.Sleep(15000);
                return View("Index");
            }
            catch(Exception)
            {
                System.Threading.Thread.Sleep(15000);
                return View("Index");
            }
        }
         
    }
}