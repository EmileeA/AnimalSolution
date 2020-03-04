using System;
using Animals.Reptiles;

namespace Animals // higher level grouping -- similar to an import statement -- bundles of classes --in general coinicide with the folder structure it's apart of
{
    class Program // a chunk of functionality and data with methods
    {
        // Functions are a block of code you can call by name
        // methods belonger to a larger thing, that thing is called a class
        static void Main(string[] args)
        {
            // instantiation
            var americanAlligator = new Alligator(100);
            americanAlligator.IsAquatic = true;

            var africanAlligator = new Alligator(2);
            africanAlligator.IsAquatic = false;

            africanAlligator.Grunt();

            americanAlligator.Grunt();

            americanAlligator.Run(75);
            africanAlligator.Run(4);
            americanAlligator.Run(40);
        }
    }
}
