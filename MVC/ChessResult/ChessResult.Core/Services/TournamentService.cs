using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessResult.Core.Database.Criterias;
using ChessResult.Core.Models;
using Fanex.Data.Repository;

namespace ChessResult.Core.Services
{
    public interface ITournamentService
    {
        IEnumerable<TournamentFederation> GetTournaments();

        TournamentDetail GetTournamentById(int id);
    }
    public class TournamentService : ITournamentService
    {
        private readonly IDynamicRepository dynamicRepository;

        public TournamentService(IDynamicRepository dynamicRepository)
        {
            this.dynamicRepository = dynamicRepository;
        }

        public IEnumerable<TournamentFederation> GetTournaments()
        {
            var tournaments = dynamicRepository.Fetch<TournamentFederation>(new GetTournamentsCriteria());

            return tournaments;
        }

        public TournamentDetail GetTournamentById(int Id)
        {
            var criteria = new GetTournamentByIdCriteria(Id);

            TournamentDetail tournamentdetail = new TournamentDetail();
            var result = dynamicRepository.FetchMultiple<Tournament, GroupSelection, TournamentSelection>(criteria);
            tournamentdetail.Tournament = result.Item1.Cast<Tournament>().First();
            tournamentdetail.GroupSelections = result.Item2;
            tournamentdetail.TournamentSelections = result.Item3;

            return tournamentdetail;
        }
    }
}
