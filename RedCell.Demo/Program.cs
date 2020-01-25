﻿﻿using System;
using RedCell.Diagnostics.Update;

namespace RedCell.Demo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Log.Console = true;
            Console.WriteLine("Hello World");
            var updater = new Updater();
            updater.StartMonitoring();
        }
    }
}