using System.Collections.Generic;
using Scoreboard.Model.Helpers;
using Scoreboard.Model.Interfaces;
using Scoreboard.Model.Mediator;

namespace Scoreboard.Model
{
    public class MainMenuRepository : Colleague, IMainMenuRepository
    {
        private readonly Challenger[] challengers;
        private MatchDetails matchDetails;
        private int pointsChallegerA;
        private int pointsChallengerB;
        private bool visibityScoreboard;


        public MainMenuRepository(IMediator mediator) : base(mediator)
        {
            challengers = new Challenger[2];
            visibityScoreboard = false;
        }
        public void CreateChallenger(Challenger challenger, bool isFirst)
        {
            if(isFirst)
            {
                challengers[0] = challenger;
                return;
            }
            challengers[1] = challenger;
        }
        public void ScoreboardUpdateChallengerData()
        {
            Send(this, new KeyValuePair<string, object>("First challenger", challengers[0]));
            Send(this, new KeyValuePair<string, object>("Second challenger", challengers[1]));
        }

        public void ScoreboardUpdateMatchDetailsData()
        {
            Send(this, new KeyValuePair<string, object>("Match details", matchDetails));
        }

        public List<string> SetColleguesToChoice()
        {
            return ConstantDataHelper.ColleaguesList();
        }

        public List<string> SetTournamentStateToChoice()
        {
            return ConstantDataHelper.TournamentStageList();
        }

        public List<string> SetWeightCategoriesToChoice()
        {
            return ConstantDataHelper.WeightCategoryList();
        }


        public void SetMatchDetails(MatchDetails matchInfo)
        {
            matchDetails = matchInfo;
        }
        public void SetPoints(int points, bool isFirst)
        {
            if(isFirst)
            {
                pointsChallegerA = points;
                return;
            }
            pointsChallengerB = points;
        }

        public void SetScoreboardVisibility()
        {
            Send(this, new KeyValuePair<string, object>("Visibility", visibityScoreboard));
            visibityScoreboard = !visibityScoreboard;
        }
        private void Send(Colleague colleague, KeyValuePair<string, object> keyValuePair)
        {
            Mediator.SendMessage(colleague, keyValuePair);
        }

        public override void Receive(KeyValuePair<string, object> data)
        {
            //            if(!properties.ContainsKey(data.Key))
            //            {
            //                properties.Add(data.Key, data.Value);
            //            }
            //            else
            //            {
            //                properties[data.Key] = data.Value;
            //            }
        }
    }
}
