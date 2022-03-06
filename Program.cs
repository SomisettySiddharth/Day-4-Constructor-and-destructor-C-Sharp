using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Constructor_Overloading
{
    class Movie
    {
        string name;
        int Releasedate;
        //Default Constructor
        public Movie()
        {
            name = "Radhe Shyam";
            Releasedate = 11;
            Console.WriteLine(name + " Releasing this week " + " . Date:  " + Releasedate);
        }
        // Constructor with Arguments
        public Movie(string name, int Releasedate1)
        {
            name = "RRR";
            Releasedate = Releasedate1;
            Console.WriteLine(name + " Releasing next week " + " . Date:  " + Releasedate1);
        }
        //Destructor
        ~Movie()
        { Console.WriteLine("Deleted"); }
    }
    class theatre
    {
        static void Main(string[] args)
        {
            Movie m = new Movie(); //Default Constructor Called
            Movie m2 = new Movie("RRR", 25); //Overloaded Constructor.
            Console.WriteLine(); //Destructor
        }
    }
}