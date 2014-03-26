using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Protocols;
using Isel.ChelasNote;

namespace SampleMvcApplication.Controllers
{
    public class NotesController : Controller
    {
        //
        // GET: /Notes/
        NotesRespository repo = new NotesRespository();

        public ActionResult Index()
        {
            

            return View(repo.GetAll());
        }

        public ActionResult Details(int id)
        {
            return View(repo.Get(id));
        }

    }
}
