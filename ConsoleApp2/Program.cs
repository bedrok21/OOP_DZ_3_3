using System.Runtime.CompilerServices;

namespace ConsoleApp2_2 {

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            Console.WriteLine("Input comand:");
            string comand = "" + Console.ReadLine();
            switch(comand){
                case "addTeam":
                    Console.WriteLine("Input team name:");
                    Team team=new(Console.ReadLine());
                    teams.Add(team);
                    break;
                case "addWorker":
                    break;
                case "showGoupInfo":
                    break;
            }
        }
    } 
}