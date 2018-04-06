using System.Collections.Generic;

namespace Scoreboard.Model.Mediator
{
    public interface IMediator
    {
        void SendMessage(Colleague caller, KeyValuePair<string, object> valuePair);
    }
}
