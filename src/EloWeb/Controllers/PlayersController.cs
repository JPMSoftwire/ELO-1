﻿using System.Linq;
using System.Web.Mvc;
using EloWeb.Models;
using EloWeb.Repositories;

namespace EloWeb.Controllers
{
    public class PlayersController : Controller
    {
        // GET: Players
        public ActionResult Index()
        {
            var players = RatingsRepo.Players().Values;
            ViewData.Model = players.OrderBy(p => p.Name);

            return View();
        }


        // GET: Players/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Players/Create
        [HttpPost]
        public ActionResult Create(Player player)
        {
            RatingsRepo.AddPlayer(player.Name);
            return Redirect("/Players");
        }
    }
}