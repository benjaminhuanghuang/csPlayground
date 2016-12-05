﻿using System;

using CSPlayground.Threads;
using CSPlayground.AsyncAwait;

namespace CSPlayground
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // --  Async Await
            // AsyncAwaitDemo.ButtonClick1();
            // AsyncAwaitDemo.ButtonClick2();
            // AsyncAwaitDemo.ButtonClick2_Wrong();
            // Console.ReadLine(); // Wait the async function.
            
            // -- Thread
            MultiThreadDemo.TwoThreads();

            
        }
    }
}
