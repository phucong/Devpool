using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using ChessResult.Core.Models;

namespace ChessResult.Site.ViewModels.Admin
{
    public class TournamentDetailViewModel
    {
        public TournamentDetailViewModel(TournamentDetail tournament)
        {
            Tournament = tournament.Tournament;
            GroupSelections = tournament.GroupSelections;
            TournamentSelections = tournament.TournamentSelections;
        }

        public Tournament Tournament { get; }

        [DisplayName("Group Selection")]
        public IEnumerable<GroupSelection> GroupSelections { get; }

        [DisplayName("Tournament Selection")]
        public IEnumerable<TournamentSelection> TournamentSelections { get; }
    }
}