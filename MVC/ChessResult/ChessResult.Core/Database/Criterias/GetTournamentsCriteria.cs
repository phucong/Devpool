using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fanex.Data;
using Fanex.Data.Repository;

namespace ChessResult.Core.Database.Criterias
{
    class GetTournamentsCriteria : CriteriaBase
    {
        public override string GetSettingKey() => "Tournament_GetAll";

        public override bool IsValid() => true;
    }
}
