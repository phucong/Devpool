using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessResult.Core.Models
{
    public class TournamentDetail
    {
        public Tournament Tournament { get; set; }

        public IEnumerable<GroupSelection> GroupSelections { get; set; }

        public IEnumerable<TournamentSelection> TournamentSelections { get; set; }


    }
}
