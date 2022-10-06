using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Team
    {
        private string Name;
        private List<Worker> workers = new List<Worker>();
        public Team(string name)
        {
            Name = name;
        }
        public void AddWorker(Worker w)
        {
            workers.Add(w);
        }
        public void PrintInfo()
        {
            Console.WriteLine(Name);
            foreach (Worker w in workers)
            {
                Console.WriteLine(w.GetName());
            }
        }
        public void PrintFullInfo()
        {
            Console.WriteLine(Name);
            foreach(Worker w in workers)
            {
                Console.WriteLine(w.GetInfo());
            }
        }
    }
}
