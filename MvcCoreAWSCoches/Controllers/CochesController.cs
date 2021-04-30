using Microsoft.AspNetCore.Mvc;
using MvcCoreAWSCoches.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreAWSCoches.Controllers
{
    public class CochesController : Controller
    {
        RepositoryCoches repo;
        public CochesController(RepositoryCoches repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View(this.repo.GetCoches());
        }
    }
}
