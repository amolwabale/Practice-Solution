﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandGroup obj = new CommandGroup();
            obj.AddCommand(new Close());
            obj.AddCommand(new Open());
            obj.AddCommand(new Print());
            obj.ExecuteCommand();

            //Usage of command design pattern
            //Undo/redo
            //Queuing task
            //remote control
            //Game development where each where each user input is decoupled from actual logic.
        }
    }
}
