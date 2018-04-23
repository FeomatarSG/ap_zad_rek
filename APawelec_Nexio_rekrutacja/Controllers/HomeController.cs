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
        public ActionResult On(Person person)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var he = new Person
                    {
                        Imie = person.Imie,
                        Wzrost = person.Wzrost,
                        KolorOczu = person.KolorOczu,
                        DataUrodzenia = person.DataUrodzenia
                    };

                    Session["on"] = he;
                    return Redirect("Ona");
                }
            }
            catch(Exception ex)
            { 
                ModelState.AddModelError("error", ex.Message);
                return View();
            }
            return View();
        }

        [HttpGet]
        public ViewResult Ona()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ona(Person person)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var she = new Person
                    {
                        Imie = person.Imie,
                        Wzrost = person.Wzrost,
                        KolorOczu = person.KolorOczu,
                        DataUrodzenia = person.DataUrodzenia
                    };
                    Session["ona"] = she;

                    return Redirect("Wynik");
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("error", ex.Message);
                return View();
            }
            return View();
        }

        public ActionResult Wynik()
        {
            Person man, woman;
            man = Session["on"] as Person;
            woman = Session["ona"] as Person;

            if (man == null)
                Redirect("On");
            else
            { 
                if(man.Compare(woman))
                    ViewBag.Result = man.Imie + " pasuje do " + woman.Imie;
                else
                    ViewBag.Result = man.Imie + " nie pasuja do " + woman.Imie;
                return View();
            }
            return View();
        }
    }
}