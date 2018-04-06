using System.Collections.Generic;

namespace Scoreboard.Model.Mediator
{
    public abstract class Colleague
    {
        protected IMediator Mediator;
        protected Colleague(IMediator mediator)
        {
            Mediator = mediator;
        }
        public abstract void Receive(KeyValuePair<string, object> data);
    }
}
