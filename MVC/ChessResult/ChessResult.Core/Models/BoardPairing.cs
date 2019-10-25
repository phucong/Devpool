using System;
using System.Collections.Generic;
using System.Text;

namespace ChessResult.Core.Models
{
    class BoardPairing
    {
        public int Id { get; set; }
        public int TournamentSelectionId { get; set; }
        public string Name { get; set; }
        public int Player1 { get; set; }
        public int Player2 { get; set; }
    }
}
