using System;
using System.Collections.Generic;
using System.Text;

namespace ChessResult.Core.Models
{
    public class TournamentSelection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupSelectionId { get; set; }
        public int TournamentId { get; set; }
    }
}
