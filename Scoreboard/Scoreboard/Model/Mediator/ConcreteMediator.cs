using System.Collections.Generic;

namespace Scoreboard.Model.Mediator
{
    public class ConcreteMediator : IMediator
    {
        // dictionary register itd
        public MainMenuRepository Colleague1 { get; set; }
        public ScoreBoardRepository Colleague2 { get; set; }
        public void SendMessage(Colleague caller, KeyValuePair<string,object> valuePair)
        {
            // Open-closed principle

            if(caller == Colleague1)
                Colleague2.Receive(valuePair);
            else
                Colleague1.Receive(valuePair);
        }
    }
}
