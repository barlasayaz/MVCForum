using MVCForum.Domain.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCForum.Data.Mapping
{
    public class TeamMapping : EntityTypeConfiguration<Team>
    {
        public TeamMapping()
        {
            HasKey(x => x.TeamId);
            Property(x => x.TeamId).IsRequired();
            Property(x => x.TeamName).IsRequired().HasMaxLength(50);
        }
    }
}
