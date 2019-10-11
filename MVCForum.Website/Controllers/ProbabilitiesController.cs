using MVCForum.Domain.Interfaces.Services;
using MVCForum.Domain.Interfaces.UnitOfWork;
using MVCForum.Website.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace MVCForum.Website.Controllers
{
    public class ProbabilitiesController : BaseController
    {
        private readonly ITeamService _teamService;
        private readonly ILeagueService _leagueService;
        private readonly ISeasonService _seasonService;
        private readonly IProbabilitiesService _probabilitiesService;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="unitOfWorkManager"> </param>
        /// <param name="membershipService"></param>
        /// <param name="localizationService"></param>
        /// <param name="roleService"></param>
        /// <param name="settingsService"> </param>
        /// <param name="loggingService"> </param>
        public ProbabilitiesController(ILoggingService loggingService, IUnitOfWorkManager unitOfWorkManager, IMembershipService membershipService, ILocalizationService localizationService,
            IRoleService roleService, ISettingsService settingsService,
            ITeamService teamService, ILeagueService leagueService, ISeasonService seasonService, IProbabilitiesService probabilitiesService)
            : base(loggingService, unitOfWorkManager, membershipService, localizationService, roleService, settingsService)
        {
            _teamService = teamService;
            _leagueService = leagueService;
            _seasonService = seasonService;
            _probabilitiesService = probabilitiesService;
        }

        public ActionResult GetProbabilities()
        {
            ViewBag.Teams = _teamService.AllTeams();
            ViewBag.Leagues = _leagueService.AllLeagues();
            ViewBag.Seasons = _seasonService.AllSeasons();
            return View();
        }

        public PartialViewResult SearchResult(int leagueId, int seasonId, int teamId)
        {
           return PartialView("_SearchResult", _probabilitiesService.AllProbabilities(leagueId,seasonId,teamId));
        }
    }
}
