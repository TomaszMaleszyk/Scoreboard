using System.Collections.Generic;

namespace Scoreboard.Model.Helpers
{
   public static class ConstantDataHelper
    {
        public static List<string> ColleaguesList()
        {
            return new List<string>
            {
                "KUL",
                "Politechnika Lubelska"
            };
        }
        public static List<string> TournamentStageList()
        {
            return new List<string>
            {
                "Semifinal",
                "Final"
            };
        }
        public static List<string> WeightCategoryList()
        {
            return new List<string>
            {
                "120",
                "80"
            };
        }
    }
}
