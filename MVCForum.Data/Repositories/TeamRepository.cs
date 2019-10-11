using MVCForum.Data.Context;
using MVCForum.Domain.DomainModel.Entities;
using MVCForum.Domain.Interfaces;
using MVCForum.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCForum.Data.Repositories
{
    public partial class TeamRepository : ITeamRepository
    {
        private readonly MVCForumContext _context;

        public TeamRepository(IMVCForumContext context)
        {
            _context = context as MVCForumContext;
        }

        public List<Team> AllTeams()
        {
            return _context.Team.ToList();
        }
    }
}
