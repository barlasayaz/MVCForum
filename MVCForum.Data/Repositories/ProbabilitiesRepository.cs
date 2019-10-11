using MVCForum.Data.Context;
using MVCForum.Domain;
using MVCForum.Domain.DomainModel.Entities;
using MVCForum.Domain.Interfaces;
using MVCForum.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCForum.Data.Repositories
{
    public partial class ProbabilitiesRepository : IProbabilitiesRepository
    {
        private readonly MVCForumContext _context;

        public ProbabilitiesRepository(IMVCForumContext context)
        {
            _context = context as MVCForumContext;
        }

        public Probabilities AllProbabilities(int leagueId, int seasonId, int teamId)
        {
            DbRawSqlQuery<Probabilities> data = _context.Database.SqlQuery<Probabilities>
                                 ("EXEC sp_GetProbabilities @leagueId, @seasonId, @teamId",
                                    new SqlParameter("@leagueId", leagueId),
                                     new SqlParameter("@seasonId", seasonId),
                                     new SqlParameter("@teamId", teamId));

            return data.First();
        }
    }
}
