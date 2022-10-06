﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Manager : Worker
    {
        public Manager(string name) : base(name)
        {
            Position = "Менеджер";
        }
        private Random rand = new Random();
        public override void FillWorkDay()
        {
            for(int i = 0; i < rand.Next(10); i++)
            {
                Call();
            }
            Relax();
            for (int i = 0; i < rand.Next(5); i++)
            {
                Call();
            }
        }
    }
}
