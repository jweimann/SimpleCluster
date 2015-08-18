using Akka.Actor;
using Akka.Routing;
using System;

namespace SimpleClusterClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ActorSystem system = ActorSystem.Create("webcrawler");

            Console.ReadLine();
            var router = system.ActorOf(Props.Create(() => new RemoteJobActor()).WithRouter(FromConfig.Instance), "tasker");
            router.Tell("Something");

            var routees = router.Ask<Routees>(new GetRoutees()).Result;


            Console.ReadLine();
        }
    }
}
