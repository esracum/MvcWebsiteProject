﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        GenericRepositoriy<Tbliletisim> repo = new GenericRepositoriy<Tbliletisim>();
        public ActionResult Index()
        {
            var mesajlar = repo.List();
            return View(mesajlar);
        }
    }
}