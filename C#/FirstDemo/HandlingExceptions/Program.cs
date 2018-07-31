using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                var content = File.ReadAllText(@"Exampl.txt");
                Console.WriteLine(content);

                 
            }catch(FileNotFoundException ex){
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the file is named correctly: Example.txt ");
            
            }catch(DirectoryNotFoundException ex){
                Console.WriteLine("There was a problem!");
                Console.WriteLine(@"Make sure the Directory Debug/Example.txt of the file exists.");
            
            }catch(Exception ex){
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally {
                // code to finalize Setting objects to null
                // Closing database connections
                Console.WriteLine("Closing application now...");
            }
            Console.ReadLine();
        }
    }
}