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
        private IScaleRepository repository;
        public ScaleController(IScaleRepository repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Scales);
    }
}