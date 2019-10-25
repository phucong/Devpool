using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessResult.Core.Models
{
    public class TournamentFederation : Tournament
    {
        public string FederationCode { get; set; }
    }
}
