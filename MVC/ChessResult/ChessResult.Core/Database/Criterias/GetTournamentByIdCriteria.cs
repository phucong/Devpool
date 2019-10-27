using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fanex.Data.Repository;

namespace ChessResult.Core.Database.Criterias
{
    class GetTournamentByIdCriteria : CriteriaBase
    {
        public GetTournamentByIdCriteria(int Id)
        {
            TournamentId = Id;
        }

        public int TournamentId { get; }

        public override string GetSettingKey() => "Tournament_GetById";

        public override bool IsValid() => true;
    }
}
