using Akka.Actor;
using System;

namespace SimpleCluster
{
    class Program
    {
        static void Main(string[] args)
        {
            ActorSystem system = ActorSystem.Create("webcrawler");
            system.ActorOf<ServerListenerActor>("api");

            Console.ReadLine();
        }
    }
}
