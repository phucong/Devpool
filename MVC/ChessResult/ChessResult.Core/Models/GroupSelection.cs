using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessResult.Core.Models
{
    public class GroupSelection
    {
        [DisplayName("Group Selection ID")]
        public int Id { get; set; }

        [DisplayName("Group Selection Name")]
        public string Name { get; set; }
    }
}
