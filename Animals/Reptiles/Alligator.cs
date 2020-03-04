using System;
using Animals.Reptiles;
using System.Collections.Generic;
using System.Text;

namespace Animals.Reptiles
{
    class Alligator
    {   // access modifier // what kind of property it is // property name // you can get the property and set the value of this property .... this is a property
        // syntactic sugar - things that make it eaiser 
        public bool IsAquatic { get; set; }
        private int _stepGoal;
        private int _stepCount;

        public Alligator(int stepGoal)
        {
            IsAquatic = true;
            _stepGoal = stepGoal;
        }

        // public - access moditifier 
        // void - return type -- void doesn't return anything
        // grunt () Method

        // CLR  - wait what is this again?
        public void Grunt ()
        {
            // i don't need "If (IsAquatic == true)" ...I don't need to compaer it to a bool because it already is a boolean
            if (IsAquatic)
            {
                Console.WriteLine("Bubble Bubble");
            }
            else
            {
                Console.WriteLine("GRRRR!");
            }
        }
        // This is called a "method signature" which is made of of 4 parts (1)access modifier/(2)methods return type/(3)name/(4)parameters
        // c# wants to know how many or what kind of thing steps is. so we put "int" in front of "steps"
        // ?? a class that doesn't have an explicit system modifier is by default an "internal class"
        // if I want it to be available everywhere it will be public class
        // a class member is implicitly private (only useable within the class)
        // internal - just in this file. 
        // private - inside this class
        // public -everyone gets it
        public void Run (int steps)
        {
            _stepCount += steps;

            if ( _stepCount >= _stepGoal)
            {
                Console.WriteLine("Congratulations you met your step goal");
            }
           
            Console.WriteLine($"You Ran {steps} steps.");
        }
    }
}

