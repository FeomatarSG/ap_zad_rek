using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APawelec_Nexio_rekrutacja.Models;

namespace APawelec_Nexio_rekrutacja.Controllers
{
    public class HomeController : Controller
    {
        //private Person on;
        //private Person ona;

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult On()
        {
            return View();
        }

        [HttpPost]
        public ViewResult On(Person person)
        {
            if (ModelState.IsValid)
            {
                var he = new Person
                {
                    Imie = person.Imie,
                    Wzrost = person.Wzrost,
                    KoloOczu = person.KoloOczu,
                    Wiek = person.Wiek
                };

                Session["on"] = he;
                return View(person);
            }
            else
                return View();
        }

        [HttpGet]
        public ViewResult Ona()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Ona(Person person)
        {
            if (ModelState.IsValid)
            {
                var she = new Person
                {
                    Imie = person.Imie,
                    Wzrost = person.Wzrost,
                    KoloOczu = person.KoloOczu,
                    Wiek = person.Wiek
                };

                Session["ona"] = she;
                return View(person);
            }
            else
                return View();
        }

        [HttpGet]
        public ViewResult Wynik(Person on, Person ona)
        {
            Person p1 = null;
            if(Session["ona"]!=null)
            {
                p1 = Session["ona"] as Person;
                ViewBag.Info = "Imie ona: " + Session["ona"].ToString();// + " |Imie ona:" + Session["ona"].ToString();
            }
            return View();
        }
    }
}