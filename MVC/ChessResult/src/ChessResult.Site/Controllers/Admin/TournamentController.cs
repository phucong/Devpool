using ChessResult.Site.ViewModels.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fanex.Data;
using ChessResult.Core.Services;

namespace ChessResult.Site.Controllers.Admin
{

    public class TournamentController : Controller
    {
        private readonly ITournamentService tournamentService;

        public TournamentController(ITournamentService tournamentService)
        {
            this.tournamentService = tournamentService;

        }

        // GET: Tournament
        public ActionResult Index()
        {

            var tournaments = tournamentService.GetTournaments();

            TournamentsViewModel tournamentsViewModel = new TournamentsViewModel(tournaments);

            return View("~/Views/Admin/Tournament/Index.cshtml", tournamentsViewModel);
        }

        // GET: Tournament/Details/5
        public ActionResult Details(int id)
        {
            var tournament = tournamentService.GetTournamentById(id);

            TournamentDetailViewModel tournamentDetailViewModel = new TournamentDetailViewModel(tournament);

            return View("~/Views/Admin/Tournament/View.cshtml", tournamentDetailViewModel);
        }

        // GET: Tournament/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tournament/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tournament/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tournament/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tournament/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tournament/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
