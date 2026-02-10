using System;
using System.Collections.Generic;
using System.Text;

namespace ComportementDeLaPile.Models
{
    internal static class Model0
    {
        public static void DefinedModel()
        {

            Stack<int> pile = new Stack<int>();

            Console.WriteLine("Push 5");
            pile.Push(5);

            Console.WriteLine("Push 42");
            pile.Push(42);
            // point the highest stack and return it's index
            Console.WriteLine($"The highest stack is on index {pile.Count-1}");

            Console.WriteLine("Pop -> " + pile.Pop()); // 42
            Console.WriteLine("Pop -> " + pile.Pop()); // 5
        }
        public static void SelectAction() {
            Console.WriteLine("Exemple finished.\nIf you want to restart insert '1'.");
            Console.Write("Input: ");
            string? input = Console.ReadLine();
            if (input != "1")
            {
                Console.WriteLine("Wrong input, exiting...");
                return;
            }
            else {
                Console.Clear();
                MenuModel();
            }
        }
        public static void MenuModel() {
            Console.WriteLine("Welcome!\nPlease see how stacks works.");
            DefinedModel();
            SelectAction();
        }
    }
}
