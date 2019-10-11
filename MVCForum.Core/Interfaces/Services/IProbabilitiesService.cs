using MVCForum.Domain.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCForum.Domain.Interfaces.Services
{
    public partial interface IProbabilitiesService
    {
        Probabilities AllProbabilities(int leagueId,int seasonId,int teamId);
    }
}
