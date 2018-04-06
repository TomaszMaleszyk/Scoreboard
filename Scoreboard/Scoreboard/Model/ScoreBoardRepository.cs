using System;
using System.Collections.Generic;
using Scoreboard.Model.Interfaces;
using Scoreboard.Model.Mediator;

namespace Scoreboard.Model
{
    public class ScoreBoardRepository : Colleague, IScoreBoardRepository
    {
        private Challenger[] challengers;
        private MatchDetails matchDetails;
        private int pointsChallegerA;
        private int pointsChallengerB;
        private bool visibilityScoreboard;
        public ScoreBoardRepository(IMediator mediator) : base(mediator)
        {
            challengers = new Challenger[2];
            matchDetails = new MatchDetails(new TimeSpan(0, 0, 0, 0), "Blank", "Blank");
        }

        public void CreateChallenger(string name, string surname, string college, bool isFirst)
        {
            if(isFirst)
            {
                challengers[0] = new Challenger(name, surname, college);
                return;
            }
            challengers[1] = new Challenger(name, surname, college);
        }
        public Challenger GetChallenger(bool isFirst)
        {
            return isFirst ? challengers[0] : challengers[1];
        }
        public void SetMatchDetails(TimeSpan time, string competitionCategory, string tournamentStage)
        {
            matchDetails = new MatchDetails(time, competitionCategory, tournamentStage);
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
        public MatchDetails GetMatchDetails()
        {
            return matchDetails;
        }
        public string GetPoints(bool isFirst)
        {
            return isFirst ? pointsChallegerA.ToString() : pointsChallengerB.ToString();
        }

        public bool GetVisibility()
        {
            return visibilityScoreboard;
        }

        public override void Receive(KeyValuePair<string, object> data)
        {
            if(data.Key == "Match details")
            {
                matchDetails = (MatchDetails)data.Value;
            }
            if(data.Key == "Visibility")
            {
                visibilityScoreboard = (bool)data.Value;
            }
            if(data.Key == "First challenger")
            {
                challengers[0] = (Challenger)data.Value;
            }
            if(data.Key == "Second challenger")
            {
                challengers[1] = (Challenger)data.Value;
            }
        }
    }
}
