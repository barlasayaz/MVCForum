using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCForum.Domain.DomainModel.Entities
{
    public partial class League : Entity
    {
        public int LeagueId { get; set; }
        public string LeagueName { get; set; }
    }
}
