using AutoSystem_KingMe.Helper;
using AutoSystem_KingMe.Models;
using AutoSystem_KingMe.Models.Constants;
using AutoSystem_KingMe.Services.Game;
using KingMeServer;
using System.Reactive.Linq;
using System.Runtime.CompilerServices;

namespace AutoSystem_KingMe.Controller
{
    public class AutomationController
    {
        private readonly MatchGameService _matchGameService;

        public AutomationController(MatchGameService matchGameService)
        {
            _matchGameService = matchGameService;

            var observable = Observable.Interval(TimeSpan.FromSeconds(3));
            observable.Subscribe(x => Play());
        }

        private void Play()
        {
            if (!_matchGameService.GameInited || !_matchGameService.IsMyTime(out var time)) return;

            if (time.Phase == "S")
            {
                var charactersPositions = _matchGameService.GetCharacterPositions(out _);
                var character = GetAnyCharacter(charactersPositions);
                var sector = GetAnySector(charactersPositions);

                _matchGameService.PositionCharacter(sector, character);
            }
            else if (time.Phase == "P")
            {
                var charactersPositions = _matchGameService.GetCharacterPositions(out _);
                var character = charactersPositions.OrderByDescending(x => x.Value).First().Key;

                _matchGameService.PromoteCharacter(character);
            }
            else if (time.Phase == "V") _matchGameService.Voting("S");

        }

        private string? GetAnyCharacter(Dictionary<string, string> charactersPositions)
        {
            var characters = CharacterConst.Names.Select(x => x.Key).ToList();

            var charsSelecteds = charactersPositions
                .Where(x => x.Value != "0" && x.Value != "-1")
                .Select(x => x.Key);

            characters.RemoveAll(x => charsSelecteds.Contains(x));

            return characters.FirstOrDefault();
        }



        private string? GetAnySector(Dictionary<string, string> charactersPositions)
        {
            var sectors = Jogo.ListarSetores().HandleReponse<SectorEntity>().Entities.Select(x => x.Id).ToList();
            sectors.RemoveAll(x => x == "0" || x == "10" || x == "5"); 

            var sectorsCount = sectors.ToDictionary(key => key, value => 0);

            foreach (var charPosition in charactersPositions)
            {
                string sector = charPosition.Value;
                if (sectorsCount.ContainsKey(sector))
                {
                    sectorsCount[sector] = ++sectorsCount[sector];
                }
            }

            return sectorsCount.OrderBy(x => x.Value).FirstOrDefault().Key;
        }



    }
}
