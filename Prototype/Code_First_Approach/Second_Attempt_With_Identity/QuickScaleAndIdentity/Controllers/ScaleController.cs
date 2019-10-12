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

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Add() => View();
         
    }
}