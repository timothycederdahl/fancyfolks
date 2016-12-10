using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FancyFolks.Models;

namespace FancyFolks.Controllers
{
    public class FancyFolksController : Controller
    {
        IRepository repo;
        // GET: FancyFolks

        public FancyFolksController()
        {
            repo = new FancyFolkRepository();
        }
        public ActionResult Index()
        {
            return View(repo.FancyFolks);
        }
    }
}