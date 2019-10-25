using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ChessResult.Core.Models
{
    public class Tournament
    {
        [DisplayName("Tournament ID")]
        public int Id { get; set; }

        [DisplayName("Tournament Name")]
        public string Name { get; set; }

        [DisplayName("Organize")]
        public string Organize { get; set; }

        [DisplayName("Tournament Director")]
        public string TournamentDirector { get; set; }

        [DisplayName("Location")]
        public string Location { get; set; }

        [DisplayName("LastUpdate")]
        public DateTimeOffset LastUpdate { get; set; }       
    }
}
