using MVCForum.Domain.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCForum.Data.Mapping
{
    public class LeagueMapping : EntityTypeConfiguration<League>
    {
        public LeagueMapping()
        {
            HasKey(x => x.LeagueId);
            Property(x => x.LeagueId).IsRequired();
            Property(x => x.LeagueName).IsRequired().HasMaxLength(50);
        }
    }
}
