﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TennisOrganizer.MVC.Models;

namespace TennisOrganizer.MVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
		public ViewResult Register()
		{
			return View();
		}
		public ViewResult RegisterSuccess()
		{

			ViewData.Add("RegisteredLogin", (String)TempData["RegisteredLogin"]);
			return View();
		}
		[HttpPost]
		public ActionResult Index(Account acc)
		{
			using (var db =  new TennisOrganizerContext())
			{
				var query = db.Accounts.FirstOrDefault<Account>(a => a.Login == acc.Login);
				if (query == null)
				{
					ViewData.Add("LoginNotFound", (bool)true);
					return View(acc);
				}
				else if (query.Password != acc.Password)
				{
					ViewData.Add("PasswordIncorrect", (bool)true);
					return View(acc);
				}
				else return RedirectToAction("MainTest", "Main");
			}
		}


		[HttpPost]
		public ActionResult Register(RegistrationViewModel rvm)
		{
			if (ModelState.IsValid)
			{
				using(var db = new TennisOrganizerContext())
				{
					if (!Account.CheckAvailability(rvm.Login))
					{
						ViewData.Add("LoginAvailability", (bool)false);
						return View(rvm);
					}
					else
					{
						Account acc = new Account { Login = rvm.Login, Password = rvm.Password };
						Player p = rvm.Player;
						acc.Player = p;
						db.Accounts.Add(acc);
						db.Players.Add(p);
						db.SaveChanges();

						TempData.Add("RegisteredLogin", rvm.Login);
						return RedirectToAction("RegisterSuccess");
					}
				}
			}
			else
			{
				return View(rvm);
			}
		}
    }
}
