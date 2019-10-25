using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChessResult.Core.Models;

namespace ChessResult.Site.ViewModels.Admin
{
    public class TournamentsViewModel
    {
        public TournamentsViewModel(IEnumerable<TournamentFederation> tournaments)
        {
            Tournaments = tournaments.ToList();
        }
        public List<TournamentFederation> Tournaments { get; }
    }
}