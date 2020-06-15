﻿using ProjectNoctis.Domain.Repository.Interfaces;
using ProjectNoctis.Services.Interfaces;
using ProjectNoctis.Services.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProjectNoctis.Services.Concrete
{
    public class AbilityService : IAbilityService
    {
        private readonly IAbilityRepository abilityRepository;
        private readonly IStatusRepository statusRepository;

        public AbilityService(IAbilityRepository abilityRepository, IStatusRepository statusRepository)
        {
            this.abilityRepository = abilityRepository;
            this.statusRepository = statusRepository;
        }

        public Ability BuildAbilityInfo(string name, bool heroAbility)
        {
            var statusRegex = new Regex(Constants.Constants.statusRegex);
            var ability = new Ability();

            var abilityMatch = heroAbility ? abilityRepository.GetHeroAbilityByCharacterName(name) : abilityRepository.GetAbilityByName(name);

            if(abilityMatch == null)
            {
                return null;
            }
            ability.Info = abilityMatch;
            var statuses = statusRegex.Matches(abilityMatch.Effects).Select(x => x?.Groups[1]?.Value).ToList();
            ability.AbilityStatuses = statusRepository.GetStatusByNamesAndSource(ability.Info.Name, statuses, 0);

            return ability;
        }

        public List<Ability> BuildAbilityBySchoolInfo(string school, string rank, string element = null)
        {
            var abilities = abilityRepository.GetAbilitiesBySchoolRank(school, rank, element)
                .Select(x => new Ability() { Info = x})
                .ToList();

            return abilities;
        }
    }
}
