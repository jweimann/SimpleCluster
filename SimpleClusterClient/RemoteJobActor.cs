using System;
using Akka.Actor;

namespace SimpleClusterClient
{
    internal class RemoteJobActor : UntypedActor
    {
        public RemoteJobActor()
        {
        }
        protected override void OnReceive(object message)
        {
            throw new NotImplementedException();
        }
    }
}