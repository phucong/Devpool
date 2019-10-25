using System;
using System.Collections.Generic;
using System.Text;

namespace ChessResult.Core.Models
{
    class BoardingPairingPlayer
    {
        public int BoardingId { get; set; }
        public int PlayerId { get; set; }
        public int Pts { get; set; }
    }
}
