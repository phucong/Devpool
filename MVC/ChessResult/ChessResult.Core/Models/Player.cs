using System;
using System.Collections.Generic;
using System.Text;

namespace ChessResult.Core.Models
{
    class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public int FederationId { get; set; }
    }
}
