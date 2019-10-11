using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCForum.Domain.DomainModel.Entities
{
    public partial class Season : Entity
    {
        public int SeasonId { get; set; }
        public string SeasonName { get; set; }
    }
}
