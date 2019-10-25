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
        public int TournamentId { get; set; }

        public override string GetSettingKey() => "Tournament_GetById";

        public override bool IsValid() => true;
    }
}
