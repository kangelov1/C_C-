﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    
    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(()=>new Singleton());
        public static Singleton GetInstance
        {
            get { return instance.Value; }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value is " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}
