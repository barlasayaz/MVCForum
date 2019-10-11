using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCForum.Domain.DomainModel.Entities
{
    public partial class Team : Entity 
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
    }
}
