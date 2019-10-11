using MVCForum.Domain.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCForum.Data.Mapping
{
    public class SeasonMapping : EntityTypeConfiguration<Season>
    {
        public SeasonMapping()
        {
            HasKey(x => x.SeasonId);
            Property(x => x.SeasonId).IsRequired();
            Property(x => x.SeasonName).IsRequired().HasMaxLength(50);
        }
    }
}
