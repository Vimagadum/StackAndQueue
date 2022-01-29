﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackAndQueue;

namespace StacksandQueue
{
    class Program
    {
        /// Defines the entry point of the application.
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue program using Linked List");
            CallStackQueue();
            Console.ReadLine();
        }
        /// Calls the stack queue.

        public static void CallStackQueue()
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            bool CONTINUE = true;
            while (CONTINUE)
            {
                Console.WriteLine("\nEnter your option!");
                Console.WriteLine("1=Stack , 2=Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("<---Creating A Stack--->");
                        linkedListStack.Push(70);
                        linkedListStack.Push(30);
                        linkedListStack.Push(56);
                        linkedListStack.Display();
                        break;
                    case 2:
                        CONTINUE = false;
                        break;
                    default:
                        Console.WriteLine("Enter correct option!");
                        break;
                }
            }
        }
    }
}