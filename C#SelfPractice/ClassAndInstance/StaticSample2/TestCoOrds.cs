using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Test01: This example use both default and parameterized constructors.
//Test02: This example demonstrate a feature that is unique to structs.
//It creates a CoOrds object without using the new operator.
//If you relace the word struct with the word class, the program will not compile.

namespace StaticSample2
{
   
    class TestCoOrds
    {
        static void Main(string[] args)
        { 
            //Declare and initialize strcut objects.
            //Initialze:
            CoOrds coords1 = new CoOrds();
            CoOrds coords2 = new CoOrds(10,10);

            // Display result:
            Console.WriteLine("CoOrds 1:");
            Console.WriteLine("x = {0}, y = {1}", coords1.x, coords1.y);

            Console.WriteLine("CoOrds 2:");
            Console.WriteLine("x = {0}, y = {1}", coords2.x, coords2.y);


            //Declare a struct object without "new".
            //Declare an object:
            CoOrds coords3;

            //Initialize:
            coords3.x = 20;
            coords3.y = 20;

            //Display results:
            Console.WriteLine("CoOrds 3:");
            Console.WriteLine("x = {0}, y = {1}", coords3.x, coords3.y);

            //Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
     
    }
}
