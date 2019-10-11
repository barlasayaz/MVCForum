using MVCForum.Domain;
using MVCForum.Domain.Interfaces.Repositories;
using MVCForum.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCForum.Services
{
    public partial class ProbabilitiesService : IProbabilitiesService
    {
        private readonly IProbabilitiesRepository _probabilitiesRepository;

        public ProbabilitiesService(IProbabilitiesRepository leagueRepository)
        {
            _probabilitiesRepository = leagueRepository;
        }

        public Probabilities AllProbabilities(int leagueId, int seasonId, int teamId)
        {
            return _probabilitiesRepository.AllProbabilities(leagueId,seasonId, teamId);
        }
    }
}
